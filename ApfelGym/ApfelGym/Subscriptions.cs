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
    public partial class Subscriptions : Form
    {
        private Database db = new Database();

        public Subscriptions()
        {
            InitializeComponent();
        }

        private void SetDataSource(DataTable dt)
        {
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to get data from database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void LoadSubscriptionInfo()
        {
            DataTable dt = db.GetDataTable("SELECT s.ID, c.FullName, c.PersonalCode, s.SubscriptionStart, s.SubscriptionEnd, st.SubscriptionName, st.Price FROM (Client c INNER JOIN Subscription s ON c.ID = s.ClientID) INNER JOIN SubscriptionType st ON s.SubscriptionType = st.ID");
            SetDataSource(dt);
        }

        private void Subscriptions_Load(object sender, EventArgs e)
        {
            LoadSubscriptionInfo();
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["PersonalCode"].ReadOnly = true;
            dataGridView1.Columns["FullName"].ReadOnly = true;
        }

        private void customersWhoPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = db.GetDataTable("SELECT s.ID, c.FullName, c.PersonalCode, s.SubscriptionStart, s.SubscriptionEnd, st.SubscriptionName, st.Price, p.Amount AS [TotalPaid] FROM ((Client c INNER JOIN Subscription s ON c.ID = s.ClientID) INNER JOIN SubscriptionType st ON s.SubscriptionType = st.ID) INNER JOIN Payment p ON p.SubscriptionID = s.ID " +
                "WHERE p.SubscriptionID = s.ID");
            SetDataSource(dt);


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (dataGridView1.Rows[row.Index].Cells[col.Index].Value != null)
                    {
                        dataGridView1.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.LightGreen;
                    }
                }
            }

        }

        private void setNormalColor()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    dataGridView1.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.White;
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setNormalColor();
            LoadSubscriptionInfo();
        }

        private void customersWhoHaventPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = db.GetDataTable("SELECT s.ID, c.FullName, c.PersonalCode, s.SubscriptionStart, s.SubscriptionEnd, st.SubscriptionName, st.Price FROM ((Client c INNER JOIN Subscription s ON c.ID = s.ClientID) INNER JOIN SubscriptionType st ON s.SubscriptionType = st.ID) LEFT JOIN Payment p ON p.SubscriptionID = s.ID " +
               "WHERE p.SubscriptionID IS NULL");
            SetDataSource(dt);


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (dataGridView1.Rows[row.Index].Cells[col.Index].Value != null)
                    {
                        dataGridView1.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchStr = Database.FilterParam(searchBox.Text);

            if (string.IsNullOrEmpty(searchBox.Text))
            {
                LoadSubscriptionInfo();
            }
            else
            {
                DataTable dt = db.GetDataTable("SELECT s.ID, c.FullName, c.PersonalCode, s.SubscriptionStart, s.SubscriptionEnd, st.SubscriptionName, st.Price FROM (Client c INNER JOIN Subscription s ON c.ID = s.ClientID) INNER JOIN SubscriptionType st ON s.SubscriptionType = st.ID " +
                "WHERE c.FullName LIKE '%" + searchStr + "%' OR c.PersonalCode LIKE '%" + searchStr + "%' OR s.SubscriptionStart LIKE '%" + searchStr + "%' OR s.SubscriptionEnd LIKE '%" + searchStr + "%' OR st.SubscriptionName LIKE '%" + searchStr + "%'"
                + " OR st.Price LIKE '%" + searchStr + "%'");
                SetDataSource(dt);
            }

        }

        private void deleteSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("This will delete payment history for selected subscription(s), continue?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    int count = 0;
                    int selectedRows = dataGridView1.SelectedRows.Count;
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        string Id = Database.FilterParam(dataGridView1.Rows[row.Index].Cells["ID"].Value.ToString());

                        //We need to delete dependency from Payment in order to delete Subscription entry.
                        string query = string.Format("DELETE FROM Payment WHERE SubscriptionID = {0}", Id);

                        if (db.ExecNoResult(query))
                        {
                            count++;
                        }

                        //Now delete row from subscription
                        query = string.Format("DELETE FROM Subscription WHERE ID = {0}", Id);

                        if (db.ExecNoResult(query))
                        {
                            count++;
                        }
                    }

                    LoadSubscriptionInfo();

                    //2 count = 1 succesfull row deletion (2 queries = 1 row)
                    if ((count / 2) == selectedRows)
                    {
                        MessageBox.Show("Selected entries deleted succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
