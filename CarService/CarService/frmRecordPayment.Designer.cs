namespace CarService
{
    partial class frmRecordPayment
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
            this.btnPaid = new System.Windows.Forms.Button();
            this.grpAppointmentList = new System.Windows.Forms.GroupBox();
            this.lsbAppointmentsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpClientsList = new System.Windows.Forms.GroupBox();
            this.lsbClientsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuRecordPayment = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearchClient = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbl_info_about_all = new System.Windows.Forms.Label();
            this.grpAppointmentList.SuspendLayout();
            this.grpClientsList.SuspendLayout();
            this.mnuRecordPayment.SuspendLayout();
            this.grpSearchClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPaid
            // 
            this.btnPaid.Location = new System.Drawing.Point(719, 398);
            this.btnPaid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(144, 82);
            this.btnPaid.TabIndex = 31;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Visible = false;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
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
            this.grpAppointmentList.TabIndex = 30;
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
            // grpClientsList
            // 
            this.grpClientsList.Controls.Add(this.lsbClientsList);
            this.grpClientsList.Controls.Add(this.label1);
            this.grpClientsList.Location = new System.Drawing.Point(16, 182);
            this.grpClientsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClientsList.Name = "grpClientsList";
            this.grpClientsList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClientsList.Size = new System.Drawing.Size(672, 145);
            this.grpClientsList.TabIndex = 29;
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
            // mnuRecordPayment
            // 
            this.mnuRecordPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuRecordPayment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuRecordPayment.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuRecordPayment.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuRecordPayment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuRecordPayment.Location = new System.Drawing.Point(944, 11);
            this.mnuRecordPayment.Name = "mnuRecordPayment";
            this.mnuRecordPayment.Size = new System.Drawing.Size(111, 28);
            this.mnuRecordPayment.TabIndex = 27;
            this.mnuRecordPayment.Text = "menuStrip1";
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
            this.grpSearchClient.Size = new System.Drawing.Size(672, 81);
            this.grpSearchClient.TabIndex = 32;
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
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
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
            // lbl_info_about_all
            // 
            this.lbl_info_about_all.AutoSize = true;
            this.lbl_info_about_all.ForeColor = System.Drawing.Color.Brown;
            this.lbl_info_about_all.Location = new System.Drawing.Point(204, 19);
            this.lbl_info_about_all.Name = "lbl_info_about_all";
            this.lbl_info_about_all.Size = new System.Drawing.Size(178, 16);
            this.lbl_info_about_all.TabIndex = 33;
            this.lbl_info_about_all.Text = "Type \"all\" to get All records!!!";
            // 
            // frmRecordPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpSearchClient);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.grpAppointmentList);
            this.Controls.Add(this.grpClientsList);
            this.Controls.Add(this.mnuRecordPayment);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRecordPayment";
            this.Text = "Car Service - Record Payment";
            this.Load += new System.EventHandler(this.frmRecordPayment_Load);
            this.grpAppointmentList.ResumeLayout(false);
            this.grpAppointmentList.PerformLayout();
            this.grpClientsList.ResumeLayout(false);
            this.grpClientsList.PerformLayout();
            this.mnuRecordPayment.ResumeLayout(false);
            this.mnuRecordPayment.PerformLayout();
            this.grpSearchClient.ResumeLayout(false);
            this.grpSearchClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.GroupBox grpAppointmentList;
        private System.Windows.Forms.ListBox lsbAppointmentsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpClientsList;
        private System.Windows.Forms.ListBox lsbClientsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuRecordPayment;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSearchClient;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbl_info_about_all;
    }
}