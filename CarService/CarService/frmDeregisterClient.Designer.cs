namespace CarService
{
    partial class frmDeregisterClient
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDeregisterClient = new System.Windows.Forms.Button();
            this.mnuDeregisterClient = new System.Windows.Forms.MenuStrip();
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
            this.lbl_info_about_all = new System.Windows.Forms.Label();
            this.mnuDeregisterClient.SuspendLayout();
            this.grpClientsList.SuspendLayout();
            this.grpSearchClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeregisterClient
            // 
            this.btnDeregisterClient.Location = new System.Drawing.Point(37, 345);
            this.btnDeregisterClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeregisterClient.Name = "btnDeregisterClient";
            this.btnDeregisterClient.Size = new System.Drawing.Size(357, 28);
            this.btnDeregisterClient.TabIndex = 2;
            this.btnDeregisterClient.Text = "Deregister Client";
            this.btnDeregisterClient.UseVisualStyleBackColor = true;
            this.btnDeregisterClient.Visible = false;
            this.btnDeregisterClient.Click += new System.EventHandler(this.btnDeregisterClient_Click);
            // 
            // mnuDeregisterClient
            // 
            this.mnuDeregisterClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuDeregisterClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuDeregisterClient.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuDeregisterClient.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuDeregisterClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuDeregisterClient.Location = new System.Drawing.Point(944, 11);
            this.mnuDeregisterClient.Name = "mnuDeregisterClient";
            this.mnuDeregisterClient.Size = new System.Drawing.Size(111, 28);
            this.mnuDeregisterClient.TabIndex = 3;
            this.mnuDeregisterClient.Text = "menuStrip1";
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
            this.grpClientsList.Location = new System.Drawing.Point(16, 167);
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
            this.grpSearchClient.Location = new System.Drawing.Point(16, 79);
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
            // frmDeregisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDeregisterClient);
            this.Controls.Add(this.grpClientsList);
            this.Controls.Add(this.grpSearchClient);
            this.Controls.Add(this.mnuDeregisterClient);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDeregisterClient";
            this.Text = "CarService - DeregisterClient";
            this.Load += new System.EventHandler(this.frmDeregisterClient_Load);
            this.mnuDeregisterClient.ResumeLayout(false);
            this.mnuDeregisterClient.PerformLayout();
            this.grpClientsList.ResumeLayout(false);
            this.grpClientsList.PerformLayout();
            this.grpSearchClient.ResumeLayout(false);
            this.grpSearchClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDeregisterClient;
        private System.Windows.Forms.MenuStrip mnuDeregisterClient;
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
        private System.Windows.Forms.Label lbl_info_about_all;
    }
}