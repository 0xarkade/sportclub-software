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
    public partial class Trainers : Form
    {
        private Database db = new Database();

        public Trainers()
        {
            InitializeComponent();
        }

        private void Trainers_Load(object sender, EventArgs e)
        {
            LoadAllTrainers();

            
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

        private void LoadAllTrainers()
        {
            try
            {
                DataTable dt = db.GetDataTable("SELECT * FROM Trainer");
                SetDataSource(dt);

                dataGridView1.Columns["ID"].Visible = false;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >= 4 && textBox2.Text.Length >= 4 && textBox3.Text.Length >=4 && textBox4.Text.Length >= 4)
            {
                string fullName = Database.FilterParam(textBox1.Text);
                string PersonalCode = Database.FilterParam(textBox2.Text);
                string Email = Database.FilterParam(textBox3.Text);
                string phoneNumber = Database.FilterParam(textBox4.Text);

                string SQL = string.Format("INSERT INTO Trainer (FullName, PersonalCode, Email, PhoneNumber) VALUES ('{0}', '{1}', '{2}', '{3}')", fullName, PersonalCode, Email, phoneNumber);

                if (db.ExecNoResult(SQL))
                {
                    MessageBox.Show("Trainer was succesfully added!", "Info");
                }
            }
        }
    }
}
