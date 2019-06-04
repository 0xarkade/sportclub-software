using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ApfelGym
{
    public partial class Form1 : Form
    {
        private Database msaccess = new Database();

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Payments(false).ShowDialog();
        }

        private void searchPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Payments(true).ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            GetStatistics();
        }


        private void GetStatistics()
        {
            try
            {
                customerTotalLabel.Text = msaccess.GetDecimalQuery("SELECT COUNT(*) FROM Client").ToString();
                trainersTotalLabel.Text = msaccess.GetDecimalQuery("SELECT COUNT(*) FROM Trainer").ToString();
                customerVisitsTotalLabel.Text = msaccess.GetDecimalQuery("SELECT COUNT(*) FROM ClientVisits").ToString();
                paymentsTotalLabel.Text = msaccess.GetDoubleQuery("SELECT SUM(Amount) FROM Payment").ToString() + " €";
                paymentsThisMonth.Text = msaccess.GetDoubleQuery("SELECT SUM(Amount) FROM Payment WHERE PaymentReceived BETWEEN (DATEADD(\"m\",0, DateValue(DatePart(\"yyyy\", date()) & \" / \" & DatePart(\"m\", date())) )) AND (date())").ToString() + " €";
                paymentLastMonth.Text = msaccess.GetDoubleQuery("SELECT SUM(Amount) FROM Payment WHERE PaymentReceived BETWEEN (DATEADD(\"m\",-1, DateValue(DatePart(\"yyyy\", date()) & \" / \" & DatePart(\"m\", date())) )) AND ( DATEADD(\"d\",-1, DATEADD(\"m\",0, DateValue(DatePart(\"yyyy\", date()) & \" / \" & DatePart(\"m\", date())) )) )").ToString() + " €";
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Customers().ShowDialog();
        }

        private void viewSubscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Subscriptions().ShowDialog();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddPayment().ShowDialog();
        }

        private void addSubscriptionToCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddSubscription().ShowDialog();
        }


        private void addGroupTrainingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new AddTraining().ShowDialog();
        }

        private void manageTrainersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                new Trainers().ShowDialog();
        }

        private void viewAllGroupTrainingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new GroupTrainings().ShowDialog();
        }
    }
}
