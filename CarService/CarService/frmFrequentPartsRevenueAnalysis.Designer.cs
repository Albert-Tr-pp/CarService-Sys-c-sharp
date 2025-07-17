namespace CarService
{
    partial class frmFrequentPartsRevenueAnalysis
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
            this.mnuDeregisterClient = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.grpSelectYear = new System.Windows.Forms.GroupBox();
            this.cboSelectYear = new System.Windows.Forms.ComboBox();
            this.crtParts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuDeregisterClient.SuspendLayout();
            this.grpTable.SuspendLayout();
            this.grpSelectYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtParts)).BeginInit();
            this.SuspendLayout();
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
            this.mnuDeregisterClient.TabIndex = 4;
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
            // grpTable
            // 
            this.grpTable.Controls.Add(this.crtParts);
            this.grpTable.Location = new System.Drawing.Point(-1, 43);
            this.grpTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTable.Name = "grpTable";
            this.grpTable.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTable.Size = new System.Drawing.Size(1068, 511);
            this.grpTable.TabIndex = 9;
            this.grpTable.TabStop = false;
            this.grpTable.Text = "Table";
            // 
            // grpSelectYear
            // 
            this.grpSelectYear.Controls.Add(this.cboSelectYear);
            this.grpSelectYear.Location = new System.Drawing.Point(15, 62);
            this.grpSelectYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSelectYear.Name = "grpSelectYear";
            this.grpSelectYear.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSelectYear.Size = new System.Drawing.Size(261, 188);
            this.grpSelectYear.TabIndex = 8;
            this.grpSelectYear.TabStop = false;
            this.grpSelectYear.Text = "Select Year for Analysis";
            this.grpSelectYear.Visible = false;
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
            this.cboSelectYear.Location = new System.Drawing.Point(8, 23);
            this.cboSelectYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSelectYear.Name = "cboSelectYear";
            this.cboSelectYear.Size = new System.Drawing.Size(160, 24);
            this.cboSelectYear.TabIndex = 6;
            this.cboSelectYear.SelectedIndexChanged += new System.EventHandler(this.cboSelectYear_SelectedIndexChanged);
            // 
            // crtParts
            // 
            chartArea1.Name = "ChartArea1";
            this.crtParts.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtParts.Legends.Add(legend1);
            this.crtParts.Location = new System.Drawing.Point(0, 19);
            this.crtParts.Name = "crtParts";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crtParts.Series.Add(series1);
            this.crtParts.Size = new System.Drawing.Size(1068, 492);
            this.crtParts.TabIndex = 0;
            this.crtParts.Text = "crtPart";
            // 
            // frmFrequentPartsRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpTable);
            this.Controls.Add(this.grpSelectYear);
            this.Controls.Add(this.mnuDeregisterClient);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFrequentPartsRevenueAnalysis";
            this.Text = "Car Service - Frequent Parts Revenue Analysis";
            this.Load += new System.EventHandler(this.frmFrequentPartsRevenueAnalysis_Load);
            this.mnuDeregisterClient.ResumeLayout(false);
            this.mnuDeregisterClient.PerformLayout();
            this.grpTable.ResumeLayout(false);
            this.grpSelectYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuDeregisterClient;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.GroupBox grpSelectYear;
        private System.Windows.Forms.ComboBox cboSelectYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtParts;
    }
}