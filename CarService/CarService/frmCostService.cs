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
    public partial class frmCostService : Form
    {
        frmMainMenu frmMainMenu = new frmMainMenu();

        String appointmentID;
        String partID;
        double totalCost = 0;

        public frmCostService()
        {
            InitializeComponent();
        }

        private void frmCostService_Load(object sender, EventArgs e)
        {

        }

        private void grpDate_Enter(object sender, EventArgs e)
        {

        }

        private void grpAppointmentList_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            grpAppointmentList.Visible = true;

            putAppointments();

            //clear lsbPartsUsed
            lsbPartsUsed.Items.Clear();

            //reset total
            totalCost = 0;

            txtTotal.Text = totalCost.ToString();


        }

        private void putAppointments ()
        {
            string date_from_picker = String.Format("{0:dd-MM-yyyy}", dtpDate.Value);
            Debug.WriteLine(date_from_picker);

            DataSet appointments_for_date = Appointments.getAppointmentsByDate(date_from_picker);

            // Clear existing items
            lsbAppointmentsList.Items.Clear();

            // Loop through the rows in the "clients" DataTable
            foreach (DataRow row in appointments_for_date.Tables["app_by_date"].Rows)
            {
                // Create a string with the client's FirstName and LastName
                string Apps = row["AppointmentID"].ToString() + " " + row["App_Date"].ToString().Substring(0, row["App_Date"].ToString().Length - 8) + " " + row["App_Time"].ToString(); // + " " + row["Cost"].ToString();

                // Add the client name to the ComboBox
                lsbAppointmentsList.Items.Add(Apps);
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

            grpAddedParts.Visible = true;

            LoadPartsIntoComboBox();
        }

        // Method to load parts into the ComboBox
        private void LoadPartsIntoComboBox()
        {

            DataSet ds = Parts.getParts(txtPartId.Text.ToLower(), txtType.Text.Trim().ToLower(), txtCompatibility.Text.ToLower());

            // Clear existing items
            lsbPartsList.Items.Clear();

            // Loop through the rows in the "parts" DataTable
            foreach (DataRow row in ds.Tables["parts"].Rows)
            {
                // Create a string with the parts's info
                string partName = row["PartID"].ToString() + " " + row["Type"].ToString() + " " + row["Compatibility"].ToString() + " " + row["Supplier"].ToString() + " " + row["Quantity"].ToString();

                // Add the client name to the ComboBox
                lsbPartsList.Items.Add(partName);
            }
        }

        private void lsbAppointmentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpSearchPart.Visible = true;

            appointmentID = lsbAppointmentsList.Text.Substring(0, 3);
            Debug.WriteLine("Selected Appointment ID is: " + appointmentID);
        }

        private void lsbPartsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddPart.Visible = true;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {

            //validate part to be selected

            Object selectedItem = lsbPartsList.SelectedItem;

            if (selectedItem == null)
            {
                MessageBox.Show("Part need to be selected",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                lsbPartsList.Focus();
                return;
            }

            //get selected partID
            partID = lsbPartsList.Text.Substring(0, 3);
            Debug.WriteLine("Selected Part ID is: " + partID);



            //update total price
            string part_price;

            DataSet part_price_ds = Parts.getPartPriceByID(partID);

            // Loop through the rows in the "clients" DataTable
            foreach (DataRow row in part_price_ds.Tables["part_price"].Rows)
            {

                part_price = row["Price"].ToString();

                totalCost += Double.Parse(part_price);
            }

            txtTotal.Text = totalCost.ToString();



            //update list
            string selectedPart = selectedItem.ToString();

            lsbPartsUsed.Items.Add(selectedPart);

            btnCostService.Visible = true;
        }


        private void btnRemovePart_Click(object sender, EventArgs e)
        {

            //validate part to be selected

            Object selectedItem = lsbPartsList.SelectedItem;

            if (selectedItem == null)
            {
                MessageBox.Show("Part need to be selected",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                lsbPartsList.Focus();
                return;
            }

            //get selected partID
            partID = lsbPartsList.Text.Substring(0, 3);
            Debug.WriteLine("Selected Part ID is: " + partID);




            if (lsbPartsUsed.Items.Cast<string>().Any(item => item.StartsWith(partID)))
            {

                //update total price
                string part_price;

                DataSet part_price_ds = Parts.getPartPriceByID(partID);

                // Loop through the rows in the "part_price" DataTable
                foreach (DataRow row in part_price_ds.Tables["part_price"].Rows)
                {

                    part_price = row["Price"].ToString();

                    totalCost -= Double.Parse(part_price);
                }

                txtTotal.Text = totalCost.ToString();




                //update list
                string selectedPart = selectedItem.ToString();

                lsbPartsUsed.Items.Remove(selectedPart);

                btnCostService.Visible = true;

            }

        }

        private void btnCostService_Click(object sender, EventArgs e)
        {
            //update cost of appointment
            Appointments.updateCost(appointmentID, totalCost);

            //update serviceParts file and increment usedTimes
            for (int i = 0; i < lsbPartsUsed.Items.Count; i++)
            {

                //create record for each part in ServiceParts File
                string part_info = lsbPartsUsed.Items[i].ToString();

                String partID_for_record = part_info.Substring(0, 3);

                ServiceParts record = new ServiceParts(Int32.Parse(appointmentID), Int32.Parse(partID_for_record));

                record.AddRecord();

                //increment userTimes for each part
                Parts.incrementUsedTimesByID(partID_for_record);
            }

            //Display conformation message
            MessageBox.Show("Prise for Appointment successfuly calculated!", "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Reset the UI
            txtPartId.Clear();
            txtCompatibility.Clear();
            txtType.Clear();

            grpAppointmentList.Visible = false;
            grpPartsList.Visible = false;
            grpSearchPart.Visible = false;
            grpAddedParts.Visible = false;
            btnCostService.Visible = false;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
