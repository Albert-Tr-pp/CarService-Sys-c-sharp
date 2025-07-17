using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarService
{
    public partial class frmMakeBooking : Form
    {
        frmMainMenu frmMainMenu = new frmMainMenu();

        String takenTimeStr = "";

        public frmMakeBooking()
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

        private void lsbRemovePart_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpDate.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            lsbTime.Items.Clear();

            grpTime.Visible = true;

            putAvailableTime();
        }

        private void putAvailableTime()
        {

            takenTimeStr = String.Format("{0:dd-MM-yyyy}", dtpDate.Value);
            Debug.WriteLine(takenTimeStr);

            DataSet takenTimeDS = Appointments.getAvailableTime(takenTimeStr);

            // Loop through the rows in the "times" DataTable
            foreach (DataRow row in takenTimeDS.Tables["times"].Rows)
            {
                //takenTimesArr.Add(row["App_Time"].ToString());
                lsbTime.Items.Add(row["Time"].ToString());
            }
        }

        private void frmMakeBooking_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Validate Data

            //Client's Surname
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Client Last name Must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtLastName.Clear(); //clear field with error
                txtLastName.Focus(); //focus to field
                return;
            }

            if (Convert.ToDouble(txtLastName.Text.Length) > 20)
            {
                MessageBox.Show("Client Last Name must have max size of 20",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtLastName.Clear(); //clear field with error
                txtLastName.Focus(); //focus to field
                return;
            }

            for (int i = 0; i < txtLastName.Text.Length; i++)
            {
                char currentChar = txtLastName.Text[i];
                if (!((currentChar >= 'a' && currentChar <= 'z') || (currentChar >= 'A' && currentChar <= 'Z')))
                {
                    MessageBox.Show("Client Last Name must consist only of letters.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtLastName.Clear(); //clear field with error
                    txtLastName.Focus(); //focus to field
                    return;
                }
            }

            grpClientsList.Visible = true;

            LoadClientsIntoComboBox();
        }

        // Method to load clients into the ComboBox
        private void LoadClientsIntoComboBox()
        {
            // Get the DataSet from your database method
            // Trim user input and check if first letter is upper case
            String name = txtLastName.Text.Trim();


            if (name.ToLower() == "all")
            {
                name = "%";
            }
            else
            {
                name += '%';
            }

            //name = "";
            DataSet ds = Clients.getClientsByName(name);

            // Clear existing items
            lsbClientsList.Items.Clear();

            // Loop through the rows in the "clients" DataTable
            foreach (DataRow row in ds.Tables["clients"].Rows)
            {
                // Create a string with the client's FirstName and LastName
                string clientName = row["ClientID"].ToString() + " " + row["FirstName"].ToString() + " " + row["LastName"].ToString() + " " + row["Phone"].ToString();

                // Add the client name to the ComboBox
                lsbClientsList.Items.Add(clientName);
            }
        }

        private void grpSearchClient_Enter(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           btnMakeBooking.Visible = true;
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            //create record

            String clientID = lsbClientsList.Text.Substring(0, 3);
            String time = lsbTime.Text;

            Appointments appointment = new Appointments(Int32.Parse(clientID), takenTimeStr, time, 0.0);
            appointment.AddAppointment();

            //Display conformation message
            MessageBox.Show("Appointment successfuly created!", "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Reset the UI
            txtLastName.Clear();

            grpClientsList.Visible = false;
            grpDate.Visible = false;
            grpTime.Visible = false;
            btnMakeBooking.Visible = false;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
