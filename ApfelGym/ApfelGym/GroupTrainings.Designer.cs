namespace ApfelGym
{
    partial class GroupTrainings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupTrainings));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allGroupTrainingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignedGroupTrainingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignGroupTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.deleteGroupTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(776, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignGroupTrainingToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.deleteGroupTrainingToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 70);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allGroupTrainingsToolStripMenuItem,
            this.assignedGroupTrainingsToolStripMenuItem});
            this.filterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filterToolStripMenuItem.Image")));
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // allGroupTrainingsToolStripMenuItem
            // 
            this.allGroupTrainingsToolStripMenuItem.Name = "allGroupTrainingsToolStripMenuItem";
            this.allGroupTrainingsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.allGroupTrainingsToolStripMenuItem.Text = "All group trainings";
            this.allGroupTrainingsToolStripMenuItem.Click += new System.EventHandler(this.allGroupTrainingsToolStripMenuItem_Click);
            // 
            // assignedGroupTrainingsToolStripMenuItem
            // 
            this.assignedGroupTrainingsToolStripMenuItem.Name = "assignedGroupTrainingsToolStripMenuItem";
            this.assignedGroupTrainingsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.assignedGroupTrainingsToolStripMenuItem.Text = "Assigned group trainings";
            this.assignedGroupTrainingsToolStripMenuItem.Click += new System.EventHandler(this.assignedGroupTrainingsToolStripMenuItem_Click);
            // 
            // assignGroupTrainingToolStripMenuItem
            // 
            this.assignGroupTrainingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("assignGroupTrainingToolStripMenuItem.Image")));
            this.assignGroupTrainingToolStripMenuItem.Name = "assignGroupTrainingToolStripMenuItem";
            this.assignGroupTrainingToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.assignGroupTrainingToolStripMenuItem.Text = "Assign group training(s)";
            this.assignGroupTrainingToolStripMenuItem.Click += new System.EventHandler(this.assignGroupTrainingToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assign To: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training assignment";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(87, 34);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(130, 20);
            this.searchBox.TabIndex = 4;
            this.searchBox.Text = "PersonalCode here";
            // 
            // deleteGroupTrainingToolStripMenuItem
            // 
            this.deleteGroupTrainingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteGroupTrainingToolStripMenuItem.Image")));
            this.deleteGroupTrainingToolStripMenuItem.Name = "deleteGroupTrainingToolStripMenuItem";
            this.deleteGroupTrainingToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deleteGroupTrainingToolStripMenuItem.Text = "Delete group training";
            this.deleteGroupTrainingToolStripMenuItem.Click += new System.EventHandler(this.deleteGroupTrainingToolStripMenuItem_Click);
            // 
            // GroupTrainings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupTrainings";
            this.Text = "GroupTrainings";
            this.Load += new System.EventHandler(this.GroupTrainings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allGroupTrainingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignedGroupTrainingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignGroupTrainingToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupTrainingToolStripMenuItem;
    }
}