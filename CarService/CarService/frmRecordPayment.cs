using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarService
{
    public partial class frmRecordPayment : Form
    {
        frmMainMenu frmMainMenu = new frmMainMenu();

        DataSet AppointmentsToDelete;

        String clientID;

        String appointmentID;

        public frmRecordPayment()
        {
            InitializeComponent();
        }

        private void frmRecordPayment_Load(object sender, EventArgs e)
        {
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            grpAppointmentList.Visible = false;

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
        }

        private void lsbClientsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpAppointmentList.Visible = true;

            //put data to update grp
            putAppForDel();
        }


        private void putAppForDel()
        {
            clientID = lsbClientsList.Text.Substring(0, 3);

            AppointmentsToDelete = Appointments.getAppointmentsByClientID(clientID);

            // Clear existing items
            lsbAppointmentsList.Items.Clear();

            // Loop through the rows in the "clients" DataTable
            foreach (DataRow row in AppointmentsToDelete.Tables["appointments"].Rows)
            {
                // Create a string with the client's FirstName and LastName
                string Apps = row["AppointmentID"].ToString() + " " + row["App_Date"].ToString().Substring(0, row["App_Date"].ToString().Length - 8) + " " + row["App_Time"].ToString(); // + " " + row["Cost"].ToString();

                // Add the client name to the ComboBox
                lsbAppointmentsList.Items.Add(Apps);
            }

        }


        private void btnRemoveBooking_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            grpAppointmentList.Visible= true;
        }

        private void lsbAppointmentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPaid.Visible = true;
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            //Validate data

            appointmentID = lsbAppointmentsList.Text.Substring(0, 3);

            Appointments.recordPay(appointmentID);

            //Display conformation message
            MessageBox.Show("Appointment successfuly paid!", "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Reset the UI
            txtLastName.Clear();

            grpClientsList.Visible = false;
            grpAppointmentList.Visible = false;
            btnPaid.Visible = false;
        }

        private void btnFind_Click_1(object sender, EventArgs e)
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
            DataSet ds = Clients.getClientsByNameWithAppAndCost(name);

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













    }
}
