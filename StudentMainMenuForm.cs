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
    public partial class StudentMainMenuForm : Form
    {
        private Student student;

        string strPassedStudentNumber;

        public StudentMainMenuForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbcStudentMenu.SelectedIndex == 0)
            {
                bool succesfulUpdate = student.updateStudent();
                if (succesfulUpdate)
                {
                    loadDetails(strPassedStudentNumber);
                }
            }
            else
            {
                bool createdApplication = student.createApplication();
                if (createdApplication)
                {
                    MessageBox.Show("Application " + student.strApplicationNumber + " has been created");
                }
            }
        }

        public static void loadForm(Form previousForm, String strStudentNumber)
        { 
            StudentMainMenuForm frmStudentMainMenu = new StudentMainMenuForm();
            frmStudentMainMenu.loadDetails(strStudentNumber);
            frmStudentMainMenu.strPassedStudentNumber = strStudentNumber;
            previousForm.Visible = false;
            frmStudentMainMenu.initializePanels();
            frmStudentMainMenu.setAdminName();
            frmStudentMainMenu.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        public static void loadForm(LoginForm previousForm, String strStudentNumber)
        {
            StudentMainMenuForm frmStudentMainMenu = new StudentMainMenuForm();
            frmStudentMainMenu.loadDetails(strStudentNumber);
            frmStudentMainMenu.strPassedStudentNumber= strStudentNumber;
            CommonMethods.getStudyPrograms(frmStudentMainMenu.cmbStudyProgram);
            previousForm.Visible = false;
            frmStudentMainMenu.initializePanels();
            frmStudentMainMenu.setAdminName();
            frmStudentMainMenu.ShowDialog(previousForm);
            previousForm.Visible = true;
            previousForm.preliminaryActions();
        }

        private void setAdminName()
        {
            String adminName = CommonMethods.getFullName(CommonMethods.getAdminNumber(), CommonMethods.typeAdmin);
            if (!adminName.Equals(""))
            {
                lblAdminName.Text = adminName;
            }
            else
            {
                lblAdminName.Text = CommonMethods.blankPlaceholder;
            }
        }
         
        private void initializePanels()
        {
            if (!radEthics.Checked && !radWaiver.Checked || radWaiver.Checked)
            {
                radWaiver.Checked = true;
                pnlEthics.Visible = false;
                pnlWaiver.Visible = true;
            }
            else
            {
                radEthics.Checked = true;
                pnlEthics.Visible = true;
                pnlWaiver.Visible = false;
            }
        }

        private void loadDetails(String strStudentNumber)
        {
            student = new Student(strStudentNumber, mtxtTelephone, mtxtPassword, mtxtEmail, txtStudentNumber, txtFName, txtLName, cmbStudyProgram, grpTitle, dtpDetailsDateOfBirth,
                       txtApplicationType, txtDetailsAdminNumber, txtApplicationNumber, radDetailsCollectingDataNo, radDetailsCollectingDataYes, gpbStatus, gpbRiskCategory, dtpDateCompleted,
                       btnCancelApplication, txtDetailsSupervisor, pnlCurrentApplication,

                       cmbSupervisorCellphone, cmbSupervisorEmail, cmbSupervisorFirstName, cmbSupervisorLastName,
                       radWaiverDegreePurposeOther, radNo, radDataReuseEthicsYes, radPermissionReuseEthicsYes, radEthicsDegreePruposeOther,
                       radRiskExposureYes, radVulnerableYes, radEthics, radReadRiskTableYes, radInvolveHumansYes, radrelationshipsYes, radWaiver,
                       clbdataDisposal, cblHowDataWillBeCollected,
                       txtWaiverOtherDegree, txtWaiverProjectTitle, txtEthicsOtherDegree, txtEthicsProjectTitle,
                       rtbAbstractSummary, rtbAimsAndObjectives, rtbDataProtectionDuringResearch, rtbAnonymityConfidentialityMethod, rtbParticipantSelectionMathods,
                       rtbResearchLocation, rtbExplainConflictResolution, rtbEthicsAbstractSummary,
                       rtbEthicsAimsAndObjectives, rtbAddressPotentialRisks, rtbAddressingVulnerabilities,

                       gpbApplicationType, gpbReadRiskTable, gpbInvolveHumans, gpbApplicationRiskCategory, gpbStudyProgram,
                       gpbCollectingData, gpbDegreeEthics, gpnVulnurableCategoriesEthics, gpbExperts,
                       gpbPermissionsEthicsIfYes, gpbPermissionsEthics, gpbFormalPermissionLocation, gpbPersonalConflictsEthics,
                       gpbAdditionalResearchersEthics, gpbConfirmation, gpbDegreeWaiver, rpbCollaborationWaiver,
                       gpbPermissionsWaiverIfYes, gpbPermissionsWaiver, gpbAnonymityResulting, gpbAnonymityProcess, gpbConfidentialityProcess,
                       gpbInformedConcentGatheringMethod, gpbIncentivesEthics);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            CommonMethods.passwordControl(mtxtPassword);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CommonMethods.clearForm(this, pnlCurrentApplication);
        }

        private void tbcStudentMenu_Click(object sender, EventArgs e)
        {
            if (tbcStudentMenu.SelectedIndex == 0)
            {
                btnModify.Text = "&Update";
            }
            else
            {
                btnModify.Text = "&Create";
            }
        }

        private void radEthics_CheckedChanged(object sender, EventArgs e)
        {
            initializePanels();
            radApplicationMediumRisk.Enabled = false;
            radApplicationMediumRisk.Checked = false;

            radApplicationhighRisk.Enabled = false;
            radApplicationhighRisk.Checked = false;

            radApplicationNoRisk.Enabled = true;
            radApplicationLowRisk.Enabled = true;
            radApplicationMinimalRisk.Enabled = true;
        }

        private void radWaiver_CheckedChanged(object sender, EventArgs e)
        {
            initializePanels();
            radApplicationMediumRisk.Enabled = false;
            radApplicationMediumRisk.Checked = false;

            radApplicationhighRisk.Enabled = false;
            radApplicationhighRisk.Checked = false;

            radApplicationLowRisk.Enabled = false;
            radApplicationLowRisk.Checked = false;

            radApplicationMinimalRisk.Enabled = false;
            radApplicationMinimalRisk.Checked = false;

            radApplicationNoRisk.Enabled = true;
        }

        private void radWaiver_Click(object sender, EventArgs e)
        {
            initializePanels();
            radApplicationMediumRisk.Enabled = false;
            radApplicationMediumRisk.Checked = false;

            radApplicationhighRisk.Enabled = false;
            radApplicationhighRisk.Checked = false;

            radApplicationLowRisk.Enabled = false;
            radApplicationLowRisk.Checked = false;

            radApplicationMinimalRisk.Enabled = false;
            radApplicationMinimalRisk.Checked = false;

            radApplicationNoRisk.Enabled = true;
        }

        private void radEthics_Click(object sender, EventArgs e)
        {
            initializePanels();
            radApplicationMediumRisk.Enabled = false;
            radApplicationMediumRisk.Checked = false;

            radApplicationhighRisk.Enabled = false;
            radApplicationhighRisk.Checked = false;

            radApplicationNoRisk.Enabled = true;
            radApplicationLowRisk.Enabled = true;
            radApplicationMinimalRisk.Enabled = true;
        }

        private void btnCancelApplication_Click(object sender, EventArgs e)
        {
            string strApplicationNumber = student.strApplicationNumber;
            bool cancelApplication = student.cancelApplication();
            if (cancelApplication)
            {
                CommonMethods.myConfirmationMessageBox("Application " + strApplicationNumber + " has been cancelled");
                loadDetails(strPassedStudentNumber);
            }
            else
            {
                CommonMethods.myConfirmationMessageBox("Application cancellation Aborted");
            }
        }

        private void tbcStudentMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!txtApplicationNumber.Text.Equals("") && tbcStudentMenu.SelectedIndex == 1)
            {
                MessageBox.Show("You already have an application, cancel your current one to create a new applicaiton.", "Duplicate Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbcStudentMenu.SelectedIndex = 0;
            }
        }

        private void btnFullScreenEthicsCV_Click(object sender, EventArgs e)
        {
            FullScreenForm.loadForm(this, CommonMethods.applicantForm);
        }

        private void btnViewRisKCategoryTable_Click(object sender, EventArgs e)
        {
            FullScreenForm.loadForm(this, CommonMethods.riskCategoryTable);
        }
    }
}
