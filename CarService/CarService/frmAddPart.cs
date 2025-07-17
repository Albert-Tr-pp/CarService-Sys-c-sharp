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
    public partial class frmAddPart : Form
    {

        frmMainMenu frmMainMenu = new frmMainMenu();

        public frmAddPart()
        {
            InitializeComponent();
        }

        private void frmAddPart_Load(object sender, EventArgs e)
        {

        }

        private void grpUpdateClient_Enter(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
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

        private void btnAppPart_Click(object sender, EventArgs e)
        {
            //Validate data

            //Type 
            if (string.IsNullOrEmpty(txtType.Text))
            {
                MessageBox.Show("Part Type must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtType.Clear(); //clear field with error
                txtType.Focus(); //focus to field
                return;
            }

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

            //Compatibility
            if (string.IsNullOrEmpty(txtCompatibility.Text))
            {
                MessageBox.Show("Part Compatibility must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCompatibility.Clear(); //clear field with error
                txtCompatibility.Focus(); //focus to field
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

            //Save data
            Parts part = new Parts(txtType.Text, txtCompatibility.Text, txtSupplier.Text, txtManufacturer.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text));

            part.AddPart();

            //Display conformation message
            MessageBox.Show("Part Information successfuly update!", "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Reset the UI
            txtType.Clear();
            txtCompatibility.Clear();
            txtSupplier.Clear();
            txtManufacturer.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();

        }

    }
}
