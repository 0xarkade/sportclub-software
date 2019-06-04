namespace ApfelGym
{
    partial class Payments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            this.sportClubxDataSet = new ApfelGym.SportClubxDataSet();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new ApfelGym.SportClubxDataSetTableAdapters.PaymentTableAdapter();
            this.paymentsGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.getPaymentsOfClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Payments_of_ClientsTableAdapter = new ApfelGym.SportClubxDataSetTableAdapters.Get_Payments_of_ClientsTableAdapter();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyFieldContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wholeRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sportClubxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPaymentsOfClientsBindingSource)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sportClubxDataSet
            // 
            this.sportClubxDataSet.DataSetName = "SportClubxDataSet";
            this.sportClubxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.sportClubxDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // paymentsGrid
            // 
            this.paymentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.paymentsGrid.Location = new System.Drawing.Point(12, 12);
            this.paymentsGrid.Name = "paymentsGrid";
            this.paymentsGrid.Size = new System.Drawing.Size(718, 281);
            this.paymentsGrid.TabIndex = 0;
            this.paymentsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentsGrid_CellValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveChangesToolStripMenuItem,
            this.deleteEntryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 48);
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveChangesToolStripMenuItem.Image")));
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveChangesToolStripMenuItem.Text = "Save changes";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // deleteEntryToolStripMenuItem
            // 
            this.deleteEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteEntryToolStripMenuItem.Image")));
            this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteEntryToolStripMenuItem.Text = "Delete entry";
            this.deleteEntryToolStripMenuItem.Click += new System.EventHandler(this.deleteEntryToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(441, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.searchBox.Location = new System.Drawing.Point(72, 322);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(363, 22);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(615, 326);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Enable autosearch";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // getPaymentsOfClientsBindingSource
            // 
            this.getPaymentsOfClientsBindingSource.DataMember = "Get Payments of Clients";
            this.getPaymentsOfClientsBindingSource.DataSource = this.sportClubxDataSet;
            // 
            // get_Payments_of_ClientsTableAdapter
            // 
            this.get_Payments_of_ClientsTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyFieldContentToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(103, 26);
            // 
            // copyFieldContentToolStripMenuItem
            // 
            this.copyFieldContentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedFieldToolStripMenuItem,
            this.wholeRowToolStripMenuItem});
            this.copyFieldContentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyFieldContentToolStripMenuItem.Image")));
            this.copyFieldContentToolStripMenuItem.Name = "copyFieldContentToolStripMenuItem";
            this.copyFieldContentToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyFieldContentToolStripMenuItem.Text = "Copy";
            // 
            // selectedFieldToolStripMenuItem
            // 
            this.selectedFieldToolStripMenuItem.Name = "selectedFieldToolStripMenuItem";
            this.selectedFieldToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectedFieldToolStripMenuItem.Text = "Selected field";
            // 
            // wholeRowToolStripMenuItem
            // 
            this.wholeRowToolStripMenuItem.Name = "wholeRowToolStripMenuItem";
            this.wholeRowToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.wholeRowToolStripMenuItem.Text = "Whole row";
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 356);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paymentsGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportClubxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getPaymentsOfClientsBindingSource)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SportClubxDataSet sportClubxDataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private SportClubxDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridView paymentsGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource getPaymentsOfClientsBindingSource;
        private SportClubxDataSetTableAdapters.Get_Payments_of_ClientsTableAdapter get_Payments_of_ClientsTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem copyFieldContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wholeRowToolStripMenuItem;
    }
}