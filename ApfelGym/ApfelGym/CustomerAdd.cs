using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ApfelGym
{
    public partial class CustomerAdd : Form
    {
        private Database db = new Database();

        public CustomerAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if((!textBox3.Text.Contains("@") || Regex.IsMatch(textBox5.Text, "[a-zA-Z]") || Regex.IsMatch(textBox1.Text, "[0-9]")) && (textBox1.Text.Length < 4 || textBox2.Text.Length < 4 || textBox3.Text.Length < 4 || textBox5.Text.Length < 6))
            {
                MessageBox.Show("There was some errors, please check your data in fields and try again!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = string.Format("INSERT INTO Client (FullName, PersonalCode, Email, Address, PhoneNumber) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                Database.FilterParam(textBox1.Text),
                Database.FilterParam(textBox2.Text),
                Database.FilterParam(textBox3.Text),
                Database.FilterParam(textBox4.Text),
                Database.FilterParam(textBox5.Text)
                );

                if (db.ExecNoResult(query))
                {
                    MessageBox.Show("Client was succesfully added to database!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Close();
                }
            }   
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
