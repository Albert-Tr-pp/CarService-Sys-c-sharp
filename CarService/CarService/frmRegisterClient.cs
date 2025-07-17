using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarService
{
    public partial class frmRegisterClient : Form
    {

        frmMainMenu frmMainMenu = new frmMainMenu();


        public frmRegisterClient()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
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

            // phone existance check
            if (Clients.phoneExists(txtPhone.Text))
            {
                MessageBox.Show("This phone already exists in the CarSerive System!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }




            //Client's Email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Error - Email must be entered!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                txtEmail.Clear(); //clear field with error
                txtEmail.Focus(); //focus to field
                return;
            }

            if (txtEmail.Text.IndexOf('@') == -1)
            {
                MessageBox.Show("Email must contain '@' symbols",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            //no more than one @ in email
            if (txtEmail.Text.Split('@').Length - 1 > 1)
            {
                MessageBox.Show("Email cannot contain more than one '@' symbols",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (txtEmail.Text.IndexOf('.') == -1)
            {
                MessageBox.Show("Email must contain '.'",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // emaill existance check
            if (Clients.emailExists(txtEmail.Text))
            {
                MessageBox.Show("This email already exists in the CarSerive System!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmail.Focus();
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
            Clients clients = new Clients(txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtEmail.Text, cboCounties.Text.Trim(), txtCity.Text, txtStreet.Text, txtAirCode.Text);

            clients.registerClient();

            //Display conformation message
            MessageBox.Show("A new Client was added in the system.", "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Reset the UI
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cboCounties.SelectedIndex = -1;
            txtCity.Clear();
            txtStreet.Clear();
            txtAirCode.Clear();

        }
        private void cboCounties_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmRegisterClient_Load(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
