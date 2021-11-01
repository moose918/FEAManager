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
            if (applicationAssignment != null)
            {
                applicationAssignment.viewReviewer(pnlApplicationView, pnlReviewerProfile, lsbReviewers.SelectedIndex, lblReviewerNumber,
                                                lblFirstName, lblLastName, lblQualificationLevel, lblDateOfBirth, lblTelephoneNumber,
                                                lblEmail);
                CommonMethods.myErrorMessageBox("Reviewer " + lsbReviewers.SelectedItem.ToString() + " has been selected to view");
            }
            else
            {
                CommonMethods.myErrorMessageBox("Plaese select an application");
            }
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            bool[] worked = { false };
            applicationAssignment = new ApplicationAssignment(grpStatus, btnViewReviwerProfile, lblSelectedApplicationNumber, btnModify, lblSelectedReviewerOne, lblSelectedReviewerTwo, lsbApplications.SelectedIndex, worked);
            if (!worked[0])
            {
                applicationAssignment = null;
            }
            else
            {
                btnViewApplication.PerformClick();
            }
        }

        private void btnViewApplication_Click(object sender, EventArgs e)
        {
            if (applicationAssignment != null)
            {
                applicationAssignment.viewApplication(pnlReviewerProfile, pnlApplicationView, lsbApplications.SelectedIndex, lblApplicationNumbers, lblAdminFullName,
                                                        lblApplicationType, lblStudyProgram, lblCollectingData, lblRiskCategory, lblStatus,
                                                        lblStudentNumber, lblStudentFullName, lblSupervisor, lblDateCompleted);
                CommonMethods.myConfirmationMessageBox("Application for " + lsbApplications.SelectedItem.ToString() + " has been selected to view");
            }
            else
            {
                CommonMethods.myErrorMessageBox("Plaese select an application");
            }

        }

        private void btnSelectReviewer_Click(object sender, EventArgs e)
        {
            if (applicationAssignment != null)
            {
                applicationAssignment.addReviewerToApplication(lsbReviewers.SelectedIndex);
            }
            else
            {
                CommonMethods.myErrorMessageBox("Plaese select an application");
            }
        }

        private void btnRemoveReviewerOne_Click(object sender, EventArgs e)
        {
            if (applicationAssignment != null)
            {
                applicationAssignment.removeReviewerOne(lblSelectedReviewerOne);
            }
            else
            {
                CommonMethods.myErrorMessageBox("Plaese select an application");
            }
        }

        private void btnRemoveReviewerTwo_Click(object sender, EventArgs e)
        {
            if (applicationAssignment != null)
            {
                applicationAssignment.removeReviewerOne(lblSelectedReviewerTwo);
            }
            else
            {
                CommonMethods.myErrorMessageBox("Plaese select an application");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (applicationAssignment != null)
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
                    else
                    {
                        CommonMethods.myConfirmationMessageBox("Unsuccesful Application Assignment Creation");
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
                    else
                    {
                        CommonMethods.myConfirmationMessageBox("Unsuccesful Application Assignment Update");
                    }
                }
            }
            else
            {
                CommonMethods.myErrorMessageBox("Plaese select an application");
            }
        }

        private void ManageApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (applicationAssignment != null)
            {
                applicationAssignment.reset();
                applicationAssignment = null;
            }

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
