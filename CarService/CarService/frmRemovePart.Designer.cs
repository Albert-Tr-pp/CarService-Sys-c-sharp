namespace CarService
{
    partial class frmRemovePart
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
            this.mnuRemovePart = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearchPart = new System.Windows.Forms.GroupBox();
            this.lbl_info_about_all = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblCompatibility = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCompatibility = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPartId = new System.Windows.Forms.Label();
            this.txtPartId = new System.Windows.Forms.TextBox();
            this.grpPartsList = new System.Windows.Forms.GroupBox();
            this.lsbRemovePart = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveSelectedPart = new System.Windows.Forms.Button();
            this.mnuRemovePart.SuspendLayout();
            this.grpSearchPart.SuspendLayout();
            this.grpPartsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRemovePart
            // 
            this.mnuRemovePart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuRemovePart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuRemovePart.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuRemovePart.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuRemovePart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuRemovePart.Location = new System.Drawing.Point(946, 11);
            this.mnuRemovePart.Name = "mnuRemovePart";
            this.mnuRemovePart.Size = new System.Drawing.Size(109, 28);
            this.mnuRemovePart.TabIndex = 3;
            this.mnuRemovePart.Text = "menuStrip1";
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
            // grpSearchPart
            // 
            this.grpSearchPart.Controls.Add(this.lbl_info_about_all);
            this.grpSearchPart.Controls.Add(this.label2);
            this.grpSearchPart.Controls.Add(this.txtType);
            this.grpSearchPart.Controls.Add(this.lblCompatibility);
            this.grpSearchPart.Controls.Add(this.btnFind);
            this.grpSearchPart.Controls.Add(this.txtCompatibility);
            this.grpSearchPart.Controls.Add(this.lblStreet);
            this.grpSearchPart.Controls.Add(this.lblPartId);
            this.grpSearchPart.Controls.Add(this.txtPartId);
            this.grpSearchPart.Location = new System.Drawing.Point(16, 84);
            this.grpSearchPart.Margin = new System.Windows.Forms.Padding(4);
            this.grpSearchPart.Name = "grpSearchPart";
            this.grpSearchPart.Padding = new System.Windows.Forms.Padding(4);
            this.grpSearchPart.Size = new System.Drawing.Size(499, 207);
            this.grpSearchPart.TabIndex = 4;
            this.grpSearchPart.TabStop = false;
            this.grpSearchPart.Text = "Search Part";
            // 
            // lbl_info_about_all
            // 
            this.lbl_info_about_all.AutoSize = true;
            this.lbl_info_about_all.ForeColor = System.Drawing.Color.Brown;
            this.lbl_info_about_all.Location = new System.Drawing.Point(146, 34);
            this.lbl_info_about_all.Name = "lbl_info_about_all";
            this.lbl_info_about_all.Size = new System.Drawing.Size(321, 16);
            this.lbl_info_about_all.TabIndex = 29;
            this.lbl_info_about_all.Text = "Type \"all\" in Compatibility or Type to get All records!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(219, 118);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.MaxLength = 20;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(248, 22);
            this.txtType.TabIndex = 19;
            // 
            // lblCompatibility
            // 
            this.lblCompatibility.AutoSize = true;
            this.lblCompatibility.Location = new System.Drawing.Point(107, 86);
            this.lblCompatibility.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompatibility.Name = "lblCompatibility";
            this.lblCompatibility.Size = new System.Drawing.Size(84, 16);
            this.lblCompatibility.TabIndex = 20;
            this.lblCompatibility.Text = "Compatibility";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(111, 150);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtCompatibility.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompatibility.MaxLength = 100;
            this.txtCompatibility.Name = "txtCompatibility";
            this.txtCompatibility.Size = new System.Drawing.Size(248, 22);
            this.txtCompatibility.TabIndex = 19;
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
            // lblPartId
            // 
            this.lblPartId.AutoSize = true;
            this.lblPartId.Location = new System.Drawing.Point(107, 54);
            this.lblPartId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartId.Name = "lblPartId";
            this.lblPartId.Size = new System.Drawing.Size(44, 16);
            this.lblPartId.TabIndex = 10;
            this.lblPartId.Text = "PartID";
            // 
            // txtPartId
            // 
            this.txtPartId.Location = new System.Drawing.Point(219, 54);
            this.txtPartId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartId.MaxLength = 3;
            this.txtPartId.Name = "txtPartId";
            this.txtPartId.Size = new System.Drawing.Size(248, 22);
            this.txtPartId.TabIndex = 0;
            // 
            // grpPartsList
            // 
            this.grpPartsList.Controls.Add(this.lsbRemovePart);
            this.grpPartsList.Controls.Add(this.label1);
            this.grpPartsList.Location = new System.Drawing.Point(523, 84);
            this.grpPartsList.Margin = new System.Windows.Forms.Padding(4);
            this.grpPartsList.Name = "grpPartsList";
            this.grpPartsList.Padding = new System.Windows.Forms.Padding(4);
            this.grpPartsList.Size = new System.Drawing.Size(532, 207);
            this.grpPartsList.TabIndex = 17;
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
            this.lsbRemovePart.Margin = new System.Windows.Forms.Padding(4);
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
            // btnRemoveSelectedPart
            // 
            this.btnRemoveSelectedPart.Location = new System.Drawing.Point(372, 298);
            this.btnRemoveSelectedPart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveSelectedPart.Name = "btnRemoveSelectedPart";
            this.btnRemoveSelectedPart.Size = new System.Drawing.Size(315, 28);
            this.btnRemoveSelectedPart.TabIndex = 18;
            this.btnRemoveSelectedPart.Text = "Remove";
            this.btnRemoveSelectedPart.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedPart.Visible = false;
            this.btnRemoveSelectedPart.Click += new System.EventHandler(this.btnRemoveSelectedPart_Click);
            // 
            // frmRemovePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpPartsList);
            this.Controls.Add(this.btnRemoveSelectedPart);
            this.Controls.Add(this.grpSearchPart);
            this.Controls.Add(this.mnuRemovePart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRemovePart";
            this.Text = "Car Service - Remove Part";
            this.Load += new System.EventHandler(this.frmRemovePart_Load);
            this.mnuRemovePart.ResumeLayout(false);
            this.mnuRemovePart.PerformLayout();
            this.grpSearchPart.ResumeLayout(false);
            this.grpSearchPart.PerformLayout();
            this.grpPartsList.ResumeLayout(false);
            this.grpPartsList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRemovePart;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSearchPart;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPartId;
        private System.Windows.Forms.TextBox txtPartId;
        private System.Windows.Forms.GroupBox grpPartsList;
        private System.Windows.Forms.ListBox lsbRemovePart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveSelectedPart;
        private System.Windows.Forms.Label lblCompatibility;
        private System.Windows.Forms.TextBox txtCompatibility;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lbl_info_about_all;
    }
}