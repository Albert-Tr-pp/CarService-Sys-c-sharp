namespace CarService
{
    partial class frmUpdatePart
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
            this.mnuUpdatePart = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdatePart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCompatibility = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPartId = new System.Windows.Forms.TextBox();
            this.grpPartsList = new System.Windows.Forms.GroupBox();
            this.lsbRemovePart = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpUpdatePart = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
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
            this.txtCompatibility_to_update = new System.Windows.Forms.TextBox();
            this.txtType_to_update = new System.Windows.Forms.TextBox();
            this.lbl_info_about_all = new System.Windows.Forms.Label();
            this.mnuUpdatePart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpPartsList.SuspendLayout();
            this.grpUpdatePart.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdatePart
            // 
            this.mnuUpdatePart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuUpdatePart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuUpdatePart.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuUpdatePart.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuUpdatePart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuUpdatePart.Location = new System.Drawing.Point(944, 11);
            this.mnuUpdatePart.Name = "mnuUpdatePart";
            this.mnuUpdatePart.Size = new System.Drawing.Size(111, 28);
            this.mnuUpdatePart.TabIndex = 3;
            this.mnuUpdatePart.Text = "menuStrip1";
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
            // btnUpdatePart
            // 
            this.btnUpdatePart.Location = new System.Drawing.Point(523, 471);
            this.btnUpdatePart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdatePart.Name = "btnUpdatePart";
            this.btnUpdatePart.Size = new System.Drawing.Size(169, 68);
            this.btnUpdatePart.TabIndex = 16;
            this.btnUpdatePart.Text = "Update Part";
            this.btnUpdatePart.UseVisualStyleBackColor = true;
            this.btnUpdatePart.Visible = false;
            this.btnUpdatePart.Click += new System.EventHandler(this.btnUpdatePart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_info_about_all);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtCompatibility);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPartId);
            this.groupBox1.Location = new System.Drawing.Point(16, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(499, 207);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Part";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(219, 118);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtType.MaxLength = 20;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(248, 22);
            this.txtType.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Compatibility";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(111, 150);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(357, 28);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtCompatibility
            // 
            this.txtCompatibility.Location = new System.Drawing.Point(219, 86);
            this.txtCompatibility.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompatibility.MaxLength = 100;
            this.txtCompatibility.Name = "txtCompatibility";
            this.txtCompatibility.Size = new System.Drawing.Size(248, 22);
            this.txtCompatibility.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "PartID";
            // 
            // txtPartId
            // 
            this.txtPartId.Location = new System.Drawing.Point(219, 54);
            this.txtPartId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPartId.MaxLength = 3;
            this.txtPartId.Name = "txtPartId";
            this.txtPartId.Size = new System.Drawing.Size(248, 22);
            this.txtPartId.TabIndex = 0;
            // 
            // grpPartsList
            // 
            this.grpPartsList.Controls.Add(this.lsbRemovePart);
            this.grpPartsList.Controls.Add(this.label1);
            this.grpPartsList.Location = new System.Drawing.Point(523, 44);
            this.grpPartsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPartsList.Name = "grpPartsList";
            this.grpPartsList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPartsList.Size = new System.Drawing.Size(532, 207);
            this.grpPartsList.TabIndex = 21;
            this.grpPartsList.TabStop = false;
            this.grpPartsList.Text = "Select Part from List";
            this.grpPartsList.Visible = false;
            // 
            // lsbRemovePart
            // 
            this.lsbRemovePart.FormattingEnabled = true;
            this.lsbRemovePart.ItemHeight = 16;
            this.lsbRemovePart.Items.AddRange(new object[] {
            "•Type: V4 Engine Baccu; •Compatibility: Ford Cacus 2012; •Manufacturer: Ford; •Pr" +
                "ice: 235."});
            this.lsbRemovePart.Location = new System.Drawing.Point(21, 54);
            this.lsbRemovePart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbRemovePart.Name = "lsbRemovePart";
            this.lsbRemovePart.Size = new System.Drawing.Size(489, 116);
            this.lsbRemovePart.TabIndex = 15;
            this.lsbRemovePart.SelectedIndexChanged += new System.EventHandler(this.lsbRemovePart_SelectedIndexChanged);
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
            // grpUpdatePart
            // 
            this.grpUpdatePart.Controls.Add(this.txtQuantity);
            this.grpUpdatePart.Controls.Add(this.lblStreet);
            this.grpUpdatePart.Controls.Add(this.lblPrice);
            this.grpUpdatePart.Controls.Add(this.lblQuantity);
            this.grpUpdatePart.Controls.Add(this.lblManufacturer);
            this.grpUpdatePart.Controls.Add(this.lblSupplier);
            this.grpUpdatePart.Controls.Add(this.lblCompatibility);
            this.grpUpdatePart.Controls.Add(this.lblType);
            this.grpUpdatePart.Controls.Add(this.txtPrice);
            this.grpUpdatePart.Controls.Add(this.txtManufacturer);
            this.grpUpdatePart.Controls.Add(this.txtSupplier);
            this.grpUpdatePart.Controls.Add(this.txtCompatibility_to_update);
            this.grpUpdatePart.Controls.Add(this.txtType_to_update);
            this.grpUpdatePart.Location = new System.Drawing.Point(16, 258);
            this.grpUpdatePart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdatePart.Name = "grpUpdatePart";
            this.grpUpdatePart.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdatePart.Size = new System.Drawing.Size(499, 281);
            this.grpUpdatePart.TabIndex = 16;
            this.grpUpdatePart.TabStop = false;
            this.grpUpdatePart.Text = "Update Part";
            this.grpUpdatePart.Visible = false;
            this.grpUpdatePart.Enter += new System.EventHandler(this.grpUpdatePart_Enter);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(219, 182);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.MaxLength = 3;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(248, 22);
            this.txtQuantity.TabIndex = 17;
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
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(107, 214);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(107, 182);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 16);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity ";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(107, 150);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(87, 16);
            this.lblManufacturer.TabIndex = 11;
            this.lblManufacturer.Text = "Manufacturer ";
            this.lblManufacturer.UseWaitCursor = true;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(107, 118);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(60, 16);
            this.lblSupplier.TabIndex = 10;
            this.lblSupplier.Text = "Supplier ";
            // 
            // lblCompatibility
            // 
            this.lblCompatibility.AutoSize = true;
            this.lblCompatibility.Location = new System.Drawing.Point(107, 86);
            this.lblCompatibility.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompatibility.Name = "lblCompatibility";
            this.lblCompatibility.Size = new System.Drawing.Size(84, 16);
            this.lblCompatibility.TabIndex = 9;
            this.lblCompatibility.Text = "Compatibility";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(107, 54);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(219, 214);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.MaxLength = 6;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(248, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(219, 150);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtManufacturer.MaxLength = 20;
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(248, 22);
            this.txtManufacturer.TabIndex = 3;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(219, 118);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplier.MaxLength = 20;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(248, 22);
            this.txtSupplier.TabIndex = 2;
            // 
            // txtCompatibility_to_update
            // 
            this.txtCompatibility_to_update.Location = new System.Drawing.Point(219, 86);
            this.txtCompatibility_to_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompatibility_to_update.MaxLength = 100;
            this.txtCompatibility_to_update.Name = "txtCompatibility_to_update";
            this.txtCompatibility_to_update.Size = new System.Drawing.Size(248, 22);
            this.txtCompatibility_to_update.TabIndex = 1;
            // 
            // txtType_to_update
            // 
            this.txtType_to_update.Location = new System.Drawing.Point(219, 54);
            this.txtType_to_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtType_to_update.MaxLength = 20;
            this.txtType_to_update.Name = "txtType_to_update";
            this.txtType_to_update.Size = new System.Drawing.Size(248, 22);
            this.txtType_to_update.TabIndex = 0;
            this.txtType_to_update.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_info_about_all
            // 
            this.lbl_info_about_all.AutoSize = true;
            this.lbl_info_about_all.ForeColor = System.Drawing.Color.Brown;
            this.lbl_info_about_all.Location = new System.Drawing.Point(171, 19);
            this.lbl_info_about_all.Name = "lbl_info_about_all";
            this.lbl_info_about_all.Size = new System.Drawing.Size(321, 16);
            this.lbl_info_about_all.TabIndex = 28;
            this.lbl_info_about_all.Text = "Type \"all\" in Compatibility or Type to get All records!!!";
            this.lbl_info_about_all.Click += new System.EventHandler(this.lbl_info_about_all_Click);
            // 
            // frmUpdatePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpUpdatePart);
            this.Controls.Add(this.grpPartsList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdatePart);
            this.Controls.Add(this.mnuUpdatePart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUpdatePart";
            this.Text = "Car Service - Update Part";
            this.Load += new System.EventHandler(this.frmUpdatePart_Load);
            this.mnuUpdatePart.ResumeLayout(false);
            this.mnuUpdatePart.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPartsList.ResumeLayout(false);
            this.grpPartsList.PerformLayout();
            this.grpUpdatePart.ResumeLayout(false);
            this.grpUpdatePart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdatePart;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdatePart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtCompatibility;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPartId;
        private System.Windows.Forms.GroupBox grpPartsList;
        private System.Windows.Forms.ListBox lsbRemovePart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpUpdatePart;
        private System.Windows.Forms.TextBox txtQuantity;
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
        private System.Windows.Forms.TextBox txtCompatibility_to_update;
        private System.Windows.Forms.TextBox txtType_to_update;
        private System.Windows.Forms.Label lbl_info_about_all;
    }
}