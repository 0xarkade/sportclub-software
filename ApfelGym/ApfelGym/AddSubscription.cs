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
    public partial class AddSubscription : Form
    {
        private Database db = new Database();
        private List<Customer> customers = new List<Customer>();
        private List<Subscription> subscriptions = new List<Subscription>();

        public AddSubscription()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                paymentGroup.Enabled = false;
            }
            else
            {
                paymentGroup.Enabled = true;
            }
        }

        private void LoadCustomers()
        {
            try
            {
                customers.Clear();
                DataTable dt = db.GetDataTable("SELECT TOP 30 ID, FullName, PersonalCode FROM Client");

                foreach (DataRow row in dt.Rows)
                {
                    customers.Add(new Customer() { ID = row["ID"].ToString(), FullName = row["FullName"].ToString(), PersonalCode = row["PersonalCode"].ToString() });
                    fullnameCombo.Items.Add(row["FullName"].ToString());
                }

                fullnameCombo.Text = customers[0].FullName;
                textBox1.Text = customers[0].PersonalCode;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubscriptions()
        {
            try
            {
                subscriptions.Clear();
                subscriptionCombo.Items.Clear();

                DataTable dt = db.GetDataTable("SELECT TOP 30 * FROM SubscriptionType");

                foreach (DataRow row in dt.Rows)
                {
                    subscriptions.Add(new Subscription() { ID = row["ID"].ToString(), Name = row["SubscriptionName"].ToString(), Price = row["Price"].ToString() });
                    subscriptionCombo.Items.Add(row["SubscriptionName"].ToString());
                }

                subscriptionCombo.Text = subscriptions[0].Name;
                priceLabel.Text = subscriptions[0].Price + " €"; ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddSubscription_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadSubscriptions();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fullnameCombo_TextChanged(object sender, EventArgs e)
        {
            foreach(Customer cust in customers)
            {
                if(fullnameCombo.Text == cust.FullName)
                {
                    textBox1.Text = cust.PersonalCode;
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                customers.Clear();
                fullnameCombo.Items.Clear();

                string searchStr = Database.FilterParam(fullnameCombo.Text);

                //Query is limited to 30 entries because we don't want to overload our combobox resulting in long list and very confusing for end user.
                DataTable dt = db.GetDataTable("SELECT TOP 30 ID, FullName, PersonalCode FROM Client WHERE FullName LIKE '%" + searchStr + "%' OR PersonalCode LIKE '%" + searchStr + "%'");

                foreach (DataRow row in dt.Rows)
                {
                    customers.Add(new Customer() { ID = row["ID"].ToString(), FullName = row["FullName"].ToString(), PersonalCode = row["PersonalCode"].ToString() });
                    fullnameCombo.Items.Add(row["FullName"].ToString());

                    fullnameCombo.Text = customers[0].FullName;
                    textBox1.Text = customers[0].PersonalCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subscriptionCombo_TextChanged(object sender, EventArgs e)
        {
            foreach (Subscription sub in subscriptions)
            {
                if (subscriptionCombo.Text == sub.Name)
                {
                    if(sub.Name == "One visit")
                    {
                        periodCombo.Enabled = false;
                    }
                    else
                    {
                        periodCombo.Enabled = true;
                    }
                    priceLabel.Text = sub.Price + " €";
                    totalPrice.Text = sub.Price + " €";
                    periodCombo.Text = "1";
                    break;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void periodCombo_TextChanged(object sender, EventArgs e)
        {
            int months = 0;
            double currentPrice = 0;

            if(int.TryParse(periodCombo.Text, out months) && double.TryParse(priceLabel.Text.Substring(0, priceLabel.Text.Length -2), out currentPrice))
            {
                double result = months * currentPrice;
                totalPrice.Text = result.ToString() + " €";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(subscriptions.Exists(x => x.Name == subscriptionCombo.Text) && customers.Exists(x => x.PersonalCode == textBox1.Text))
            {
                Subscription sub = subscriptions.Find(x => x.Name == subscriptionCombo.Text);
                Customer c = customers.Find(x => x.PersonalCode == textBox1.Text);

                int months = int.Parse(periodCombo.Text);

                if (!periodCombo.Enabled) months = 0;//In case we have One time payment - it automatically disables periodComboBox so we can set 0 months. Probably this is not the best approach, have to be fixed in near future...

                string sqlSubscription = string.Format("INSERT INTO Subscription (SubscriptionType, SubscriptionStart, SubscriptionEnd, ClientID) VALUES ({0}, date(), DATEADD(\"m\", {1},  date()), {2})", sub.ID, months, c.ID);
                if (db.ExecNoResult(sqlSubscription))
                {
                    long ID = db.GetDecimalQuery("SELECT TOP 1 ID FROM Subscription ORDER BY ID DESC");

                    if (!checkBox1.Checked)
                    {
                        string Price = totalPrice.Text.Substring(0, totalPrice.Text.Length - 2);//remove euro sign and space

                        string sqlPayment = string.Format("INSERT INTO Payment (PaymentType, PaymentReceived, Amount, SubscriptionID) VALUES ('{0}', date(), {1}, {2})", comboBox5.Text, Price, ID);
                        if(db.ExecNoResult(sqlPayment)){
                            MessageBox.Show("Subscription have been succesfully added!", "Info");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Subscription have been succesfully added!", "Info");
                    } 
                }
            }
            else
            {
                MessageBox.Show("Sorry, requested permission doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Customer
    {
        public string ID;
        public string FullName;
        public string PersonalCode;
    }

    public class Subscription
    {
        public string ID;
        public string Name;
        public string Price;
    }
}
