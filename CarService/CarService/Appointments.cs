using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Software_Project_1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using System.Diagnostics;

namespace CarService
{
    internal class Appointments
    {
        private int AppointmentsID;
        private int ClientID;
        private string App_Date;
        private string App_Time;
        private double Cost;
        private char Status;

        public static int counter = 100;

        public Appointments()
        {
            this.AppointmentsID = 0;
            this.ClientID = 0;
            this.App_Date = "";
            this.App_Time = "";
            this.Cost = 0;
        }

        public Appointments(int ClientID, string App_Date, string App_Time, double Cost)
        {
            setAppointmentsID(getMaxID());
            setClientID(ClientID);
            setApp_Date(App_Date);
            setApp_Time(App_Time);
            setCost(Cost);
            setStatus('R');

        }

        //getters & setters
        //getters
        public int getClientID() { return this.ClientID; }
        public string getApp_Date() { return this.App_Date; }
        public string getApp_Time() { return this.App_Time; }
        public double getCost() { return this.Cost; }
        public char getStatus() { return this.Status; }

        //setters
        public void setAppointmentsID(int ID)
        {
            //get highest id and increment it : if no clients in DB = use value 100
            if (ID != 0)
            {
                this.AppointmentsID = ID + 1;
            }
            else
            {
                this.AppointmentsID = 100;
            }
        }
        public void setClientID(int ClientID) { this.ClientID = ClientID; }
        public void setApp_Date(String App_Date) { this.App_Date = App_Date; }
        public void setApp_Time(String App_Time) { this.App_Time = App_Time; }
        public void setCost(double Cost) { this.Cost = Cost; }
        public void setStatus(char Status) { this.Status = Status; }

        //method to maximum id value
        public static int getMaxID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(AppointmentID) FROM Appointments";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            // Open the connection
            conn.Open();

            // Execute the query and retrieve the result
            object result = cmd.ExecuteScalar();

            // Close the connection
            conn.Close();

            // If result is null, return 0 overwise value
            return result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }

        //get all taken times fot selected day
        public static DataSet getAvailableTime(String date)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Open the connection
            conn.Open();

            String sqlQuery = "SELECT Time FROM (SELECT '10:00' AS Time FROM dual UNION ALL SELECT '12:00' FROM dual UNION ALL SELECT '16:00' FROM dual UNION ALL SELECT '18:00' FROM dual) AllTimes WHERE Time NOT IN (SELECT App_Time FROM Appointments WHERE App_Date = TO_DATE('" + date +"', 'DD-MM-YYYY') AND Status = 'R')";
            Debug.WriteLine(sqlQuery);

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "times");

            //Close db connection
            conn.Close();

            return ds;
        }


        //add appointment method
        public void AddAppointment()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "INSERT INTO Appointments VALUES (" + AppointmentsID + ", '" + ClientID + "', TO_DATE('" + App_Date + "', 'DD-MM-YYYY')" + ", '" + App_Time + "', '" + Cost + "', '" + Status + "')";

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);

            conn.Open();
            Debug.WriteLine(SQLQuery);

            cmd.ExecuteNonQuery();

            conn.Close();
        }



        //method to get Appointments by ClientID
        public static DataSet getAppointmentsByClientID(String id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
            "FROM Appointments WHERE Cost = 0 AND Status = 'R' AND ClientID = " + id + " ORDER BY App_Date, App_Time";

            Debug.WriteLine(sqlQuery);

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "appointments");

            //Close db connection
            conn.Close();

            return ds;
        }



        //,ethod to get Appointments by Date
        public static DataSet getAppointmentsByDate(String date)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
            "FROM Appointments WHERE Cost = 0 AND Status = 'R' AND App_Date = TO_DATE('" + date + "', 'DD-MM-YYYY') ORDER BY App_Date, App_Time";

            Debug.WriteLine("Get All Apps by Date" + sqlQuery);

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "app_by_date");

            //Close db connection
            conn.Close();

            return ds;
        }




        public static void removeAppointment(String AppID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "UPDATE Appointments " +
                      "SET Status = '" + 'D' + "' " +
                      " WHERE AppointmentID = " + AppID;

            Debug.WriteLine("removeAppointment: " + SQLQuery);

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }



        //record payment by changing status to 'P'
        public static void recordPay(String AppID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "UPDATE Appointments " +
                      "SET Status = '" + 'P' + "' " +
                      " WHERE AppointmentID = " + AppID;

            Debug.WriteLine("removeAppointment: " + SQLQuery);

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }



        //update cost value of appointment
        public static void updateCost(String AppID, double Cost)
        {
            String Cost_str = Cost.ToString();
            Cost_str = Cost_str.Replace(',', '.');


            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "UPDATE Appointments SET Cost = " + Cost_str + " WHERE AppointmentID = " + AppID;

            Debug.WriteLine("updateCost: " + SQLQuery);

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }



    }
}
