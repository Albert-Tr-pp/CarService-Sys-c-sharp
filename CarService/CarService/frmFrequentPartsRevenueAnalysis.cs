using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Oracle.ManagedDataAccess.Client;
using Software_Project_1;

namespace CarService
{
    public partial class frmFrequentPartsRevenueAnalysis : Form
    {
        frmMainMenu frmMainMenu = new frmMainMenu();
            
        public frmFrequentPartsRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void frmFrequentPartsRevenueAnalysis_Load(object sender, EventArgs e)
        {
            //Form load-trigger method
            GetDataForChart();
        }


        //method to get data from DB
        private void GetDataForChart()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            //String sqlQuery = "SELECT PartID, usedTimes FROM Parts WHERE usedTimes IS NOT NULL";
            String sqlQuery = "SELECT Type, Supplier, usedTimes FROM Parts WHERE usedTimes IS NOT NULL ORDER BY usedTimes DESC FETCH FIRST 10 ROWS ONLY";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "parts_usedTimes");

            //Close db connection
            conn.Close();

            BuildChart(ds.Tables["parts_usedTimes"]);
        }


        //method to build chart
        private void BuildChart(DataTable parts_usedTimes)
        {
            //creale chart
            crtParts.Series.Clear();

            Series series = new Series("Top 10 Used Parts");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in parts_usedTimes.Rows)
            {
                string type = row["Type"].ToString() + " - " + row["Supplier"].ToString();
                int usedTimes = Convert.ToInt32(row["usedTimes"]);

                series.Points.AddXY(type, usedTimes);
            }

            crtParts.Series.Add(series);

            crtParts.ChartAreas[0].AxisX.Title = "Type";
            crtParts.ChartAreas[0].AxisY.Title = "Used Times";

        }





        private void cboSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void imgTable2024_Click(object sender, EventArgs e)
        {

        }



    }
}
