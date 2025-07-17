namespace CarService
{
    partial class frmRemoveBooking
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
            this.mnuRemoveBooking = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpClientsList = new System.Windows.Forms.GroupBox();
            this.lsbClientsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSearchClient = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grpAppointmentList = new System.Windows.Forms.GroupBox();
            this.lsbAppointmentsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveBooking = new System.Windows.Forms.Button();
            this.lbl_info_about_all = new System.Windows.Forms.Label();
            this.mnuRemoveBooking.SuspendLayout();
            this.grpClientsList.SuspendLayout();
            this.grpSearchClient.SuspendLayout();
            this.grpAppointmentList.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRemoveBooking
            // 
            this.mnuRemoveBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuRemoveBooking.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuRemoveBooking.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuRemoveBooking.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuRemoveBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuRemoveBooking.Location = new System.Drawing.Point(944, 11);
            this.mnuRemoveBooking.Name = "mnuRemoveBooking";
            this.mnuRemoveBooking.Size = new System.Drawing.Size(111, 28);
            this.mnuRemoveBooking.TabIndex = 7;
            this.mnuRemoveBooking.Text = "menuStrip1";
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
            this.grpClientsList.Location = new System.Drawing.Point(16, 182);
            this.grpClientsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClientsList.Name = "grpClientsList";
            this.grpClientsList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClientsList.Size = new System.Drawing.Size(672, 145);
            this.grpClientsList.TabIndex = 24;
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
            this.lsbClientsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbClientsList.Name = "lsbClientsList";
            this.lsbClientsList.Size = new System.Drawing.Size(624, 100);
            this.lsbClientsList.TabIndex = 15;
            this.lsbClientsList.SelectedIndexChanged += new System.EventHandler(this.lsbClientsList_SelectedIndexChanged);
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
            // grpSearchClient
            // 
            this.grpSearchClient.Controls.Add(this.lbl_info_about_all);
            this.grpSearchClient.Controls.Add(this.btnFind);
            this.grpSearchClient.Controls.Add(this.lblStreet);
            this.grpSearchClient.Controls.Add(this.lblLastName);
            this.grpSearchClient.Controls.Add(this.txtLastName);
            this.grpSearchClient.Location = new System.Drawing.Point(16, 94);
            this.grpSearchClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchClient.Name = "grpSearchClient";
            this.grpSearchClient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchClient.Size = new System.Drawing.Size(868, 81);
            this.grpSearchClient.TabIndex = 23;
            this.grpSearchClient.TabStop = false;
            this.grpSearchClient.Text = "Search Client";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(421, 37);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(248, 22);
            this.txtLastName.TabIndex = 0;
            // 
            // grpAppointmentList
            // 
            this.grpAppointmentList.Controls.Add(this.lsbAppointmentsList);
            this.grpAppointmentList.Controls.Add(this.label2);
            this.grpAppointmentList.Location = new System.Drawing.Point(16, 335);
            this.grpAppointmentList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAppointmentList.Name = "grpAppointmentList";
            this.grpAppointmentList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAppointmentList.Size = new System.Drawing.Size(672, 145);
            this.grpAppointmentList.TabIndex = 25;
            this.grpAppointmentList.TabStop = false;
            this.grpAppointmentList.Text = "Select Appointment from List";
            this.grpAppointmentList.Visible = false;
            // 
            // lsbAppointmentsList
            // 
            this.lsbAppointmentsList.FormattingEnabled = true;
            this.lsbAppointmentsList.ItemHeight = 16;
            this.lsbAppointmentsList.Items.AddRange(new object[] {
            "•AppintmentID: 002; •Date: 03/12/2024; •Time: 14:00;",
            "•AppintmentID: 005; •Date: 06/12/2024; •Time: 12:00;"});
            this.lsbAppointmentsList.Location = new System.Drawing.Point(21, 27);
            this.lsbAppointmentsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbAppointmentsList.Name = "lsbAppointmentsList";
            this.lsbAppointmentsList.Size = new System.Drawing.Size(624, 100);
            this.lsbAppointmentsList.TabIndex = 15;
            this.lsbAppointmentsList.SelectedIndexChanged += new System.EventHandler(this.lsbAppointmentsList_SelectedIndexChanged);
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
            // btnRemoveBooking
            // 
            this.btnRemoveBooking.Location = new System.Drawing.Point(719, 398);
            this.btnRemoveBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveBooking.Name = "btnRemoveBooking";
            this.btnRemoveBooking.Size = new System.Drawing.Size(144, 82);
            this.btnRemoveBooking.TabIndex = 26;
            this.btnRemoveBooking.Text = "Remove Booking";
            this.btnRemoveBooking.UseVisualStyleBackColor = true;
            this.btnRemoveBooking.Visible = false;
            this.btnRemoveBooking.Click += new System.EventHandler(this.btnRemoveBooking_Click);
            // 
            // lbl_info_about_all
            // 
            this.lbl_info_about_all.AutoSize = true;
            this.lbl_info_about_all.ForeColor = System.Drawing.Color.Brown;
            this.lbl_info_about_all.Location = new System.Drawing.Point(200, 19);
            this.lbl_info_about_all.Name = "lbl_info_about_all";
            this.lbl_info_about_all.Size = new System.Drawing.Size(178, 16);
            this.lbl_info_about_all.TabIndex = 28;
            this.lbl_info_about_all.Text = "Type \"all\" to get All records!!!";
            // 
            // frmRemoveBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRemoveBooking);
            this.Controls.Add(this.grpAppointmentList);
            this.Controls.Add(this.grpClientsList);
            this.Controls.Add(this.grpSearchClient);
            this.Controls.Add(this.mnuRemoveBooking);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRemoveBooking";
            this.Text = "Car Service - Remove Booking";
            this.Load += new System.EventHandler(this.frmRemoveBooking_Load);
            this.mnuRemoveBooking.ResumeLayout(false);
            this.mnuRemoveBooking.PerformLayout();
            this.grpClientsList.ResumeLayout(false);
            this.grpClientsList.PerformLayout();
            this.grpSearchClient.ResumeLayout(false);
            this.grpSearchClient.PerformLayout();
            this.grpAppointmentList.ResumeLayout(false);
            this.grpAppointmentList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRemoveBooking;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpClientsList;
        private System.Windows.Forms.ListBox lsbClientsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSearchClient;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox grpAppointmentList;
        private System.Windows.Forms.ListBox lsbAppointmentsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveBooking;
        private System.Windows.Forms.Label lbl_info_about_all;
    }
}