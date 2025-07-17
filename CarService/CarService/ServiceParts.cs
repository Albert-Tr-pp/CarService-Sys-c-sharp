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
using System.Diagnostics;
using System.IO.Ports;

namespace CarService
{
    internal class ServiceParts
    {
        private int AppointmentID;
        private int PartID;
        //private int Quantity;

        public ServiceParts()
        {
            this.AppointmentID = 0;
            this.PartID = 0;
        }

        public ServiceParts(int AppointmentID, int PartID)
        {
            setAppointmentID(AppointmentID);
            setPartID(PartID);

        }

        //getters & setters

        //getters
        public int getAppointmentID() { return this.AppointmentID; }

        public int getPartID() { return this.PartID; }


        //setters
        public void setAppointmentID(int AppointmentID) { this.AppointmentID = AppointmentID; }

        public void setPartID(int PartID) { this.PartID = PartID; }

        

        //method to add record to file
        public void AddRecord()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "INSERT INTO ServiceParts VALUES (" + AppointmentID + ", " + PartID + ")";

            Debug.WriteLine("AddRecord ireration: " + SQLQuery);

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }




    }
}
