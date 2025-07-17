namespace CarService
{
    partial class frmCostService
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
            this.mnuMakeBooking = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.grpAppointmentList = new System.Windows.Forms.GroupBox();
            this.lsbAppointmentsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPartsList = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.lsbPartsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSearchPart = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCompatibility = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPartId = new System.Windows.Forms.TextBox();
            this.grpAddedParts = new System.Windows.Forms.GroupBox();
            this.lsbPartsUsed = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCostService = new System.Windows.Forms.Button();
            this.lbl_info_about_all = new System.Windows.Forms.Label();
            this.mnuMakeBooking.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.grpAppointmentList.SuspendLayout();
            this.grpPartsList.SuspendLayout();
            this.grpSearchPart.SuspendLayout();
            this.grpAddedParts.SuspendLayout();
            this.SuspendLayout();
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
            this.mnuMakeBooking.Location = new System.Drawing.Point(944, 11);
            this.mnuMakeBooking.Name = "mnuMakeBooking";
            this.mnuMakeBooking.Size = new System.Drawing.Size(111, 28);
            this.mnuMakeBooking.TabIndex = 7;
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
            // grpDate
            // 
            this.grpDate.Controls.Add(this.dtpDate);
            this.grpDate.Controls.Add(this.label3);
            this.grpDate.Location = new System.Drawing.Point(16, 15);
            this.grpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDate.Name = "grpDate";
            this.grpDate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDate.Size = new System.Drawing.Size(277, 60);
            this.grpDate.TabIndex = 18;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Pick Date";
            this.grpDate.Enter += new System.EventHandler(this.grpDate_Enter);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(4, 20);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 15;
            this.dtpDate.Value = new System.DateTime(2024, 11, 25, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
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
            // grpAppointmentList
            // 
            this.grpAppointmentList.Controls.Add(this.lsbAppointmentsList);
            this.grpAppointmentList.Controls.Add(this.label2);
            this.grpAppointmentList.Location = new System.Drawing.Point(301, 15);
            this.grpAppointmentList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAppointmentList.Name = "grpAppointmentList";
            this.grpAppointmentList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAppointmentList.Size = new System.Drawing.Size(608, 145);
            this.grpAppointmentList.TabIndex = 26;
            this.grpAppointmentList.TabStop = false;
            this.grpAppointmentList.Text = "Select Appointment from List";
            this.grpAppointmentList.Visible = false;
            this.grpAppointmentList.Enter += new System.EventHandler(this.grpAppointmentList_Enter);
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
            this.lsbAppointmentsList.Size = new System.Drawing.Size(577, 100);
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
            // grpPartsList
            // 
            this.grpPartsList.Controls.Add(this.txtTotal);
            this.grpPartsList.Controls.Add(this.label9);
            this.grpPartsList.Controls.Add(this.btnRemovePart);
            this.grpPartsList.Controls.Add(this.btnAddPart);
            this.grpPartsList.Controls.Add(this.lsbPartsList);
            this.grpPartsList.Controls.Add(this.label1);
            this.grpPartsList.Location = new System.Drawing.Point(416, 167);
            this.grpPartsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPartsList.Name = "grpPartsList";
            this.grpPartsList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPartsList.Size = new System.Drawing.Size(639, 239);
            this.grpPartsList.TabIndex = 28;
            this.grpPartsList.TabStop = false;
            this.grpPartsList.Text = "Select Part from List";
            this.grpPartsList.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(369, 158);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 24;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total";
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Location = new System.Drawing.Point(324, 201);
            this.btnRemovePart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(307, 28);
            this.btnRemovePart.TabIndex = 22;
            this.btnRemovePart.Text = "Remove";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(21, 201);
            this.btnAddPart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(295, 28);
            this.btnAddPart.TabIndex = 21;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // lsbPartsList
            // 
            this.lsbPartsList.FormattingEnabled = true;
            this.lsbPartsList.ItemHeight = 16;
            this.lsbPartsList.Items.AddRange(new object[] {
            "•Type: V4 Engine Baccu; •Compatibility: Ford Cacus 2012; •Manufacturer: Ford; •Pr" +
                "ice: 2235",
            "•Type: F23 steering wheel; •Compatibility: G3 Screw; •Manufacturer: Lexus; •Price" +
                ": 120.",
            "•Type: V4 Engine Baccu; •Compatibility: Ford Cacus 2012; •Manufacturer: Ford; •Pr" +
                "ice: 235."});
            this.lsbPartsList.Location = new System.Drawing.Point(21, 26);
            this.lsbPartsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbPartsList.Name = "lsbPartsList";
            this.lsbPartsList.Size = new System.Drawing.Size(608, 116);
            this.lsbPartsList.TabIndex = 15;
            this.lsbPartsList.SelectedIndexChanged += new System.EventHandler(this.lsbPartsList_SelectedIndexChanged);
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
            // grpSearchPart
            // 
            this.grpSearchPart.Controls.Add(this.lbl_info_about_all);
            this.grpSearchPart.Controls.Add(this.label5);
            this.grpSearchPart.Controls.Add(this.txtType);
            this.grpSearchPart.Controls.Add(this.label6);
            this.grpSearchPart.Controls.Add(this.btnFind);
            this.grpSearchPart.Controls.Add(this.txtCompatibility);
            this.grpSearchPart.Controls.Add(this.label7);
            this.grpSearchPart.Controls.Add(this.label8);
            this.grpSearchPart.Controls.Add(this.txtPartId);
            this.grpSearchPart.Location = new System.Drawing.Point(20, 167);
            this.grpSearchPart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchPart.Name = "grpSearchPart";
            this.grpSearchPart.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchPart.Size = new System.Drawing.Size(388, 193);
            this.grpSearchPart.TabIndex = 27;
            this.grpSearchPart.TabStop = false;
            this.grpSearchPart.Text = "Search Part";
            this.grpSearchPart.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(131, 117);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtType.MaxLength = 20;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(248, 22);
            this.txtType.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Compatibility";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(23, 149);
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
            this.txtCompatibility.Location = new System.Drawing.Point(131, 85);
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
            this.label8.Location = new System.Drawing.Point(19, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "PartID";
            // 
            // txtPartId
            // 
            this.txtPartId.Location = new System.Drawing.Point(131, 53);
            this.txtPartId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPartId.MaxLength = 3;
            this.txtPartId.Name = "txtPartId";
            this.txtPartId.Size = new System.Drawing.Size(248, 22);
            this.txtPartId.TabIndex = 0;
            // 
            // grpAddedParts
            // 
            this.grpAddedParts.Controls.Add(this.lsbPartsUsed);
            this.grpAddedParts.Controls.Add(this.label4);
            this.grpAddedParts.Location = new System.Drawing.Point(16, 368);
            this.grpAddedParts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddedParts.Name = "grpAddedParts";
            this.grpAddedParts.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddedParts.Size = new System.Drawing.Size(392, 171);
            this.grpAddedParts.TabIndex = 27;
            this.grpAddedParts.TabStop = false;
            this.grpAddedParts.Text = "Parts Used";
            this.grpAddedParts.Visible = false;
            // 
            // lsbPartsUsed
            // 
            this.lsbPartsUsed.FormattingEnabled = true;
            this.lsbPartsUsed.ItemHeight = 16;
            this.lsbPartsUsed.Location = new System.Drawing.Point(21, 27);
            this.lsbPartsUsed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbPartsUsed.Name = "lsbPartsUsed";
            this.lsbPartsUsed.Size = new System.Drawing.Size(361, 132);
            this.lsbPartsUsed.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 14;
            // 
            // btnCostService
            // 
            this.btnCostService.Location = new System.Drawing.Point(437, 414);
            this.btnCostService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCostService.Name = "btnCostService";
            this.btnCostService.Size = new System.Drawing.Size(188, 78);
            this.btnCostService.TabIndex = 22;
            this.btnCostService.Text = "Cost";
            this.btnCostService.UseVisualStyleBackColor = true;
            this.btnCostService.Visible = false;
            this.btnCostService.Click += new System.EventHandler(this.btnCostService_Click);
            // 
            // lbl_info_about_all
            // 
            this.lbl_info_about_all.AutoSize = true;
            this.lbl_info_about_all.ForeColor = System.Drawing.Color.Brown;
            this.lbl_info_about_all.Location = new System.Drawing.Point(59, 33);
            this.lbl_info_about_all.Name = "lbl_info_about_all";
            this.lbl_info_about_all.Size = new System.Drawing.Size(321, 16);
            this.lbl_info_about_all.TabIndex = 30;
            this.lbl_info_about_all.Text = "Type \"all\" in Compatibility or Type to get All records!!!";
            // 
            // frmCostService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCostService);
            this.Controls.Add(this.grpAddedParts);
            this.Controls.Add(this.grpPartsList);
            this.Controls.Add(this.grpSearchPart);
            this.Controls.Add(this.grpAppointmentList);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.mnuMakeBooking);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCostService";
            this.Text = "Car Service - Cost Service";
            this.Load += new System.EventHandler(this.frmCostService_Load);
            this.mnuMakeBooking.ResumeLayout(false);
            this.mnuMakeBooking.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.grpAppointmentList.ResumeLayout(false);
            this.grpAppointmentList.PerformLayout();
            this.grpPartsList.ResumeLayout(false);
            this.grpPartsList.PerformLayout();
            this.grpSearchPart.ResumeLayout(false);
            this.grpSearchPart.PerformLayout();
            this.grpAddedParts.ResumeLayout(false);
            this.grpAddedParts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpAppointmentList;
        private System.Windows.Forms.ListBox lsbAppointmentsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPartsList;
        private System.Windows.Forms.ListBox lsbPartsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSearchPart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtCompatibility;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPartId;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.GroupBox grpAddedParts;
        private System.Windows.Forms.ListBox lsbPartsUsed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCostService;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_info_about_all;
    }
}