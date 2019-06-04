using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApfelGym
{
    public partial class Customers : Form
    {
        private bool gridItemsChanged = false;
        private List<GridPoint> entrySaved = new List<GridPoint>();
        private Database db = new Database();

        public Customers()
        {
            InitializeComponent();
        }

        private void SetDataSource(DataTable dt)
        {
            if (dt != null)
            {
                customerGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to get data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            LoadClientInfo();

            //customerGridView.Columns["ID"].ReadOnly = true;
            customerGridView.Columns["ID"].Visible = false;
            customerGridView.ContextMenuStrip = contextMenuStrip1;
        }

        public void LoadClientInfo()
        {
            DataTable dt = db.GetDataTable("SELECT * FROM Client ORDER BY FullName ASC");
            SetDataSource(dt);
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerAdd().ShowDialog();
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridItemsChanged)
            {
                gridItemsChanged = false;

                int count = 0;

                foreach (GridPoint gpt in entrySaved)
                {
                    string Id = Database.FilterParam(customerGridView.Rows[gpt.row].Cells["ID"].Value.ToString());

                    string columnUpdated = Database.FilterParam(customerGridView.Columns[gpt.column].Name);
                    string value = Database.FilterParam(customerGridView.Rows[gpt.row].Cells[gpt.column].Value.ToString());

                    customerGridView.Rows[gpt.row].Cells[gpt.column].Style.BackColor = Color.White;

                    string query = string.Format("UPDATE Client SET {0} = '{1}' WHERE ID = {2}", columnUpdated, value, Id);

                    if (db.ExecNoResult(query))
                    {
                        count++;
                    }
                }
                LoadClientInfo();
                if (count == entrySaved.Count)
                {
                    MessageBox.Show("Updated succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                entrySaved.Clear();
            }
        }

        class GridPoint
        {
            public int row;
            public int column;
        }

        private void customerGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                gridItemsChanged = true;
                entrySaved.Add(new GridPoint() { row = e.RowIndex, column = e.ColumnIndex });
                customerGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
            }
        }

        private void deleteSelectedEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerGridView.SelectedRows.Count > 0)
            {
                int count = 0;
                int selectedRows = customerGridView.SelectedRows.Count;
                foreach (DataGridViewRow row in customerGridView.SelectedRows)
                {
                    string Id = Database.FilterParam(customerGridView.Rows[row.Index].Cells["ID"].Value.ToString());

                    string query = string.Format("DELETE FROM Client WHERE ID = {0}", Id);

                    if (db.ExecNoResult(query))
                    {
                        count++;
                    }
                }

                LoadClientInfo();
                if (count == selectedRows)
                {
                    MessageBox.Show("Selected entries deleted succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void refreshEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadClientInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                LoadClientInfo();
            }
            else
            {
                string searchstr = Database.FilterParam(textBox1.Text);

                DataTable dt = db.GetDataTable("SELECT * FROM Client WHERE ID LIKE '%" + searchstr + "%' OR FullName LIKE '%" + searchstr + "%' OR PersonalCode LIKE '%" + searchstr + "%' OR Email LIKE '%" + searchstr + "%' OR Address LIKE '%" + searchstr + "%' OR PhoneNumber LIKE '%" + searchstr + "%'");

                customerGridView.DataSource = dt;

            }
        }
    }
}
