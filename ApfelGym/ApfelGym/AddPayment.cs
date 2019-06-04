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
    public partial class AddPayment : Form
    {
        private Database db = new Database();
        private List<SubscriptionXClient> lst = new List<SubscriptionXClient>();

        public AddPayment()
        {
            InitializeComponent();
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            string SQL = "SELECT s.ID, c.ID AS [CID], c.FullName, c.PersonalCode, st.SubscriptionName, st.Price, DATEDIFF(\"m\", s.SubscriptionStart, s.SubscriptionEnd) AS [PeriodM] FROM((Client c INNER JOIN Subscription s ON c.ID = s.ClientID) INNER JOIN SubscriptionType st ON s.SubscriptionType = st.ID) LEFT JOIN Payment p ON p.SubscriptionID = s.ID " +
               "WHERE p.SubscriptionID IS NULL";

            DataTable dt = db.GetDataTable(SQL);

            comboBox2.Items.Clear();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        double periodM = Convert.ToDouble(row["PeriodM"].ToString());

                        if (periodM == 0) periodM = 1;

                        lst.Add(new SubscriptionXClient()
                        {
                            ID = row["ID"].ToString(),
                            ClientID = row["CID"].ToString(),
                            FullName = row["FullName"].ToString(),
                            PersonalCode = row["PersonalCode"].ToString(),
                            Price = (Convert.ToDouble(row["Price"].ToString()) * periodM).ToString()
                        });

                        comboBox2.Items.Add(row["ID"].ToString());
                    }
                }
                comboBox2.Text = lst[0].ID;
            }
            
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if(lst.Exists(x => x.ID == comboBox2.Text))
            {
                SubscriptionXClient sub = lst.Find(x => x.ID == comboBox2.Text);

                textBox2.Text = sub.FullName;
                textBox3.Text = sub.PersonalCode;
                textBox1.Text = sub.Price;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FullName = Database.FilterParam(textBox2.Text);
            string PersonalCode = Database.FilterParam(textBox3.Text);
            string Price = Database.FilterParam(textBox1.Text);
            string PaymentType = Database.FilterParam(comboBox1.Text);

            if(lst.Exists(x => x.PersonalCode == PersonalCode))
            {
                string ID = lst.Find(x => x.PersonalCode == PersonalCode).ID;


                string SQL = string.Format("INSERT INTO Payment (PaymentType, PaymentReceived, Amount, SubscriptionID) VALUES ('{0}', date(), {1}, {2})", PaymentType, Price, ID);

                if (db.ExecNoResult(SQL))
                {
                    MessageBox.Show("The payment was successfully added! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
    }

    public class SubscriptionXClient
    {
        public string ID;
        public string ClientID;
        public string PersonalCode;
        public string FullName;
        public string Price;
    }
}
