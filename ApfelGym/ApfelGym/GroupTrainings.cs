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
    public partial class GroupTrainings : Form
    {
        private Database db = new Database();

        public GroupTrainings()
        {
            InitializeComponent();
        }

        private void GroupTrainings_Load(object sender, EventArgs e)
        {
            LoadAllGroupTrainings();
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

        private void LoadAllGroupTrainings()
        {
            try
            {
                DataTable dt = db.GetDataTable("SELECT * FROM GroupTraining");
                SetDataSource(dt);

                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["FullName"].ReadOnly = true;
                dataGridView1.Columns["PersonalCode"].ReadOnly = true;
            }
            catch { }
        }

        private void LoadAssignedTrainings()
        {
            DataTable dt = db.GetDataTable("SELECT c.FullName, c.PersonalCode, g.TrainingName, g.Duration, g.StartDate, t.FullName AS [Trainer_Name] FROM ((Client c INNER JOIN ClientGroupTraining cg ON c.ID = cg.ClientID) INNER JOIN GroupTraining g ON cg.TrainingID = g.ID) INNER JOIN Trainer t ON t.PersonalCode = g.TrainerID");
            SetDataSource(dt);
        }

        private void allGroupTrainingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllGroupTrainings();
        }

        private void assignedGroupTrainingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAssignedTrainings();
        }

        private void assignGroupTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int count = 0;
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string ID = dataGridView1.Rows[row.Index].Cells["ID"].Value.ToString();
                    string personalCode = Database.FilterParam(searchBox.Text);
                    long clientID = db.GetDecimalQuery("SELECT ID FROM Client WHERE PersonalCode = '" + personalCode + "'");

                    string SQL = string.Format("INSERT INTO ClientGroupTraining (ClientID, TrainingID, AssignDate) VALUES ({0}, {1}, date())", clientID, ID);

                    if (db.ExecNoResult(SQL))
                    {
                        count++;
                    }
                }

                if(count == dataGridView1.SelectedRows.Count)
                {
                    MessageBox.Show("Training(s) were assigned to customer!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteGroupTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int count = 0;
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string ID = dataGridView1.Rows[row.Index].Cells["ID"].Value.ToString();

                    string SQL_ = string.Format("DELETE FROM ClientGroupTraining WHERE TrainingID = " + ID);

                    string SQL = string.Format("DELETE FROM GroupTraining WHERE ID = " + ID);

                    if (db.ExecNoResult(SQL_) && db.ExecNoResult(SQL))
                    {
                        count++;
                    }
                }

                if (count == dataGridView1.SelectedRows.Count)
                {
                    MessageBox.Show("Training(s) were deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
