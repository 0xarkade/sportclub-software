namespace ApfelGym
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.paymentLastMonth = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.paymentsThisMonth = new System.Windows.Forms.Label();
            this.customerVisitsTotalLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trainersTotalLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paymentsTotalLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.customerTotalLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTrainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllGroupTrainingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSubscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubscriptionToCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clientTableAdapter1 = new ApfelGym.SportClubxDataSetTableAdapters.ClientTableAdapter();
            this.queriesTableAdapter1 = new ApfelGym.SportClubxDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(358, 279);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(367, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fitnessclub information";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(596, 113);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "General";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label18.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label18.Location = new System.Drawing.Point(387, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "fitness.admin@fitness.club";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label19.Location = new System.Drawing.Point(270, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 16);
            this.label19.TabIndex = 10;
            this.label19.Text = "Fitness club email:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label17.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label17.Location = new System.Drawing.Point(144, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "Github street 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label16.Location = new System.Drawing.Point(6, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Fitness club address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label15.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label15.Location = new System.Drawing.Point(144, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Fitnes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label14.Location = new System.Drawing.Point(6, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Fitness club network:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.paymentLastMonth);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.paymentsThisMonth);
            this.groupBox3.Controls.Add(this.customerVisitsTotalLabel);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.trainersTotalLabel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.paymentsTotalLabel);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.customerTotalLabel);
            this.groupBox3.Location = new System.Drawing.Point(6, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 141);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label13.Location = new System.Drawing.Point(270, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Payments received last month:";
            // 
            // paymentLastMonth
            // 
            this.paymentLastMonth.AutoSize = true;
            this.paymentLastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.paymentLastMonth.ForeColor = System.Drawing.Color.Green;
            this.paymentLastMonth.Location = new System.Drawing.Point(472, 98);
            this.paymentLastMonth.Name = "paymentLastMonth";
            this.paymentLastMonth.Size = new System.Drawing.Size(15, 16);
            this.paymentLastMonth.TabIndex = 11;
            this.paymentLastMonth.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label12.Location = new System.Drawing.Point(270, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Payments received this month:";
            // 
            // paymentsThisMonth
            // 
            this.paymentsThisMonth.AutoSize = true;
            this.paymentsThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.paymentsThisMonth.ForeColor = System.Drawing.Color.Green;
            this.paymentsThisMonth.Location = new System.Drawing.Point(472, 65);
            this.paymentsThisMonth.Name = "paymentsThisMonth";
            this.paymentsThisMonth.Size = new System.Drawing.Size(15, 16);
            this.paymentsThisMonth.TabIndex = 9;
            this.paymentsThisMonth.Text = "0";
            // 
            // customerVisitsTotalLabel
            // 
            this.customerVisitsTotalLabel.AutoSize = true;
            this.customerVisitsTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.customerVisitsTotalLabel.Location = new System.Drawing.Point(208, 98);
            this.customerVisitsTotalLabel.Name = "customerVisitsTotalLabel";
            this.customerVisitsTotalLabel.Size = new System.Drawing.Size(15, 16);
            this.customerVisitsTotalLabel.TabIndex = 7;
            this.customerVisitsTotalLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label11.Location = new System.Drawing.Point(6, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Total customer visits:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customers total:";
            // 
            // trainersTotalLabel
            // 
            this.trainersTotalLabel.AutoSize = true;
            this.trainersTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.trainersTotalLabel.Location = new System.Drawing.Point(208, 65);
            this.trainersTotalLabel.Name = "trainersTotalLabel";
            this.trainersTotalLabel.Size = new System.Drawing.Size(15, 16);
            this.trainersTotalLabel.TabIndex = 5;
            this.trainersTotalLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.Location = new System.Drawing.Point(270, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Payments total received:";
            // 
            // paymentsTotalLabel
            // 
            this.paymentsTotalLabel.AutoSize = true;
            this.paymentsTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.paymentsTotalLabel.ForeColor = System.Drawing.Color.Green;
            this.paymentsTotalLabel.Location = new System.Drawing.Point(472, 29);
            this.paymentsTotalLabel.Name = "paymentsTotalLabel";
            this.paymentsTotalLabel.Size = new System.Drawing.Size(15, 16);
            this.paymentsTotalLabel.TabIndex = 4;
            this.paymentsTotalLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total trainers:";
            // 
            // customerTotalLabel
            // 
            this.customerTotalLabel.AutoSize = true;
            this.customerTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.customerTotalLabel.Location = new System.Drawing.Point(208, 29);
            this.customerTotalLabel.Name = "customerTotalLabel";
            this.customerTotalLabel.Size = new System.Drawing.Size(15, 16);
            this.customerTotalLabel.TabIndex = 3;
            this.customerTotalLabel.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.trainingsToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.asdToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem});
            this.testToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripMenuItem.Image")));
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.testToolStripMenuItem.Text = "Customers";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addCustomerToolStripMenuItem.Image")));
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addCustomerToolStripMenuItem.Text = "Manage customer(s)";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // trainingsToolStripMenuItem
            // 
            this.trainingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGroupTrainingToolStripMenuItem,
            this.manageTrainersToolStripMenuItem,
            this.viewAllGroupTrainingsToolStripMenuItem});
            this.trainingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trainingsToolStripMenuItem.Image")));
            this.trainingsToolStripMenuItem.Name = "trainingsToolStripMenuItem";
            this.trainingsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.trainingsToolStripMenuItem.Text = "Trainings";
            // 
            // addGroupTrainingToolStripMenuItem
            // 
            this.addGroupTrainingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addGroupTrainingToolStripMenuItem.Image")));
            this.addGroupTrainingToolStripMenuItem.Name = "addGroupTrainingToolStripMenuItem";
            this.addGroupTrainingToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.addGroupTrainingToolStripMenuItem.Text = "Add group training";
            this.addGroupTrainingToolStripMenuItem.Click += new System.EventHandler(this.addGroupTrainingToolStripMenuItem_Click_1);
            // 
            // manageTrainersToolStripMenuItem
            // 
            this.manageTrainersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageTrainersToolStripMenuItem.Image")));
            this.manageTrainersToolStripMenuItem.Name = "manageTrainersToolStripMenuItem";
            this.manageTrainersToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.manageTrainersToolStripMenuItem.Text = "Manage trainers";
            this.manageTrainersToolStripMenuItem.Click += new System.EventHandler(this.manageTrainersToolStripMenuItem_Click_1);
            // 
            // viewAllGroupTrainingsToolStripMenuItem
            // 
            this.viewAllGroupTrainingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewAllGroupTrainingsToolStripMenuItem.Image")));
            this.viewAllGroupTrainingsToolStripMenuItem.Name = "viewAllGroupTrainingsToolStripMenuItem";
            this.viewAllGroupTrainingsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.viewAllGroupTrainingsToolStripMenuItem.Text = "View/Manage group trainings";
            this.viewAllGroupTrainingsToolStripMenuItem.Click += new System.EventHandler(this.viewAllGroupTrainingsToolStripMenuItem_Click_1);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPaymentToolStripMenuItem,
            this.viewPaymentsToolStripMenuItem,
            this.searchPaymentToolStripMenuItem});
            this.paymentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentsToolStripMenuItem.Image")));
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addPaymentToolStripMenuItem.Image")));
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addPaymentToolStripMenuItem.Text = "Add payment";
            this.addPaymentToolStripMenuItem.Click += new System.EventHandler(this.addPaymentToolStripMenuItem_Click);
            // 
            // viewPaymentsToolStripMenuItem
            // 
            this.viewPaymentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewPaymentsToolStripMenuItem.Image")));
            this.viewPaymentsToolStripMenuItem.Name = "viewPaymentsToolStripMenuItem";
            this.viewPaymentsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewPaymentsToolStripMenuItem.Text = "Manage payments";
            this.viewPaymentsToolStripMenuItem.Click += new System.EventHandler(this.viewPaymentsToolStripMenuItem_Click);
            // 
            // searchPaymentToolStripMenuItem
            // 
            this.searchPaymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchPaymentToolStripMenuItem.Image")));
            this.searchPaymentToolStripMenuItem.Name = "searchPaymentToolStripMenuItem";
            this.searchPaymentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.searchPaymentToolStripMenuItem.Text = "Search payment";
            this.searchPaymentToolStripMenuItem.Click += new System.EventHandler(this.searchPaymentToolStripMenuItem_Click);
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSubscriptionsToolStripMenuItem,
            this.addSubscriptionToCustomerToolStripMenuItem});
            this.asdToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("asdToolStripMenuItem.Image")));
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.asdToolStripMenuItem.Text = "Subscriptions";
            // 
            // viewSubscriptionsToolStripMenuItem
            // 
            this.viewSubscriptionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewSubscriptionsToolStripMenuItem.Image")));
            this.viewSubscriptionsToolStripMenuItem.Name = "viewSubscriptionsToolStripMenuItem";
            this.viewSubscriptionsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.viewSubscriptionsToolStripMenuItem.Text = "Manage subscriptions";
            this.viewSubscriptionsToolStripMenuItem.Click += new System.EventHandler(this.viewSubscriptionsToolStripMenuItem_Click);
            // 
            // addSubscriptionToCustomerToolStripMenuItem
            // 
            this.addSubscriptionToCustomerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addSubscriptionToCustomerToolStripMenuItem.Image")));
            this.addSubscriptionToCustomerToolStripMenuItem.Name = "addSubscriptionToCustomerToolStripMenuItem";
            this.addSubscriptionToCustomerToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.addSubscriptionToCustomerToolStripMenuItem.Text = "Add subscription to customer";
            this.addSubscriptionToCustomerToolStripMenuItem.Click += new System.EventHandler(this.addSubscriptionToCustomerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.exitToolStripMenuItem.Text = "Quit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 307);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(978, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.Green;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 17);
            this.statusLabel.Text = "Active";
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 329);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fitnessclub personel software v1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label trainersTotalLabel;
        private System.Windows.Forms.Label paymentsTotalLabel;
        private System.Windows.Forms.Label customerTotalLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSubscriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPaymentToolStripMenuItem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label customerVisitsTotalLabel;
        private System.Windows.Forms.Label label11;
        private SportClubxDataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
        private SportClubxDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label paymentsThisMonth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label paymentLastMonth;
        private System.Windows.Forms.ToolStripMenuItem trainingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubscriptionToCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTrainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllGroupTrainingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGroupTrainingToolStripMenuItem;
    }
}

