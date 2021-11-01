using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEAManager
{
    public partial class AdminMainMenuForm : Form
    {
        private ReportController reportController;
        public AdminMainMenuForm()
        {
            InitializeComponent();
        }

        public static void loadForm(Form previousForm)
        {
            AdminMainMenuForm frmAdminMenu = new AdminMainMenuForm();
            frmAdminMenu.preliminaryActions();
            previousForm.Visible = false;
            frmAdminMenu.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        public static void loadForm(LoginForm previousForm)
        {
            AdminMainMenuForm frmAdminMenu = new AdminMainMenuForm();
            frmAdminMenu.preliminaryActions();
            previousForm.Visible = false;
            frmAdminMenu.ShowDialog(previousForm);
            previousForm.preliminaryActions();
            previousForm.Visible = true;
        }

        public void preliminaryActions()
        {
            reportController = new ReportController(lblNoSupervisors, lblNoReviewers, lblNoStudents, lblReviewerWithMostApplications, lblReviewerWithLeastApplications, lblNoRejected, lblNoPending, lblNoGranted, lblNoEthics, lblNoWaiver, lblNoApplications, pnlReviewers, cbbMothYear);
            reportController.gererateDefultReport();
        }

        private void btnManageReviewers_Click(object sender, EventArgs e)
        {
            // load reviewers

            ManageRevierwerForm.loadForm(this);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageApplications_Click(object sender, EventArgs e)
        {
            // load applications

            ManageApplicationForm.loadForm(this);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            bool generatedReport = reportController.generateSpecificReport();
            if (generatedReport)
            {
                CommonMethods.myConfirmationMessageBox("Report Successfully generated for " + cbbMothYear.Text);
            }
            else
            {
                MessageBox.Show("There was an error in this report generation, please try again later", "Report Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
