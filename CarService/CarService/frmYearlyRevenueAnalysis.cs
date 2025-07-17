using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Software_Project_1;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace CarService
{
    public partial class frmYearlyRevenueAnalysis : Form
    {
        frmMainMenu frmMainMenu =  new frmMainMenu();

        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cboSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve the selected year from the combo box
            string selectedYear = cboSelectYear.SelectedItem.ToString();

            GetDataForChart(selectedYear);
        }


        //method to get data from DB
        private void GetDataForChart(String year)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            //String sqlQuery = "SELECT PartID, usedTimes FROM Parts WHERE usedTimes IS NOT NULL";
            //String sqlQuery = "SELECT TO_CHAR(A.App_Date, 'MM') AS Month, SUM(P.Price) AS Revenue FROM Appointments A JOIN ServiceParts SP ON A.AppointmentID = SP.AppointmentID JOIN Parts P ON SP.PartID = P.PartID WHERE EXTRACT(YEAR FROM A.App_Date) = " + year + " GROUP BY TO_CHAR(A.App_Date, 'MM') ORDER BY TO_CHAR(A.App_Date, 'MM');";

            String sqlQuery = "SELECT TO_CHAR(A.App_Date, 'MM') AS Month, " +
                "SUM(P.Price) AS Revenue " +
                "FROM Appointments A " +
                "JOIN ServiceParts SP ON A.AppointmentID = SP.AppointmentID " +
                "JOIN Parts P ON SP.PartID = P.PartID " +
                "WHERE EXTRACT(YEAR FROM A.App_Date) = " + year + " " +
                "GROUP BY TO_CHAR(A.App_Date, 'MM') " +
                "ORDER BY TO_CHAR(A.App_Date, 'MM')";

            Debug.WriteLine("Chart data sql statment: " + sqlQuery);

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "yearly_revenue");

            //Close db connection
            conn.Close();

            BuildChart(ds.Tables["yearly_revenue"]);
        }


        //method to build chart
        private void BuildChart(DataTable yearly_revenue)
        {
            //creale chart
            crtRevenue.Series.Clear();

            Series series = new Series("Yearly Revenue");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in yearly_revenue.Rows)
            {
                string month = row["Month"].ToString();
                month = monthConverter(month);

                int revenue = Convert.ToInt32(row["Revenue"]);

                series.Points.AddXY(month, revenue);
            }

            crtRevenue.Series.Add(series);

            crtRevenue.ChartAreas[0].AxisX.Title = "Month";
            crtRevenue.ChartAreas[0].AxisY.Title = "Revenue";

        }

        private string monthConverter(String mm)
        {
            switch (mm)
            {
                case "01":
                    mm = "Jan";
                    break;
                case "02":
                    mm = "Feb";
                    break;
                case "03":
                    mm = "Mar";
                    break;
                case "04":
                    mm = "Apr";
                    break;
                case "05":
                    mm = "May";
                    break;
                case "06":
                    mm = "Jun";
                    break;
                case "07":
                    mm = "Jul";
                    break;
                case "08":
                    mm = "Aug";
                    break;
                case "09":
                    mm = "Sep";
                    break;
                case "10":
                    mm = "Oct";
                    break;
                case "11":
                    mm = "Nov";
                    break;
                case "12":
                    mm = "Dec";
                    break;
            }

            return mm;
        }




        private void imgTable2028_Click(object sender, EventArgs e)
        {
        }



        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
        }
    }
}
