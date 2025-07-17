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
    internal class Parts
    {
        private int PartID;
        private string Type;
        private string Compatibility;
        private string Supplier;
        private string Manufacturer;
        private int Quantity;
        private double Price;
        private int usedTimes;
        private char Status;

        public static int counter = 100;

        public Parts()
        {
            this.PartID = 0;
            this.Type = null;
            this.Compatibility = null;
            this.Supplier = null;
            this.Manufacturer = null;
            this.Quantity = 0;
            this.Price = 0;
            this.usedTimes = 0;
            this.Status = 'R';
        }

        public Parts(string Type, string Compatibility, string Supplier, string Manufacturer, int Quantity, double Price)
        {
            setPartID(getMaxID());
            setType(Type);
            setCompatibility(Compatibility);
            setSupplier(Supplier);
            setManufacturer(Manufacturer);
            setQuantity(Quantity);
            setPrice(Price);
            setUsedTimes(0);
            setStatus('R');
        }

        //getters & setters

        //getters
        public int getPartID() { return this.PartID; }
        public string getType() { return this.Type; }
        public string getCompatibility() { return this.Compatibility; }
        public string getSupplier() { return this.Supplier; }
        public string getManufacturer() { return this.Manufacturer; }
        public int getQuantity() { return this.Quantity; }
        public double getPrice() { return this.Price; }
        public int getUsedTimes() { return this.usedTimes; }
        public char getStatus() { return this.Status; }

        //setters
        public void setPartID(int ID) {

            //Get highest id and increment it : if no clients in DB = use value 100

            if (ID != 0)
            {
                this.PartID = ID + 1;
            }
            else {
                this.PartID = 100;
            }
        }
        public void setType(String Type) { this.Type = Type; }
        public void setCompatibility(String Compatibility) { this.Compatibility = Compatibility; }
        public void setSupplier(String Supplier) { this.Supplier = Supplier; }
        public void setManufacturer(String Manufacturer) { this.Manufacturer = Manufacturer; }
        public void setQuantity(int Quantity) { this.Quantity = Quantity; }
        public void setPrice(double Price) { this.Price = Price; }
        public void setUsedTimes(int usedTimes) { this.usedTimes = usedTimes; }
        public void setStatus(char Status) { this.Status = Status; }


        //method to maximum id value
        public static int getMaxID() {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(PartID) FROM Parts";

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

        //add part
        public void AddPart()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "INSERT INTO Parts VALUES (" + PartID + ", '" + Type + "', '" + Compatibility + "', '" + Supplier + "', '" + Manufacturer + "', '" + Quantity + "','" + Price + "', '" + usedTimes + "', '" + Status + "')";

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }





        //method to retrieve part info by partID, type or quantity
        public static DataSet getParts(string id, string type, string comp)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            //code to check which field entered
            String sqlInner = "";

            if (!string.IsNullOrEmpty(id.ToString()))
            {

                sqlInner += "PartId = '" + id + "'";
            }

            if (!string.IsNullOrEmpty(type.ToString()))
            {
                if (type.ToLower() == "all")
                {
                    type = "";
                }

                if (!string.IsNullOrEmpty(id.ToString()))
                {
                    sqlInner += " AND ";
                }
                sqlInner += "LOWER(Type) LIKE '" + type + "%'";
            }

            if (!string.IsNullOrEmpty(comp.ToString()))
            {
                if (comp.ToLower() == "all")
                {
                    comp = "";
                }

                if (!string.IsNullOrEmpty(type.ToString()) || !string.IsNullOrEmpty(id.ToString()))
                {
                    sqlInner += " AND ";
                }

                sqlInner += "LOWER(Compatibility) LIKE '" + comp + "%'";
            }

            else
            {
                
            }

            String sqlQuery = "SELECT * " + "FROM Parts WHERE " + sqlInner + " AND status = 'R' ORDER BY Type";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "parts");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static void removePart(String partID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "UPDATE Parts " +
                      "SET Status = '" + 'D' + "' " +
                      " WHERE PartID = " + partID;

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Method to retrieve client by ClientID
        public static DataSet getPartByID(String id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
            "FROM Parts WHERE partID = " + id + " ORDER BY Type";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "part");

            //Close db connection
            conn.Close();

            return ds;
        }


        //update part info method
        public static void updatePart(String Type, String Compatibility, String Supplier, String Manufacturer, String Quantity, String Price, String partID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "UPDATE Parts " +
                      "SET Type = '" + Type + "', " +
                          "Compatibility = '" + Compatibility + "', " +
                          "Supplier = '" + Supplier + "', " +
                          "Manufacturer = '" + Manufacturer + "', " +
                          "Quantity = " + Quantity + ", " +
                          "Price = " + Price +
                      " WHERE PartID = " + partID;

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }



        //method to retrieve Price of Part by PartID
        public static DataSet getPartPriceByID(String id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT Price FROM Parts WHERE partID = " + id;

            Debug.WriteLine("sql smt form - getPartPriceByID: " + sqlQuery);

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "part_price");

            //Close db connection
            conn.Close();

            return ds;
        }



        //Method to increment usedTimes of Part by PartID
        public static void incrementUsedTimesByID(String id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Parts SET usedTimes = usedTimes + 1 WHERE PartID = " + id;

            Debug.WriteLine("sql smt form - incrementUsedTimesByID: " + sqlQuery);

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }



    }
}
