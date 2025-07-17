namespace CarService
{
    partial class frmYearlyRevenueAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuUpdatePart = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSelectYear = new System.Windows.Forms.GroupBox();
            this.cboSelectYear = new System.Windows.Forms.ComboBox();
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.crtRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuUpdatePart.SuspendLayout();
            this.grpSelectYear.SuspendLayout();
            this.grpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtRevenue)).BeginInit();
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
            this.mnuUpdatePart.Location = new System.Drawing.Point(946, 11);
            this.mnuUpdatePart.Name = "mnuUpdatePart";
            this.mnuUpdatePart.Size = new System.Drawing.Size(109, 28);
            this.mnuUpdatePart.TabIndex = 4;
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
            // grpSelectYear
            // 
            this.grpSelectYear.Controls.Add(this.cboSelectYear);
            this.grpSelectYear.Location = new System.Drawing.Point(889, 59);
            this.grpSelectYear.Margin = new System.Windows.Forms.Padding(4);
            this.grpSelectYear.Name = "grpSelectYear";
            this.grpSelectYear.Padding = new System.Windows.Forms.Padding(4);
            this.grpSelectYear.Size = new System.Drawing.Size(166, 83);
            this.grpSelectYear.TabIndex = 5;
            this.grpSelectYear.TabStop = false;
            this.grpSelectYear.Text = "Select Year for Analysis";
            // 
            // cboSelectYear
            // 
            this.cboSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectYear.FormattingEnabled = true;
            this.cboSelectYear.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.cboSelectYear.Location = new System.Drawing.Point(8, 51);
            this.cboSelectYear.Margin = new System.Windows.Forms.Padding(4);
            this.cboSelectYear.Name = "cboSelectYear";
            this.cboSelectYear.Size = new System.Drawing.Size(150, 24);
            this.cboSelectYear.TabIndex = 6;
            this.cboSelectYear.SelectedIndexChanged += new System.EventHandler(this.cboSelectYear_SelectedIndexChanged);
            // 
            // grpTable
            // 
            this.grpTable.Controls.Add(this.crtRevenue);
            this.grpTable.Location = new System.Drawing.Point(-1, 2);
            this.grpTable.Margin = new System.Windows.Forms.Padding(4);
            this.grpTable.Name = "grpTable";
            this.grpTable.Padding = new System.Windows.Forms.Padding(4);
            this.grpTable.Size = new System.Drawing.Size(882, 553);
            this.grpTable.TabIndex = 7;
            this.grpTable.TabStop = false;
            this.grpTable.Text = "Table";
            // 
            // crtRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.crtRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtRevenue.Legends.Add(legend1);
            this.crtRevenue.Location = new System.Drawing.Point(0, 22);
            this.crtRevenue.Name = "crtRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crtRevenue.Series.Add(series1);
            this.crtRevenue.Size = new System.Drawing.Size(882, 531);
            this.crtRevenue.TabIndex = 0;
            this.crtRevenue.Text = "crtRevenue";
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpTable);
            this.Controls.Add(this.grpSelectYear);
            this.Controls.Add(this.mnuUpdatePart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmYearlyRevenueAnalysis";
            this.Text = "Car Service - Yearly Revenue Analysis";
            this.Load += new System.EventHandler(this.frmYearlyRevenueAnalysis_Load);
            this.mnuUpdatePart.ResumeLayout(false);
            this.mnuUpdatePart.PerformLayout();
            this.grpSelectYear.ResumeLayout(false);
            this.grpTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdatePart;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSelectYear;
        private System.Windows.Forms.ComboBox cboSelectYear;
        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtRevenue;
    }
}