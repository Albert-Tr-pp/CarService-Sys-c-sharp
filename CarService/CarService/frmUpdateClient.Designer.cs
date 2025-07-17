namespace CarService
{
    partial class frmUpdateClient
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
            this.mnuUpdateClient = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.cboCounties = new System.Windows.Forms.ComboBox();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.lblAirCode = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtAirCode = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmailToUpdate = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.grpClientsList = new System.Windows.Forms.GroupBox();
            this.lsbClientsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSearchClient = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLastNameToSearch = new System.Windows.Forms.Label();
            this.txtLastNameToSearch = new System.Windows.Forms.TextBox();
            this.lbl_info_about_all = new System.Windows.Forms.Label();
            this.mnuUpdateClient.SuspendLayout();
            this.grpClient.SuspendLayout();
            this.grpClientsList.SuspendLayout();
            this.grpSearchClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateClient
            // 
            this.mnuUpdateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuUpdateClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuUpdateClient.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuUpdateClient.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuUpdateClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuUpdateClient.Location = new System.Drawing.Point(944, 11);
            this.mnuUpdateClient.Name = "mnuUpdateClient";
            this.mnuUpdateClient.Size = new System.Drawing.Size(111, 28);
            this.mnuUpdateClient.TabIndex = 2;
            this.mnuUpdateClient.Text = "menuStrip1";
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
            // grpClient
            // 
            this.grpClient.Controls.Add(this.cboCounties);
            this.grpClient.Controls.Add(this.btnUpdateClient);
            this.grpClient.Controls.Add(this.lblAirCode);
            this.grpClient.Controls.Add(this.lblStreet);
            this.grpClient.Controls.Add(this.lblCity);
            this.grpClient.Controls.Add(this.lblCounty);
            this.grpClient.Controls.Add(this.lblEmail);
            this.grpClient.Controls.Add(this.lblPhone);
            this.grpClient.Controls.Add(this.lblLastName);
            this.grpClient.Controls.Add(this.lblFirstName);
            this.grpClient.Controls.Add(this.txtAirCode);
            this.grpClient.Controls.Add(this.txtStreet);
            this.grpClient.Controls.Add(this.txtCity);
            this.grpClient.Controls.Add(this.txtEmailToUpdate);
            this.grpClient.Controls.Add(this.txtPhone);
            this.grpClient.Controls.Add(this.txtLastName);
            this.grpClient.Controls.Add(this.txtFirstName);
            this.grpClient.Location = new System.Drawing.Point(16, 257);
            this.grpClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClient.Name = "grpClient";
            this.grpClient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClient.Size = new System.Drawing.Size(512, 352);
            this.grpClient.TabIndex = 3;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Update Details";
            this.grpClient.Visible = false;
            this.grpClient.Enter += new System.EventHandler(this.grpClient_Enter);
            // 
            // cboCounties
            // 
            this.cboCounties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounties.FormattingEnabled = true;
            this.cboCounties.Items.AddRange(new object[] {
            "Carlow  ",
            "Cavan  ",
            "Clare  ",
            "Cork  ",
            "Donegal  ",
            "Dublin  ",
            "Galway  ",
            "Kerry  ",
            "Kildare  ",
            "Kilkenny  ",
            "Laois  ",
            "Leitrim  ",
            "Limerick  ",
            "Longford  ",
            "Louth  ",
            "Mayo  ",
            "Meath  ",
            "Monaghan  ",
            "Offaly  ",
            "Roscommon  ",
            "Sligo  ",
            "Tipperary  ",
            "Waterford  ",
            "Westmeath  ",
            "Wexford  ",
            "Wicklow  ",
            "Antrim  ",
            "Armagh  ",
            "Down  ",
            "Fermanagh  ",
            "Londonderry  ",
            "Tyrone"});
            this.cboCounties.Location = new System.Drawing.Point(189, 156);
            this.cboCounties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCounties.Name = "cboCounties";
            this.cboCounties.Size = new System.Drawing.Size(248, 24);
            this.cboCounties.TabIndex = 4;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(81, 305);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(357, 28);
            this.btnUpdateClient.TabIndex = 33;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // lblAirCode
            // 
            this.lblAirCode.AutoSize = true;
            this.lblAirCode.Location = new System.Drawing.Point(77, 252);
            this.lblAirCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirCode.Name = "lblAirCode";
            this.lblAirCode.Size = new System.Drawing.Size(56, 16);
            this.lblAirCode.TabIndex = 32;
            this.lblAirCode.Text = "AirCode";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(77, 220);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 16);
            this.lblStreet.TabIndex = 31;
            this.lblStreet.Text = "Street";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(77, 188);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 30;
            this.lblCity.Text = "City";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(77, 156);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(48, 16);
            this.lblCounty.TabIndex = 29;
            this.lblCounty.Text = "County";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(77, 124);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            this.lblEmail.UseWaitCursor = true;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(77, 92);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 27;
            this.lblPhone.Text = "Phone";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(77, 60);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 26;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(77, 28);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 25;
            this.lblFirstName.Text = "First Name";
            // 
            // txtAirCode
            // 
            this.txtAirCode.Location = new System.Drawing.Point(189, 252);
            this.txtAirCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAirCode.MaxLength = 7;
            this.txtAirCode.Name = "txtAirCode";
            this.txtAirCode.Size = new System.Drawing.Size(248, 22);
            this.txtAirCode.TabIndex = 24;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(189, 220);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(248, 22);
            this.txtStreet.TabIndex = 23;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(189, 188);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(248, 22);
            this.txtCity.TabIndex = 22;
            // 
            // txtEmailToUpdate
            // 
            this.txtEmailToUpdate.Location = new System.Drawing.Point(189, 124);
            this.txtEmailToUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailToUpdate.MaxLength = 40;
            this.txtEmailToUpdate.Name = "txtEmailToUpdate";
            this.txtEmailToUpdate.Size = new System.Drawing.Size(248, 22);
            this.txtEmailToUpdate.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(189, 92);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.MaxLength = 13;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(248, 22);
            this.txtPhone.TabIndex = 19;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(189, 60);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(248, 22);
            this.txtLastName.TabIndex = 18;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(189, 28);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(248, 22);
            this.txtFirstName.TabIndex = 17;
            // 
            // grpClientsList
            // 
            this.grpClientsList.Controls.Add(this.lsbClientsList);
            this.grpClientsList.Controls.Add(this.label1);
            this.grpClientsList.Location = new System.Drawing.Point(16, 103);
            this.grpClientsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClientsList.Name = "grpClientsList";
            this.grpClientsList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpClientsList.Size = new System.Drawing.Size(672, 145);
            this.grpClientsList.TabIndex = 26;
            this.grpClientsList.TabStop = false;
            this.grpClientsList.Text = "Select Client from List";
            this.grpClientsList.Visible = false;
            this.grpClientsList.Enter += new System.EventHandler(this.grpClientsList_Enter);
            // 
            // lsbClientsList
            // 
            this.lsbClientsList.FormattingEnabled = true;
            this.lsbClientsList.ItemHeight = 16;
            this.lsbClientsList.Location = new System.Drawing.Point(21, 27);
            this.lsbClientsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbClientsList.Name = "lsbClientsList";
            this.lsbClientsList.Size = new System.Drawing.Size(624, 100);
            this.lsbClientsList.TabIndex = 15;
            this.lsbClientsList.SelectedIndexChanged += new System.EventHandler(this.lsbClientsList_SelectedIndexChanged_1);
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
            this.grpSearchClient.Controls.Add(this.label2);
            this.grpSearchClient.Controls.Add(this.lblLastNameToSearch);
            this.grpSearchClient.Controls.Add(this.txtLastNameToSearch);
            this.grpSearchClient.Location = new System.Drawing.Point(16, 15);
            this.grpSearchClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchClient.Name = "grpSearchClient";
            this.grpSearchClient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchClient.Size = new System.Drawing.Size(868, 81);
            this.grpSearchClient.TabIndex = 25;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 14;
            // 
            // lblLastNameToSearch
            // 
            this.lblLastNameToSearch.AutoSize = true;
            this.lblLastNameToSearch.Location = new System.Drawing.Point(52, 39);
            this.lblLastNameToSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastNameToSearch.Name = "lblLastNameToSearch";
            this.lblLastNameToSearch.Size = new System.Drawing.Size(61, 16);
            this.lblLastNameToSearch.TabIndex = 10;
            this.lblLastNameToSearch.Text = "Surname";
            // 
            // txtLastNameToSearch
            // 
            this.txtLastNameToSearch.Location = new System.Drawing.Point(164, 39);
            this.txtLastNameToSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastNameToSearch.MaxLength = 20;
            this.txtLastNameToSearch.Name = "txtLastNameToSearch";
            this.txtLastNameToSearch.Size = new System.Drawing.Size(248, 22);
            this.txtLastNameToSearch.TabIndex = 0;
            // 
            // lbl_info_about_all
            // 
            this.lbl_info_about_all.AutoSize = true;
            this.lbl_info_about_all.ForeColor = System.Drawing.Color.Brown;
            this.lbl_info_about_all.Location = new System.Drawing.Point(208, 19);
            this.lbl_info_about_all.Name = "lbl_info_about_all";
            this.lbl_info_about_all.Size = new System.Drawing.Size(178, 16);
            this.lbl_info_about_all.TabIndex = 27;
            this.lbl_info_about_all.Text = "Type \"all\" to get All records!!!";
            this.lbl_info_about_all.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 609);
            this.Controls.Add(this.grpClientsList);
            this.Controls.Add(this.grpSearchClient);
            this.Controls.Add(this.grpClient);
            this.Controls.Add(this.mnuUpdateClient);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUpdateClient";
            this.Text = "CarService - UpdateClient";
            this.Load += new System.EventHandler(this.frmUpdateClient_Load);
            this.mnuUpdateClient.ResumeLayout(false);
            this.mnuUpdateClient.PerformLayout();
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.grpClientsList.ResumeLayout(false);
            this.grpClientsList.PerformLayout();
            this.grpSearchClient.ResumeLayout(false);
            this.grpSearchClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuUpdateClient;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Label lblAirCode;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtAirCode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmailToUpdate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cboCounties;
        private System.Windows.Forms.GroupBox grpClientsList;
        private System.Windows.Forms.ListBox lsbClientsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSearchClient;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLastNameToSearch;
        private System.Windows.Forms.TextBox txtLastNameToSearch;
        private System.Windows.Forms.Label lbl_info_about_all;
    }
}