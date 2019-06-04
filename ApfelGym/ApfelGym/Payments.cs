using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ApfelGym
{
    

    public partial class Payments : Form
    {
        private Database msaccess = new Database();
        private bool gridItemsChanged = false;
        private List<GridPoint> entrySaved = new List<GridPoint>();
        

        public Payments()
        {
            InitializeComponent();
        }

        public Payments(bool search) : this()
        {
            entrySaved.Clear();
            gridItemsChanged = false;

            if (!search)
            {
                label1.Visible = false;
                searchBox.Visible = false;
                button1.Visible = false;
                checkBox1.Visible = false;
            }
            else
            {
                paymentsGrid.ContextMenuStrip = null;
                paymentsGrid.ContextMenuStrip = contextMenuStrip2;
            }
        }

        private void LoadPaymentsInfo()
        {
            DataTable dt = msaccess.GetDataTable("SELECT p.ID, c.FullName, c.PersonalCode, p.Amount, p.PaymentType, p.PaymentReceived FROM (Client c INNER JOIN Subscription sub ON sub.ClientID = c.ID) INNER JOIN Payment p ON p.SubscriptionID = sub.ID ORDER BY p.PaymentReceived DESC");

            SetDataSource(dt);
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            LoadPaymentsInfo();
            paymentsGrid.Columns["ID"].Visible = false;
            paymentsGrid.Columns["PersonalCode"].ReadOnly = true;
            paymentsGrid.Columns["FullName"].ReadOnly = true;
            paymentsGrid.Columns["PaymentReceived"].ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!button1.Enabled)
            {
                if (string.IsNullOrEmpty(searchBox.Text))
                {
                    LoadPaymentsInfo();
                }
                else
                {
                    string searchstr = Database.FilterParam(searchBox.Text);

                    DataTable dt = msaccess.GetDataTable("SELECT p.ID, c.FullName, c.PersonalCode, p.Amount, p.PaymentType, p.PaymentReceived FROM (Client c INNER JOIN Subscription sub ON sub.ClientID = c.ID) INNER JOIN Payment p ON p.SubscriptionID = sub.ID"
                        + " WHERE c.FullName LIKE '%" + searchstr + "%'"
                        + " OR c.PersonalCode LIKE '%" + searchstr + "%'"
                        + " OR p.Amount LIKE '%" + searchstr + "%'"
                        + " OR p.PaymentType LIKE '%" + searchstr + "%'"
                        + " OR p.PaymentReceived LIKE '%" + searchstr + "%'"
                        + " OR p.SubscriptionID LIKE '%" + searchstr + "%' ORDER BY p.PaymentReceived DESC");

                    SetDataSource(dt);
                }
            }
        }

        private void SetDataSource(DataTable dt)
        {
            if (dt != null)
            {
                paymentsGrid.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to get data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                LoadPaymentsInfo();
            }
            else
            {
                string searchstr = Database.FilterParam(searchBox.Text);

                DataTable dt = msaccess.GetDataTable("SELECT p.ID, c.FullName, c.PersonalCode, p.Amount, p.PaymentType, p.PaymentReceived, sub.ID FROM (Client c INNER JOIN Subscription sub ON sub.ClientID = c.ID) INNER JOIN Payment p ON p.SubscriptionID = sub.ID"
                        + " WHERE c.FullName LIKE '%" + searchstr + "%'"
                        + " OR c.PersonalCode LIKE '%" + searchstr + "%'"
                        + " OR p.Amount LIKE '%" + searchstr + "%'"
                        + " OR p.PaymentType LIKE '%" + searchstr + "%'"
                        + " OR p.PaymentReceived LIKE '%" + searchstr + "%'"
                        + " OR p.SubscriptionID LIKE '%" + searchstr + "%' ORDER BY p.PaymentReceived DESC");

                SetDataSource(dt);
            }
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridItemsChanged)
            {
                gridItemsChanged = false;

                int count = 0;

                foreach(GridPoint gpt in entrySaved)
                {
                    string Id = Database.FilterParam(paymentsGrid.Rows[gpt.GetRow()].Cells["ID"].Value.ToString());
                    /*string paymentRecv = Database.FilterParam(paymentsGrid.Rows[gpt.GetRow()].Cells["PaymentReceived"].Value.ToString());
                    //dirty hack here to remove odd dot in Date
                    paymentRecv = paymentRecv.Substring(0, 10).Replace(".", "-") +" "+ paymentRecv.Substring(11, paymentRecv.Length - 11);*/

                    string columnUpdated = Database.FilterParam(paymentsGrid.Columns[gpt.GetColumn()].Name);
                    string value = Database.FilterParam(paymentsGrid.Rows[gpt.GetRow()].Cells[gpt.GetColumn()].Value.ToString());

                    paymentsGrid.Rows[gpt.GetRow()].Cells[gpt.GetColumn()].Style.BackColor = Color.White;

                    string query = string.Format("UPDATE Payment SET {0} = '{1}' WHERE ID = {2}", columnUpdated, value, Id);

                    if (msaccess.ExecNoResult(query))
                    {
                        count++;
                    }
                }   

                if(count == entrySaved.Count)
                {
                    MessageBox.Show("Updated succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                entrySaved.Clear();
                LoadPaymentsInfo();
            }
        }

        private void paymentsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                gridItemsChanged = true;
                entrySaved.Add(new GridPoint(e.RowIndex, e.ColumnIndex));
                paymentsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
            }    
        }

        private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(paymentsGrid.SelectedRows.Count > 0)
            {
                int count = 0;
                int selectedRows = paymentsGrid.SelectedRows.Count;
                foreach (DataGridViewRow row in paymentsGrid.SelectedRows)
                {
                    string Id = Database.FilterParam(paymentsGrid.Rows[row.Index].Cells["ID"].Value.ToString());

                    string query = string.Format("DELETE FROM Payment WHERE ID = {0}", Id);

                    if (msaccess.ExecNoResult(query))
                    {
                        count++;
                    }
                }

                LoadPaymentsInfo();
                if (count == selectedRows)
                {
                    MessageBox.Show("Selected entries deleted succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

    class GridPoint
    {
        private int row;
        private int column;

        public GridPoint(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public int GetRow()
        {
            return row;
        }

        public int GetColumn()
        {
            return column;
        }
    }
}
