namespace CarService
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deregisterClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookimgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frequentPartsRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgMainMenu = new System.Windows.Forms.PictureBox();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.partsToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.monitoringToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "mnuMainMenu";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerClientToolStripMenuItem,
            this.updateClientToolStripMenuItem,
            this.deregisterClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // registerClientToolStripMenuItem
            // 
            this.registerClientToolStripMenuItem.Name = "registerClientToolStripMenuItem";
            this.registerClientToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.registerClientToolStripMenuItem.Text = "Register Client";
            this.registerClientToolStripMenuItem.Click += new System.EventHandler(this.registerClientsToolStripMenuItem_Click);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.updateClientToolStripMenuItem.Text = "Update Client";
            this.updateClientToolStripMenuItem.Click += new System.EventHandler(this.updateClientToolStripMenuItem_Click);
            // 
            // deregisterClientToolStripMenuItem
            // 
            this.deregisterClientToolStripMenuItem.Name = "deregisterClientToolStripMenuItem";
            this.deregisterClientToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deregisterClientToolStripMenuItem.Text = "Deregister Client";
            this.deregisterClientToolStripMenuItem.Click += new System.EventHandler(this.deregisterClientToolStripMenuItem_Click);
            // 
            // partsToolStripMenuItem
            // 
            this.partsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPartToolStripMenuItem,
            this.removePartToolStripMenuItem,
            this.updatePartToolStripMenuItem});
            this.partsToolStripMenuItem.Name = "partsToolStripMenuItem";
            this.partsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.partsToolStripMenuItem.Text = "Parts";
            // 
            // addPartToolStripMenuItem
            // 
            this.addPartToolStripMenuItem.Name = "addPartToolStripMenuItem";
            this.addPartToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addPartToolStripMenuItem.Text = "Add Part";
            this.addPartToolStripMenuItem.Click += new System.EventHandler(this.addPartToolStripMenuItem_Click);
            // 
            // removePartToolStripMenuItem
            // 
            this.removePartToolStripMenuItem.Name = "removePartToolStripMenuItem";
            this.removePartToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.removePartToolStripMenuItem.Text = "Remove Part";
            this.removePartToolStripMenuItem.Click += new System.EventHandler(this.removePartToolStripMenuItem_Click);
            // 
            // updatePartToolStripMenuItem
            // 
            this.updatePartToolStripMenuItem.Name = "updatePartToolStripMenuItem";
            this.updatePartToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.updatePartToolStripMenuItem.Text = "Update Part";
            this.updatePartToolStripMenuItem.Click += new System.EventHandler(this.updatePartToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeBookingToolStripMenuItem,
            this.costServiceToolStripMenuItem,
            this.removeBookimgToolStripMenuItem,
            this.recordPaymentToolStripMenuItem});
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // makeBookingToolStripMenuItem
            // 
            this.makeBookingToolStripMenuItem.Name = "makeBookingToolStripMenuItem";
            this.makeBookingToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.makeBookingToolStripMenuItem.Text = "Make Booking";
            this.makeBookingToolStripMenuItem.Click += new System.EventHandler(this.makeBookingToolStripMenuItem_Click);
            // 
            // costServiceToolStripMenuItem
            // 
            this.costServiceToolStripMenuItem.Name = "costServiceToolStripMenuItem";
            this.costServiceToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.costServiceToolStripMenuItem.Text = "Cost Service";
            this.costServiceToolStripMenuItem.Click += new System.EventHandler(this.costServiceToolStripMenuItem_Click);
            // 
            // removeBookimgToolStripMenuItem
            // 
            this.removeBookimgToolStripMenuItem.Name = "removeBookimgToolStripMenuItem";
            this.removeBookimgToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.removeBookimgToolStripMenuItem.Text = "Remove Bookimg";
            this.removeBookimgToolStripMenuItem.Click += new System.EventHandler(this.removeBookimgToolStripMenuItem_Click);
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            this.recordPaymentToolStripMenuItem.Click += new System.EventHandler(this.recordPaymentToolStripMenuItem_Click);
            // 
            // monitoringToolStripMenuItem
            // 
            this.monitoringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem,
            this.frequentPartsRevenueAnalysisToolStripMenuItem});
            this.monitoringToolStripMenuItem.Name = "monitoringToolStripMenuItem";
            this.monitoringToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.monitoringToolStripMenuItem.Text = "Monitoring";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            this.yearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.yearlyToolStripMenuItem_Click);
            // 
            // frequentPartsRevenueAnalysisToolStripMenuItem
            // 
            this.frequentPartsRevenueAnalysisToolStripMenuItem.Name = "frequentPartsRevenueAnalysisToolStripMenuItem";
            this.frequentPartsRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.frequentPartsRevenueAnalysisToolStripMenuItem.Text = "Frequent Parts Analysis";
            this.frequentPartsRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.frequentPartsRevenueAnalysisToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imgMainMenu
            // 
            this.imgMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("imgMainMenu.Image")));
            this.imgMainMenu.Location = new System.Drawing.Point(12, 27);
            this.imgMainMenu.Name = "imgMainMenu";
            this.imgMainMenu.Size = new System.Drawing.Size(776, 411);
            this.imgMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMainMenu.TabIndex = 1;
            this.imgMainMenu.TabStop = false;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMainMenu.Location = new System.Drawing.Point(135, 93);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(544, 108);
            this.lblMainMenu.TabIndex = 2;
            this.lblMainMenu.Text = "Car Service";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.imgMainMenu);
            this.Controls.Add(this.mnuMainMenu);
            this.Name = "frmMainMenu";
            this.Text = "CarService - Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deregisterClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frequentPartsRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgMainMenu;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.ToolStripMenuItem removeBookimgToolStripMenuItem;
    }
}

