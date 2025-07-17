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
    public partial class frmRemovePart : Form
    {

        frmMainMenu frmMainMenu = new frmMainMenu();

        String partID;

        public frmRemovePart()
        {
            InitializeComponent();
        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        //Menu Settings
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
            //Validate data

            for (int i = 0; i < txtType.Text.Length; i++)
            {
                char currentChar = txtType.Text[i];
                if (!((currentChar >= 'a' && currentChar <= 'z') || (currentChar >= 'A' && currentChar <= 'Z')))
                {
                    MessageBox.Show("Part Type must consist only of letters.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtType.Clear(); //clear field with error
                    txtType.Focus(); //focus to field
                    return;
                }
            }

            for (int i = 0; i < txtPartId.Text.Length; i++)
            {
                char currentChar = txtPartId.Text[i];
                if (!(currentChar >= '0' && currentChar <= '9'))
                {
                    MessageBox.Show("PartID must consist only of digits.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtPartId.Clear(); //clear field with error
                    txtPartId.Focus(); //focus to field
                    return;
                }
            }

            //At least one field
            if ((string.IsNullOrEmpty(txtPartId.Text)) && (string.IsNullOrEmpty(txtCompatibility.Text)) && (string.IsNullOrEmpty(txtType.Text)))
            {
                MessageBox.Show("At Least one filed must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //Retrieve data from File

            grpPartsList.Visible = true;

            LoadPartsIntoComboBox();
        }

        // Method to load clients into the ComboBox
        private void LoadPartsIntoComboBox()
        {

            DataSet ds = Parts.getParts(txtPartId.Text.ToLower(), txtType.Text.Trim().ToLower(), txtCompatibility.Text.ToLower());

            // Clear existing items
            lsbRemovePart.Items.Clear();

            // Loop through the rows in the "parts" DataTable
            foreach (DataRow row in ds.Tables["parts"].Rows)
            {
                // Create a string with the parts's info
                string partName = row["PartID"].ToString() + " " + row["Type"].ToString() + " " + row["Compatibility"].ToString() + " " + row["Supplier"].ToString() + " " + row["Quantity"].ToString();

                // Add the client name to the ComboBox
                lsbRemovePart.Items.Add(partName);
            }
        }

        private void lsbRemovePart_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveSelectedPart.Visible = true;
        }

        private void btnRemoveSelectedPart_Click(object sender, EventArgs e)
        {

            //Display conformation message
            MessageBox.Show("Part successfuly deleted!", "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Reset the UI
            txtPartId.Clear();
            txtType.Clear();
            txtCompatibility.Clear();

            grpPartsList.Visible = false;
            btnRemoveSelectedPart.Visible = false;

            //sql remove code
            partID = lsbRemovePart.Text.Substring(0, 3);

            Parts.removePart(partID);
        }

        private void frmRemovePart_Load(object sender, EventArgs e)
        {

        }
    }
}
