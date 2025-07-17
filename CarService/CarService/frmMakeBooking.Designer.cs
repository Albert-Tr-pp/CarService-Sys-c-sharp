namespace CarService
{
    partial class frmMakeBooking
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
            this.grpSearchClient = new System.Windows.Forms.GroupBox();
            this.lbl_info_about_all = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.mnuMakeBooking = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpClientsList = new System.Windows.Forms.GroupBox();
            this.lsbClientsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.lsbTime = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.grpSearchClient.SuspendLayout();
            this.mnuMakeBooking.SuspendLayout();
            this.grpClientsList.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearchClient
            // 
            this.grpSearchClient.Controls.Add(this.lbl_info_about_all);
            this.grpSearchClient.Controls.Add(this.btnFind);
            this.grpSearchClient.Controls.Add(this.lblStreet);
            this.grpSearchClient.Controls.Add(this.lblLastName);
            this.grpSearchClient.Controls.Add(this.txtLastName);
            this.grpSearchClient.Location = new System.Drawing.Point(16, 74);
            this.grpSearchClient.Margin = new System.Windows.Forms.Padding(4);
            this.grpSearchClient.Name = "grpSearchClient";
            this.grpSearchClient.Padding = new System.Windows.Forms.Padding(4);
            this.grpSearchClient.Size = new System.Drawing.Size(868, 81);
            this.grpSearchClient.TabIndex = 5;
            this.grpSearchClient.TabStop = false;
            this.grpSearchClient.Text = "Search Client";
            this.grpSearchClient.Enter += new System.EventHandler(this.grpSearchClient_Enter);
            // 
            // lbl_info_about_all
            // 
            this.lbl_info_about_all.AutoSize = true;
            this.lbl_info_about_all.ForeColor = System.Drawing.Color.Brown;
            this.lbl_info_about_all.Location = new System.Drawing.Point(204, 19);
            this.lbl_info_about_all.Name = "lbl_info_about_all";
            this.lbl_info_about_all.Size = new System.Drawing.Size(178, 16);
            this.lbl_info_about_all.TabIndex = 28;
            this.lbl_info_about_all.Text = "Type \"all\" to get All records!!!";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(421, 37);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(101, 28);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(107, 246);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(0, 16);
            this.lblStreet.TabIndex = 14;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(52, 39);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 16);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Surname";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(164, 39);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(248, 22);
            this.txtLastName.TabIndex = 0;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // mnuMakeBooking
            // 
            this.mnuMakeBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuMakeBooking.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuMakeBooking.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMakeBooking.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMakeBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuMakeBooking.Location = new System.Drawing.Point(946, 11);
            this.mnuMakeBooking.Name = "mnuMakeBooking";
            this.mnuMakeBooking.Size = new System.Drawing.Size(109, 28);
            this.mnuMakeBooking.TabIndex = 6;
            this.mnuMakeBooking.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpClientsList
            // 
            this.grpClientsList.Controls.Add(this.lsbClientsList);
            this.grpClientsList.Controls.Add(this.label1);
            this.grpClientsList.Location = new System.Drawing.Point(16, 162);
            this.grpClientsList.Margin = new System.Windows.Forms.Padding(4);
            this.grpClientsList.Name = "grpClientsList";
            this.grpClientsList.Padding = new System.Windows.Forms.Padding(4);
            this.grpClientsList.Size = new System.Drawing.Size(672, 145);
            this.grpClientsList.TabIndex = 22;
            this.grpClientsList.TabStop = false;
            this.grpClientsList.Text = "Select Client from List";
            this.grpClientsList.Visible = false;
            // 
            // lsbClientsList
            // 
            this.lsbClientsList.FormattingEnabled = true;
            this.lsbClientsList.ItemHeight = 16;
            this.lsbClientsList.Items.AddRange(new object[] {
            "•Surname: Biden; •Forename: Joe; •Email: joebiden@gmail.com; •Phone: +00000000000" +
                "00"});
            this.lsbClientsList.Location = new System.Drawing.Point(21, 27);
            this.lsbClientsList.Margin = new System.Windows.Forms.Padding(4);
            this.lsbClientsList.Name = "lsbClientsList";
            this.lsbClientsList.Size = new System.Drawing.Size(624, 100);
            this.lsbClientsList.TabIndex = 15;
            this.lsbClientsList.SelectedIndexChanged += new System.EventHandler(this.lsbRemovePart_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 14;
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.lsbTime);
            this.grpTime.Controls.Add(this.label2);
            this.grpTime.Location = new System.Drawing.Point(327, 327);
            this.grpTime.Margin = new System.Windows.Forms.Padding(4);
            this.grpTime.Name = "grpTime";
            this.grpTime.Padding = new System.Windows.Forms.Padding(4);
            this.grpTime.Size = new System.Drawing.Size(277, 164);
            this.grpTime.TabIndex = 23;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Select Time from Avaliable";
            this.grpTime.Visible = false;
            // 
            // lsbTime
            // 
            this.lsbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTime.FormattingEnabled = true;
            this.lsbTime.ItemHeight = 25;
            this.lsbTime.Location = new System.Drawing.Point(21, 27);
            this.lsbTime.Margin = new System.Windows.Forms.Padding(4);
            this.lsbTime.Name = "lsbTime";
            this.lsbTime.Size = new System.Drawing.Size(232, 129);
            this.lsbTime.TabIndex = 15;
            this.lsbTime.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 14;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.dtpDate);
            this.grpDate.Controls.Add(this.label3);
            this.grpDate.Location = new System.Drawing.Point(16, 327);
            this.grpDate.Margin = new System.Windows.Forms.Padding(4);
            this.grpDate.Name = "grpDate";
            this.grpDate.Padding = new System.Windows.Forms.Padding(4);
            this.grpDate.Size = new System.Drawing.Size(277, 60);
            this.grpDate.TabIndex = 17;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Pick Date";
            this.grpDate.Visible = false;
            this.grpDate.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(4, 20);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.MinDate = new System.DateTime(2025, 3, 10, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 15;
            this.dtpDate.Value = new System.DateTime(2025, 3, 18, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 14;
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.Location = new System.Drawing.Point(632, 409);
            this.btnMakeBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(144, 82);
            this.btnMakeBooking.TabIndex = 24;
            this.btnMakeBooking.Text = "Book";
            this.btnMakeBooking.UseVisualStyleBackColor = true;
            this.btnMakeBooking.Visible = false;
            this.btnMakeBooking.Click += new System.EventHandler(this.btnMakeBooking_Click);
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnMakeBooking);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.grpClientsList);
            this.Controls.Add(this.mnuMakeBooking);
            this.Controls.Add(this.grpSearchClient);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMakeBooking";
            this.Text = "Car Service - Make Booking";
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
            this.grpSearchClient.ResumeLayout(false);
            this.grpSearchClient.PerformLayout();
            this.mnuMakeBooking.ResumeLayout(false);
            this.mnuMakeBooking.PerformLayout();
            this.grpClientsList.ResumeLayout(false);
            this.grpClientsList.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchClient;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.MenuStrip mnuMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpClientsList;
        private System.Windows.Forms.ListBox lsbClientsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.ListBox lsbTime;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Label lbl_info_about_all;
    }
}