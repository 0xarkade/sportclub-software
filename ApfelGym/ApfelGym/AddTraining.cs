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
    public partial class AddTraining : Form
    {
        private Database db = new Database();
        private List<Trainer> trainers = new List<Trainer>();

        public AddTraining()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string trainingName = Database.FilterParam(textBox1.Text);
            string duration = Database.FilterParam(textBox2.Text);
            string startDate = Database.FilterParam(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"));
            string trainerID = "";

            foreach(Trainer t in trainers)
            {
                if(t.FullName == comboBox1.Text)
                {
                    trainerID = t.ID;
                    break;
                }
            }

            string SQL = string.Format("INSERT INTO GroupTraining (TrainingName, Duration, StartDate, TrainerID) VALUES ('{0}', '{1}', #{2}#, '{3}')", trainingName, duration, startDate, trainerID);

            if (db.ExecNoResult(SQL))
            {
                MessageBox.Show("Training was added succesfully!");
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadTrainers()
        {
            try
            {
                trainers.Clear();
                comboBox1.Items.Clear();

                DataTable dt = db.GetDataTable("SELECT TOP 30 PersonalCode, FullName FROM Trainer");

                foreach (DataRow row in dt.Rows)
                {
                    trainers.Add(new Trainer() { ID = row["PersonalCode"].ToString(), FullName = row["FullName"].ToString() });
                    comboBox1.Items.Add(row["FullName"].ToString());
                }

                comboBox1.Text = trainers[0].FullName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTraining_Load(object sender, EventArgs e)
        {
            LoadTrainers();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                trainers.Clear();
                comboBox1.Items.Clear();

                string searchStr = Database.FilterParam(comboBox1.Text);

                DataTable dt = db.GetDataTable("SELECT TOP 30 PersonalCode, FullName FROM Trainer WHERE FullName LIKE '%" + searchStr + "%' OR PersonalCode LIKE '%" + searchStr + "%'");

                foreach (DataRow row in dt.Rows)
                {
                    trainers.Add(new Trainer() { ID = row["PersonalCode"].ToString(), FullName = row["FullName"].ToString() });
                    comboBox1.Items.Add(row["FullName"].ToString());

                    comboBox1.Text = trainers[0].FullName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Trainer
    {
        public string ID;
        public string FullName;
    }
}
