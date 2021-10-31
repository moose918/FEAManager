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
    public partial class ManageApplicationForm : Form
    {
        private ApplicationAssignment applicationAssignment;

        public ManageApplicationForm()
        {
            InitializeComponent();
        }
        public static void loadForm(Form previousForm)
        {
            ManageApplicationForm frmManageApplication = new ManageApplicationForm();
            ApplicationAssignment.loadDetails(frmManageApplication.lsbApplications, frmManageApplication.lsbReviewers);
            previousForm.Visible = false;
            frmManageApplication.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        public static void loadForm(AdminMainMenuForm previousForm)
        {
            ManageApplicationForm frmManageApplication = new ManageApplicationForm();
            frmManageApplication.loadDetails();
            previousForm.Visible = false;
            frmManageApplication.ShowDialog(previousForm);
            previousForm.preliminaryActions();
            previousForm.Visible = true;
        }

        private void loadDetails()
        {
            ApplicationAssignment.loadDetails(lsbApplications, lsbReviewers);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            /*this.DialogResult = DialogResult.OK;
            Close();*/
        }

        private void btnViewReviwerProfile_Click(object sender, EventArgs e)
        {
            applicationAssignment.viewReviewer(pnlApplicationView, pnlReviewerProfile, lsbReviewers.SelectedIndex, lblReviewerNumber,
                                                lblFirstName, lblLastName, lblQualificationLevel, lblDateOfBirth, lblTelephoneNumber,
                                                lblEmail);
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            applicationAssignment = new ApplicationAssignment(grpStatus, btnViewReviwerProfile, lblSelectedApplicationNumber, btnModify, lblSelectedReviewerOne, lblSelectedReviewerTwo, lsbApplications.SelectedIndex);
            btnViewApplication.PerformClick();
        }

        private void btnViewApplication_Click(object sender, EventArgs e)
        {
            applicationAssignment.viewApplication(pnlReviewerProfile, pnlApplicationView, lsbApplications.SelectedIndex, lblApplicationNumbers, lblAdminFullName,
                                                        lblApplicationType, lblStudyProgram, lblCollectingData, lblRiskCategory, lblStatus,
                                                        lblStudentNumber, lblStudentFullName, lblSupervisor, lblDateCompleted);
        }

        private void btnSelectReviewer_Click(object sender, EventArgs e)
        {
            applicationAssignment.addReviewerToApplication(lsbReviewers.SelectedIndex);
        }

        private void btnRemoveReviewerOne_Click(object sender, EventArgs e)
        {
            applicationAssignment.removeReviewerOne(lblSelectedReviewerOne);
        }

        private void btnRemoveReviewerTwo_Click(object sender, EventArgs e)
        {
            applicationAssignment.removeReviewerOne(lblSelectedReviewerTwo);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            bool create = btnModify.Text.Equals("&Modify");
            string action = (create) ? "updated" : "created";

            if (!create)
            {
                bool blnCreatedApplication = applicationAssignment.createApplicationAssignment();

                if (blnCreatedApplication)
                {
                    CommonMethods.myConfirmationMessageBox("Application: " + applicationAssignment.strApplicationNumber + " has sucessfully been " + action);
                    btnReset.PerformClick();
                }
            }
            else
            {
                bool blnUpdatedApplication = applicationAssignment.updateApplicationAssignment();

                if (blnUpdatedApplication)
                {
                    CommonMethods.myConfirmationMessageBox("Application: " + applicationAssignment.strApplicationNumber + " has sucessfully been " + action);
                    btnReset.PerformClick();
                }
            }
        }

        private void ManageApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            applicationAssignment.reset();

            pnlReviewerProfile.Visible = false;
            pnlApplicationView.Visible = true;

            foreach (Control control in pnlApplicationView.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    
                    if (!label.Name.Contains("label")) {
                        label.Text = CommonMethods.blankPlaceholder;
                    }
                }
            }

            foreach (Control control in pnlReviewerProfile.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    if (!label.Name.Contains("label"))
                    {
                        label.Text = CommonMethods.blankPlaceholder;
                    }
                }
            }

            foreach (Control control in grpStatus.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
            }

            lblSelectedApplicationNumber.Text = CommonMethods.blankPlaceholder;
            lblSelectedReviewerOne.Text = CommonMethods.blankPlaceholder;
            lblSelectedReviewerTwo.Text = CommonMethods.blankPlaceholder;
            lblApplicationNumbers.Text = "Application Number";
            lblReviewerNumber.Text = "Reviewer Number";
            CommonMethods.centraliseControlInContainer(lblApplicationNumbers, pnlApplicationView);
            CommonMethods.centraliseControlInContainer(lblReviewerNumber, pnlReviewerProfile);

            lsbApplications.SelectedIndex = -1;
            lsbReviewers.SelectedIndex = -1;
        }
    }
}
