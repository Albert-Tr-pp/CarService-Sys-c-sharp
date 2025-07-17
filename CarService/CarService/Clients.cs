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
using System.Diagnostics;

namespace CarService
{
    internal class Clients
    {
        private int ClientID;
        private string Firstname;
        private string Lastname;
        private string Phone;
        private string Email;
        private string County;
        private string City;
        private string Street;
        private string AirCode;
        private char Status;

        public static int counter = 100;

        public Clients()
        {
            this.ClientID = 0;
            this.Firstname = null;
            this.Lastname = null;
            this.Phone = null;
            this.Email = null;
            this.County = null;
            this.City = null;
            this.Street = null;
            this.AirCode = null;
            this.Status = 'R';
        }

        public Clients(string Firstname, string Lastname, string Phone, string Email, string County, string City, string Street, string AirCode)
        {
            setClientID(ClientID);
            setFirstname(Firstname);
            setLastname(Lastname);
            setPhone(Phone);
            setEmail(Email);
            setCounty(County);
            setCity(City);
            setStreet(Street);
            setAirCode(AirCode);
            setStatus('R');
        }

        //getters & setters

        //getters
        public int getClientID() { return this.ClientID; }
        public string getFirstname() { return this.Firstname; }
        public string getLastname() { return this.Lastname; }
        public string getPhone() { return this.Phone; }
        public string getEmail() { return this.Email; }
        public string getCounty() { return this.County; }
        public string getCity() { return this.City; }
        public string getStreet() { return this.Street; }
        public string getAirCode() { return this.AirCode; }
        public char getStatus() { return this.Status; }

        //setters
        public void setClientID(int ID) {
            //get highest id and increment it : if no clients in DB = use value 100
            counter = getMaxID();
            if (counter != 0)
            {
                this.ClientID = counter + 1;
            }
            else {
                this.ClientID = 100;
            }
        }
        public void setFirstname(String Firstname) { this.Firstname = Firstname; }
        public void setLastname(String Lastname) { this.Lastname = Lastname; }
        public void setPhone(String Phone) { this.Phone = Phone; }
        public void setEmail(String Email) { this.Email = Email; }
        public void setCounty(String County) { this.County = County; }
        public void setCity(String City) { this.City = City; }
        public void setStreet(String Street) { this.Street = Street; }
        public void setAirCode(String AirCode) { this.AirCode = AirCode; }
        public void setStatus(char Status) { this.Status = Status; }


        //method to get maximum id value
        public static int getMaxID() {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(clientID) FROM Clients";

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

        //method to retrieve all clients
        public static DataSet getAllClients()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
            "FROM Clients ORDER BY FirstName";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "clients");

            //Close db connection
            conn.Close();

            return ds;
        }

        //Method to retrieve clients info by Firstname
        public static DataSet getClientsByName(String name)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
            "FROM Clients WHERE Lastname LIKE '" + name + "' AND status = 'R' ORDER BY FirstName";

            Debug.WriteLine(sqlQuery);

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "clients");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet getClientsByNameWithApp(String name)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
            "FROM Clients WHERE Lastname LIKE '" + name + "'AND ClientID IN (SELECT ClientID FROM Appointments) AND status = 'R' ORDER BY FirstName";

            Debug.WriteLine(sqlQuery);

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "clients");

            //Close db connection
            conn.Close();

            return ds;
        }


        public static DataSet getClientsByNameWithAppAndCost(String name)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
            "FROM Clients WHERE Lastname LIKE '" + name + "'AND ClientID IN (SELECT ClientID FROM Appointments) AND status = 'R' ORDER BY FirstName";

            Debug.WriteLine("getClientsByNameWithAppAndCost: " + sqlQuery);

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "clients");

            //Close db connection
            conn.Close();

            return ds;
        }



        //method to retrieve client by ClientID
        public static DataSet getClientsByID(String id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * " +
            "FROM Clients WHERE ClientID = " + id + " ORDER BY FirstName";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "client");

            //Close db connection
            conn.Close();

            return ds;
        }


        //register client
        public void registerClient()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "INSERT INTO Clients VALUES (" + ClientID + ", '" + Firstname + "', '" + Lastname + "', '" + Phone + "', '" + Email + "', '" + County + "','" + City + "', '" + Street + "', '" + AirCode + "', '" + Status + "')";

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }



        //update client info method
        public static void updateClient(String Firstname, String Lastname, String Phone, String Email, String County, String City, String Street, String AirCode, String ClientID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "UPDATE Clients " +
                      "SET Firstname = '" + Firstname + "', " +
                          "Lastname = '" + Lastname + "', " +
                          "Phone = '" + Phone + "', " +
                          "Email = '" + Email + "', " +
                          "County = '" + County + "', " +
                          "City = '" + City + "', " +
                          "Street = '" + Street + "', " +
                          "AirCode = '" + AirCode + "' " +
                      " WHERE ClientID = " + ClientID;

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void deregisterClient(String ClientID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "UPDATE Clients " +
                      "SET Status = '" + 'D' + "' " +
                      " WHERE ClientID = " + ClientID;

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }


        //existance validation for user input
        //email
        public static bool emailExists(String email)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "SELECT COUNT(*) FROM Clients WHERE Email = :email";

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);
            cmd.Parameters.Add("email", email);

            conn.Open();

            //cmd.ExecuteNonQuery();
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return result > 0;
        }


        //phone
        public static bool phoneExists(String phone)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string SQLQuery = "SELECT COUNT(*) FROM Clients WHERE Phone = :phone";

            OracleCommand cmd = new OracleCommand(SQLQuery, conn);
            cmd.Parameters.Add("phone", phone);

            conn.Open();

            //cmd.ExecuteNonQuery();
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return result > 0;
        }







    }
}
