namespace CarService
{
    partial class frmAddPart
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
            this.mnuAddPart = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAppPart = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAppPart = new System.Windows.Forms.Button();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblCompatibility = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtCompatibility = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.mnuAddPart.SuspendLayout();
            this.grpAppPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddPart
            // 
            this.mnuAddPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuAddPart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuAddPart.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuAddPart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuAddPart.Location = new System.Drawing.Point(701, 9);
            this.mnuAddPart.Name = "mnuAddPart";
            this.mnuAddPart.Size = new System.Drawing.Size(90, 24);
            this.mnuAddPart.TabIndex = 2;
            this.mnuAddPart.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpAppPart
            // 
            this.grpAppPart.Controls.Add(this.txtQuantity);
            this.grpAppPart.Controls.Add(this.btnAppPart);
            this.grpAppPart.Controls.Add(this.lblStreet);
            this.grpAppPart.Controls.Add(this.lblPrice);
            this.grpAppPart.Controls.Add(this.lblQuantity);
            this.grpAppPart.Controls.Add(this.lblManufacturer);
            this.grpAppPart.Controls.Add(this.lblSupplier);
            this.grpAppPart.Controls.Add(this.lblCompatibility);
            this.grpAppPart.Controls.Add(this.lblType);
            this.grpAppPart.Controls.Add(this.txtPrice);
            this.grpAppPart.Controls.Add(this.txtManufacturer);
            this.grpAppPart.Controls.Add(this.txtSupplier);
            this.grpAppPart.Controls.Add(this.txtCompatibility);
            this.grpAppPart.Controls.Add(this.txtType);
            this.grpAppPart.Location = new System.Drawing.Point(12, 40);
            this.grpAppPart.Name = "grpAppPart";
            this.grpAppPart.Size = new System.Drawing.Size(374, 267);
            this.grpAppPart.TabIndex = 3;
            this.grpAppPart.TabStop = false;
            this.grpAppPart.Text = "App Part";
            this.grpAppPart.Enter += new System.EventHandler(this.grpUpdateClient_Enter);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(164, 148);
            this.txtQuantity.MaxLength = 3;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(187, 20);
            this.txtQuantity.TabIndex = 17;
            // 
            // btnAppPart
            // 
            this.btnAppPart.Location = new System.Drawing.Point(83, 216);
            this.btnAppPart.Name = "btnAppPart";
            this.btnAppPart.Size = new System.Drawing.Size(268, 23);
            this.btnAppPart.TabIndex = 16;
            this.btnAppPart.Text = "Add Part";
            this.btnAppPart.UseVisualStyleBackColor = true;
            this.btnAppPart.Click += new System.EventHandler(this.btnAppPart_Click);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(80, 200);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(0, 13);
            this.lblStreet.TabIndex = 14;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(80, 174);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(80, 148);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity ";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(80, 122);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblManufacturer.TabIndex = 11;
            this.lblManufacturer.Text = "Manufacturer ";
            this.lblManufacturer.UseWaitCursor = true;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(80, 96);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(48, 13);
            this.lblSupplier.TabIndex = 10;
            this.lblSupplier.Text = "Supplier ";
            // 
            // lblCompatibility
            // 
            this.lblCompatibility.AutoSize = true;
            this.lblCompatibility.Location = new System.Drawing.Point(80, 70);
            this.lblCompatibility.Name = "lblCompatibility";
            this.lblCompatibility.Size = new System.Drawing.Size(65, 13);
            this.lblCompatibility.TabIndex = 9;
            this.lblCompatibility.Text = "Compatibility";
            this.lblCompatibility.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(80, 44);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(164, 174);
            this.txtPrice.MaxLength = 4;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(187, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(164, 122);
            this.txtManufacturer.MaxLength = 20;
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(187, 20);
            this.txtManufacturer.TabIndex = 3;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(164, 96);
            this.txtSupplier.MaxLength = 20;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(187, 20);
            this.txtSupplier.TabIndex = 2;
            // 
            // txtCompatibility
            // 
            this.txtCompatibility.Location = new System.Drawing.Point(164, 70);
            this.txtCompatibility.MaxLength = 100;
            this.txtCompatibility.Name = "txtCompatibility";
            this.txtCompatibility.Size = new System.Drawing.Size(187, 20);
            this.txtCompatibility.TabIndex = 1;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(164, 44);
            this.txtType.MaxLength = 20;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(187, 20);
            this.txtType.TabIndex = 0;
            // 
            // frmAddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAppPart);
            this.Controls.Add(this.mnuAddPart);
            this.Name = "frmAddPart";
            this.Text = "Car Service - Add Part";
            this.Load += new System.EventHandler(this.frmAddPart_Load);
            this.mnuAddPart.ResumeLayout(false);
            this.mnuAddPart.PerformLayout();
            this.grpAppPart.ResumeLayout(false);
            this.grpAppPart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddPart;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpAppPart;
        private System.Windows.Forms.Button btnAppPart;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblCompatibility;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtCompatibility;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}