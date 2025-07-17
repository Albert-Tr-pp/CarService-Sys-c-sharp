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
    public partial class frmUpdatePart : Form
    {

        frmMainMenu frmMainMenu = new frmMainMenu();

        DataSet partInfoToUpdate;

        String partID;

        public frmUpdatePart()
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

        private void frmUpdatePart_Load(object sender, EventArgs e)
        {

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
                // Create a string with the part's info
                string partName = row["PartID"].ToString() + " " + row["Type"].ToString() + " " + row["Compatibility"].ToString() + " " + row["Supplier"].ToString() + " " + row["Quantity"].ToString();

                // Add the client name to the ComboBox
                lsbRemovePart.Items.Add(partName);
            }
        }

        private void lsbRemovePart_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpUpdatePart.Visible = true;
            btnUpdatePart.Visible = true;

            //put data to update grp
            putInfoForUpdate();
        }

        private void putInfoForUpdate()
        {
            partID = lsbRemovePart.Text.Substring(0, 3);

            partInfoToUpdate = Parts.getPartByID(partID);

            // Loop through the rows in the "client" DataTable
            foreach (DataRow row in partInfoToUpdate.Tables["part"].Rows)
            {

                txtType_to_update.Text = row["Type"].ToString();
                txtCompatibility_to_update.Text = row["Compatibility"].ToString();
                txtSupplier.Text = row["Supplier"].ToString();
                txtManufacturer.Text = row["Manufacturer"].ToString();

                txtQuantity.Text = row["Quantity"].ToString();
                txtPrice.Text = row["Price"].ToString();

            }
        }

        private void grpUpdatePart_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdatePart_Click(object sender, EventArgs e)
        {
            //Validate data

            //Type 
            if (string.IsNullOrEmpty(txtType_to_update.Text))
            {
                MessageBox.Show("Part Type must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtType_to_update.Clear(); //clear field with error
                txtType_to_update.Focus(); //focus to field
                return;
            }

            for (int i = 0; i < txtType_to_update.Text.Length; i++)
            {
                char currentChar = txtType_to_update.Text[i];
                if (!((currentChar >= 'a' && currentChar <= 'z') || (currentChar >= 'A' && currentChar <= 'Z') || currentChar == ' '))
                {
                    MessageBox.Show("Part Type must consist only of letters.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtType_to_update.Clear(); //clear field with error
                    txtType_to_update.Focus(); //focus to field
                    return;
                }
            }

            //Compatibility
            if (string.IsNullOrEmpty(txtCompatibility_to_update.Text))
            {
                MessageBox.Show("Part Compatibility must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCompatibility_to_update.Clear(); //clear field with error
                txtCompatibility_to_update.Focus(); //focus to field
                return;
            }

            //Supplier
            if (string.IsNullOrEmpty(txtSupplier.Text))
            {
                MessageBox.Show("Part Supplier must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtSupplier.Clear(); //clear field with error
                txtSupplier.Focus(); //focus to field
                return;
            }

            //Manufacturer
            if (string.IsNullOrEmpty(txtManufacturer.Text))
            {
                MessageBox.Show("Part Manufacturer must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtManufacturer.Clear(); //clear field with error
                txtManufacturer.Focus(); //focus to field
                return;
            }

            //Quantity
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Part Quantity must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtQuantity.Clear(); //clear field with error
                txtQuantity.Focus(); //focus to field
                return;
            }

            for (int i = 0; i < txtQuantity.Text.Length; i++)
            {
                char currentChar = txtQuantity.Text[i];
                if (!(currentChar >= '0' && currentChar <= '9'))
                {
                    MessageBox.Show("Part Quantity must consist only of digits.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtQuantity.Clear(); //clear field with error
                    txtQuantity.Focus(); //focus to field
                    return;
                }
            }

            //Price
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Part Price must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrice.Clear(); //clear field with error
                txtPrice.Focus(); //focus to field
                return;
            }

            for (int i = 0; i < txtPrice.Text.Length; i++)
            {
                char currentChar = txtPrice.Text[i];
                if (((currentChar >= 'a' && currentChar <= 'z') || (currentChar >= 'A' && currentChar <= 'Z')))
                {
                    MessageBox.Show("Part Price must consist only of digits.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtPrice.Clear(); //clear field with error
                    txtPrice.Focus(); //focus to field
                    return;
                }
            }

            //Update data
            Parts.updatePart(txtType_to_update.Text, txtCompatibility_to_update.Text, txtSupplier.Text, txtManufacturer.Text, txtQuantity.Text, txtPrice.Text, partID);

            //Display conformation message
            MessageBox.Show("Part Information successfuly update!", "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Reset the UI
            txtPartId.Clear();
            txtType_to_update.Clear();
            txtCompatibility_to_update.Clear();
            txtType.Clear();
            txtCompatibility.Clear();
            txtSupplier.Clear();
            txtManufacturer.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();

            lsbRemovePart.Visible = false;
            grpUpdatePart.Visible = false;
            btnUpdatePart.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_info_about_all_Click(object sender, EventArgs e)
        {

        }
    }
}
