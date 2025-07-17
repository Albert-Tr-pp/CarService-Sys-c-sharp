namespace CarService
{
    partial class frmRegisterClient
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
            this.grpUpdateClient = new System.Windows.Forms.GroupBox();
            this.cboCounties = new System.Windows.Forms.ComboBox();
            this.btnRegisterClient = new System.Windows.Forms.Button();
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.mnuRegisterClient = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdateClient.SuspendLayout();
            this.mnuRegisterClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUpdateClient
            // 
            this.grpUpdateClient.Controls.Add(this.cboCounties);
            this.grpUpdateClient.Controls.Add(this.btnRegisterClient);
            this.grpUpdateClient.Controls.Add(this.lblAirCode);
            this.grpUpdateClient.Controls.Add(this.lblStreet);
            this.grpUpdateClient.Controls.Add(this.lblCity);
            this.grpUpdateClient.Controls.Add(this.lblCounty);
            this.grpUpdateClient.Controls.Add(this.lblEmail);
            this.grpUpdateClient.Controls.Add(this.lblPhone);
            this.grpUpdateClient.Controls.Add(this.lblLastName);
            this.grpUpdateClient.Controls.Add(this.lblFirstName);
            this.grpUpdateClient.Controls.Add(this.txtAirCode);
            this.grpUpdateClient.Controls.Add(this.txtStreet);
            this.grpUpdateClient.Controls.Add(this.txtCity);
            this.grpUpdateClient.Controls.Add(this.txtEmail);
            this.grpUpdateClient.Controls.Add(this.txtPhone);
            this.grpUpdateClient.Controls.Add(this.txtLastName);
            this.grpUpdateClient.Controls.Add(this.txtFirstName);
            this.grpUpdateClient.Location = new System.Drawing.Point(16, 50);
            this.grpUpdateClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdateClient.Name = "grpUpdateClient";
            this.grpUpdateClient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdateClient.Size = new System.Drawing.Size(499, 448);
            this.grpUpdateClient.TabIndex = 0;
            this.grpUpdateClient.TabStop = false;
            this.grpUpdateClient.Text = "Register Client";
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
            this.cboCounties.Location = new System.Drawing.Point(219, 180);
            this.cboCounties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCounties.Name = "cboCounties";
            this.cboCounties.Size = new System.Drawing.Size(248, 24);
            this.cboCounties.TabIndex = 2;
            this.cboCounties.SelectedIndexChanged += new System.EventHandler(this.cboCounties_SelectedIndexChanged);
            // 
            // btnRegisterClient
            // 
            this.btnRegisterClient.Location = new System.Drawing.Point(111, 331);
            this.btnRegisterClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegisterClient.Name = "btnRegisterClient";
            this.btnRegisterClient.Size = new System.Drawing.Size(357, 28);
            this.btnRegisterClient.TabIndex = 16;
            this.btnRegisterClient.Text = "RegisterClient";
            this.btnRegisterClient.UseVisualStyleBackColor = true;
            this.btnRegisterClient.Click += new System.EventHandler(this.btnRegisterClient_Click);
            // 
            // lblAirCode
            // 
            this.lblAirCode.AutoSize = true;
            this.lblAirCode.Location = new System.Drawing.Point(107, 278);
            this.lblAirCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirCode.Name = "lblAirCode";
            this.lblAirCode.Size = new System.Drawing.Size(56, 16);
            this.lblAirCode.TabIndex = 15;
            this.lblAirCode.Text = "AirCode";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(107, 246);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 16);
            this.lblStreet.TabIndex = 14;
            this.lblStreet.Text = "Street";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(107, 214);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "City";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(107, 182);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(48, 16);
            this.lblCounty.TabIndex = 12;
            this.lblCounty.Text = "County";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(107, 150);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            this.lblEmail.UseWaitCursor = true;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(107, 118);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(107, 86);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(107, 54);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name";
            // 
            // txtAirCode
            // 
            this.txtAirCode.Location = new System.Drawing.Point(219, 278);
            this.txtAirCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAirCode.MaxLength = 7;
            this.txtAirCode.Name = "txtAirCode";
            this.txtAirCode.Size = new System.Drawing.Size(248, 22);
            this.txtAirCode.TabIndex = 7;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(219, 246);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(248, 22);
            this.txtStreet.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(219, 214);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.MaxLength = 20;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(248, 22);
            this.txtCity.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(219, 150);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(219, 118);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.MaxLength = 13;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(248, 22);
            this.txtPhone.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(219, 86);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(248, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(219, 54);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(248, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // mnuRegisterClient
            // 
            this.mnuRegisterClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuRegisterClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuRegisterClient.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuRegisterClient.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuRegisterClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuRegisterClient.Location = new System.Drawing.Point(944, 11);
            this.mnuRegisterClient.Name = "mnuRegisterClient";
            this.mnuRegisterClient.Size = new System.Drawing.Size(111, 28);
            this.mnuRegisterClient.TabIndex = 1;
            this.mnuRegisterClient.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // frmRegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpUpdateClient);
            this.Controls.Add(this.mnuRegisterClient);
            this.MainMenuStrip = this.mnuRegisterClient;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegisterClient";
            this.Text = "CarService - Register Client";
            this.Load += new System.EventHandler(this.frmRegisterClient_Load);
            this.grpUpdateClient.ResumeLayout(false);
            this.grpUpdateClient.PerformLayout();
            this.mnuRegisterClient.ResumeLayout(false);
            this.mnuRegisterClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUpdateClient;
        private System.Windows.Forms.Button btnRegisterClient;
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
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.MenuStrip mnuRegisterClient;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboCounties;
    }
}