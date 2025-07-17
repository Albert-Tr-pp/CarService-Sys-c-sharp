using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using Oracle.ManagedDataAccess.Client;

namespace CarService
{
    public partial class frmUpdateClient : Form
    {

        DataSet clientInfoToUpdate;

        String clientID;

        frmMainMenu frmMainMenu = new frmMainMenu();

        public frmUpdateClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //Validate data

            //Show Client information
            grpClient.Visible = true;
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            //Validate data

            //Client's Forename
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Client First name Must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtFirstName.Clear(); //clear field with error
                txtFirstName.Focus(); //focus to field
                return;
            }

            if (Convert.ToDouble(txtFirstName.Text.Length) > 20)
            {
                MessageBox.Show("Client Last name must have max size of 20",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtFirstName.Clear(); //clear field with error
                txtFirstName.Focus(); //focus to field
                return;
            }

            for (int i = 0; i < txtFirstName.Text.Length; i++)
            {
                char currentChar = txtFirstName.Text[i];
                if (!((currentChar >= 'a' && currentChar <= 'z') || (currentChar >= 'A' && currentChar <= 'Z')))
                {
                    MessageBox.Show("Client First Name must consist only of letters.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtFirstName.Clear(); //clear field with error
                    txtFirstName.Focus(); //focus to field
                    return;
                }
            }

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

            //Client's Phone

            if (txtPhone.Text.Length != 13)
            {
                MessageBox.Show("Phone number must be 13 chars long",
                                   "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                txtPhone.Clear(); //clear field with error
                txtPhone.Focus(); //focus to field
                return;
            }


            if (!txtPhone.Text.StartsWith("+"))
            {
                MessageBox.Show("Phone number must start with '+'.",
                                   "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                txtPhone.Clear(); //clear field with error
                txtPhone.Focus(); //focus to field
                return;

            }

            if (!txtPhone.Text.Substring(1).All(char.IsDigit))
            {
                MessageBox.Show("Invalid format for the Phone! Error",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPhone.Clear(); //clear field with error
                txtPhone.Focus(); //focus to field
                return;
            }


            //Client's Email
            if (string.IsNullOrEmpty(txtEmailToUpdate.Text))
            {
                MessageBox.Show("Email must be entered!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                txtEmailToUpdate.Clear(); //clear field with error
                txtEmailToUpdate.Focus(); //focus to field
                return;
            }

            if (txtEmailToUpdate.Text.IndexOf('@') == -1)
            {
                MessageBox.Show("Email must contain '@' symbols",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmailToUpdate.Focus();
                return;
            }

            //no more than one @ in email
            if (txtEmailToUpdate.Text.Split('@').Length - 1 > 1)
            {
                MessageBox.Show("Email cannot contain more than one '@' symbols",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmailToUpdate.Focus();
                return;
            }

            if (txtEmailToUpdate.Text.IndexOf('.') == -1)
            {
                MessageBox.Show("Email must contain '.'",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmailToUpdate.Focus();
                return;
            }



            //Client's County
            if (string.IsNullOrEmpty(cboCounties.Text))
            {
                MessageBox.Show("Error - County must be entered!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                cboCounties.Focus(); //focus to field
                return;
            }

            //Client's City
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("Error - City must be entered!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                txtCity.Focus(); //focus to field
                return;
            }

            //Client's Street
            if (string.IsNullOrEmpty(txtStreet.Text))
            {
                MessageBox.Show("Error - City must be entered!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                txtStreet.Focus(); //focus to field
                return;
            }



            //Client's AirCode
            if (string.IsNullOrEmpty(txtAirCode.Text))
            {
                MessageBox.Show("Error - AirCode must be entered!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                txtAirCode.Focus(); //focus to field
                return;
            }

            //Save data
            Clients.updateClient(txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtEmailToUpdate.Text, cboCounties.Text.Trim(), txtCity.Text, txtStreet.Text, txtAirCode.Text, clientID);

            //Display conformation message
            MessageBox.Show("A Client updated succsessfuly.", "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Reset the UI
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmailToUpdate.Clear();
            cboCounties.SelectedIndex = -1;
            txtCity.Clear();
            txtStreet.Clear();
            txtAirCode.Clear();

            txtLastNameToSearch.Clear();

            //hide groups
            grpClient.Hide();
            grpClientsList.Hide();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
        }

        private void lsbClientsList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
        }

        private void lsbClientsList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            grpClient.Visible = true;

            //put data to update grp
            putInfoForUpdate();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            //Validate Data

            //Client's Surname
            if (string.IsNullOrEmpty(txtLastNameToSearch.Text))
            {
                MessageBox.Show("Client Last name Must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtLastNameToSearch.Clear(); //clear field with error
                txtLastNameToSearch.Focus(); //focus to field
                return;
            }

            if (Convert.ToDouble(txtLastNameToSearch.Text.Length) > 20)
            {
                MessageBox.Show("Client Last Name must have max size of 20",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtLastNameToSearch.Clear(); //clear field with error
                txtLastNameToSearch.Focus(); //focus to field
                return;
            }

            for (int i = 0; i < txtLastNameToSearch.Text.Length; i++)
            {
                char currentChar = txtLastNameToSearch.Text[i];
                if (!((currentChar >= 'a' && currentChar <= 'z') || (currentChar >= 'A' && currentChar <= 'Z')))
                {
                    MessageBox.Show("Client Last Name must consist only of letters.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtLastNameToSearch.Clear(); //clear field with error
                    txtLastNameToSearch.Focus(); //focus to field
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
            String name = txtLastNameToSearch.Text.Trim();


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

        private void putInfoForUpdate ()
        {
            clientID = lsbClientsList.Text.Substring(0, 3);

            clientInfoToUpdate = Clients.getClientsByID(clientID);

            // Loop through the rows in the "client" DataTable
            foreach (DataRow row in clientInfoToUpdate.Tables["client"].Rows)
            {
               
                txtFirstName.Text = row["FirstName"].ToString();
                txtLastName.Text = row["Lastname"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtEmailToUpdate.Text = row["Email"].ToString();

                cboCounties.DropDownStyle = ComboBoxStyle.Simple;
                cboCounties.Text = row["County"].ToString();
                cboCounties.DropDownStyle = ComboBoxStyle.DropDownList;


                txtCity.Text = row["City"].ToString();
                txtStreet.Text = row["Street"].ToString();
                txtAirCode.Text = row["AirCode"].ToString();

            }
        }

        private void grpClientsList_Enter(object sender, EventArgs e)
        {

        }

        private void grpClient_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
