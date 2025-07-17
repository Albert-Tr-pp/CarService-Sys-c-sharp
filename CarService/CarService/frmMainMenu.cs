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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void registerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterClient frmRegisterClient = new frmRegisterClient();

            this.Hide();
            frmRegisterClient.Show();
        }

        private void yearlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYearlyRevenueAnalysis frmYearlyRevenueAnalysis = new frmYearlyRevenueAnalysis();

            this.Hide();
            frmYearlyRevenueAnalysis.Show();
        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateClient frmUpdateClient = new frmUpdateClient();

            this.Hide();
            frmUpdateClient.Show();
        }

        private void deregisterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeregisterClient frmDeregisterClient = new frmDeregisterClient();

            this.Hide();
            frmDeregisterClient.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void addPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPart frmAddPart = new frmAddPart();

            this.Hide();
            frmAddPart.Show();
        }

        private void removePartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemovePart frmRemovePart = new frmRemovePart();

            this.Hide();
            frmRemovePart.Show();
        }

        private void updatePartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePart frmUpdatePart = new frmUpdatePart();

            this.Hide();
            frmUpdatePart.Show();
        }

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMakeBooking frmMakeBooking = new frmMakeBooking();

            this.Hide();
            frmMakeBooking.Show();
        }

        private void removeBookimgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveBooking frmRemoveBooking = new frmRemoveBooking();

            this.Hide();
            frmRemoveBooking.Show();
        }

        private void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecordPayment frmRecordPayment = new frmRecordPayment();

            this.Hide();
            frmRecordPayment.Show();
        }

        private void costServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCostService frmCostService = new frmCostService();

            this.Hide();
            frmCostService.Show();
        }

        private void frequentPartsRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFrequentPartsRevenueAnalysis frmFrequentPartsRevenueAnalysis = new frmFrequentPartsRevenueAnalysis();

            this.Hide();
            frmFrequentPartsRevenueAnalysis.Show();
        }
    }
}
