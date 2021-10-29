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
        public ManageApplicationForm()
        {
            InitializeComponent();
        }
        public static void loadForm(Form previousForm)
        {
            ManageApplicationForm frmManageApplication = new ManageApplicationForm();
            frmManageApplication.loadDetails();
            previousForm.Visible = false;
            frmManageApplication.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        private void loadDetails()
        {
            lsbApplications.Items.Clear();
            lsbReviewers.Items.Clear();

            string table, conditional;
            Dictionary<string, string> dictAttributes;
            List<Dictionary<string, string>> resultSet;
            DB database = new DB();

            string strReviewerNumber = "";
            string strApplicationNumbber = "";

            table = "Reviewer";
            conditional = "";
            dictAttributes = new Dictionary<string, string>{};

            resultSet = database.selectQuery(table, 1, conditional, dictAttributes);

            if (resultSet.Count > 0)
            {
                foreach (Dictionary<string, string> resultRow in resultSet)
                {
                    foreach (var kv in resultRow)
                    {
                        if (kv.Key.Equals("REVIEWER_NUM"))
                        {
                            strReviewerNumber = kv.Value;
                        }
                    }

                    lsbReviewers.Items.Add(strReviewerNumber);
                }
            }
            else
            {
                MessageBox.Show("No Reviewers");
            }

            table = "Application";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };

            resultSet = database.selectQuery(table, 1, conditional, dictAttributes);

            if (resultSet.Count > 0)
            {
                foreach (Dictionary<string, string> resultRow in resultSet)
                {
                    foreach (var kv in resultRow)
                    {
                        if (kv.Key.Equals("APP_NUM"))
                        {
                            strApplicationNumbber = kv.Value;
                        }
                    }
                    lsbApplications.Items.Add(strApplicationNumbber);
                }
            }
            else
            {
                MessageBox.Show("No Applications");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnViewReviwerProfile_Click(object sender, EventArgs e)
        {
            pnlApplicationView.Visible = false;
            pnlReviewerProfile.Visible = true;

            //Load reviwer details
            if (lsbReviewers.SelectedItem == null)
            {
                MessageBox.Show("Select a reviewer first.");
            }
            else
            {
                if (lblSelectedApplicationNumber.Text.Equals("\"\""))
                {
                    MessageBox.Show("Select an application first.");
                }
                else
                {
                    string strReviewerNumber = lsbReviewers.SelectedItem.ToString();

                    string table, conditional;
                    Dictionary<string, string> dictAttributes;
                    List<Dictionary<string, string>> resultSet;
                    DB database = new DB();

                    table = "Reviewer";
                    conditional = "WHERE [REVIEWER_NUM] = @reviewerNumber";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@reviewerNumber"] = strReviewerNumber
                    };

                    resultSet = database.selectQuery(table, 7, conditional, dictAttributes);

                    if (resultSet.Count > 0)
                    {
                        Dictionary<string, string> resultRow = resultSet[0];
                        foreach (var kv in resultRow)
                        {
                            if (kv.Key.Equals("REVIEWER_NUM"))
                            {
                                lblReviewerNumber.Text = kv.Value;
                            }
                            if (kv.Key.Equals("FNAME"))
                            {
                                lblFirstName.Text = kv.Value;
                            }
                            if (kv.Key.Equals("LNAME"))
                            {
                                lblLastName.Text = kv.Value;
                            }
                            if (kv.Key.Equals("QUAL_LEVEL"))
                            {
                                lblQualificationLevel.Text = kv.Value;
                            }
                            if (kv.Key.Equals("DOB"))
                            {
                                lblDateOfBirth.Text = DateTime.Parse(kv.Value).ToString("dddd dd MMMM yyyy");
                            }
                            if (kv.Key.Equals("TELEPHONE"))
                            {
                                lblTelephoneNumber.Text = kv.Value;
                            }
                            if (kv.Key.Equals("EMAIL"))
                            {
                                lblEmail.Text = kv.Value;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("REVIEWER NOT FOUND");
                    }
                }
            }
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            if (lsbApplications.SelectedItem == null)
            {
                MessageBox.Show("Please select an application first");
            }
            else
            {
                btnViewApplication.PerformClick();

                //Load Application details
                string strApplicationNumber = lsbApplications.SelectedItem.ToString();
                lblSelectedApplicationNumber.Text = strApplicationNumber;

                string table, conditional;
                Dictionary<string, string> dictAttributes;
                List<Dictionary<string, string>> resultSet;
                List<string> reviewerNumbers = new List<string>();
                DB database = new DB();

                table = "ApplicationAssignment";
                conditional = "WHERE [APP_NUM] = @applicationNumber";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@applicationNumber"] = strApplicationNumber
                };

                resultSet = database.selectQuery(table, 2, conditional, dictAttributes);

                if (resultSet.Count > 0)
                {
                    btnModify.Text = "&Modify";

                    foreach (Dictionary<string, string> resultRow in resultSet)
                    {
                        foreach (var kv in resultRow)
                        {
                            if (kv.Key.Equals("REVIEWER_NUM"))
                            {
                                reviewerNumbers.Add(kv.Value);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("New application");
                    btnModify.Text = "&Create";
                }

                lblSelectedReviewerOne.Text = (reviewerNumbers.Count > 0) ? reviewerNumbers[0] : "\"\"";
                lblSelectedReviewerTwo.Text = (reviewerNumbers.Count > 1) ? reviewerNumbers[1] : "\"\"";

                table = "Application";
                conditional = "WHERE [APP_NUM] = @applicationNumber";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@applicationNumber"] = strApplicationNumber
                };

                resultSet = database.selectQuery(table, 10, conditional, dictAttributes);

                if (resultSet.Count > 0)
                {
                    foreach (Dictionary<string, string> resultRow in resultSet)
                    {
                        foreach (var kv in resultRow)
                        {
                            if (kv.Key.Equals("STATUS"))
                            {
                                CommonMethods.setRadWithText(kv.Value, grpStatus);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Application doesnt exist.");
                }
            }
        }

        private void btnViewApplication_Click(object sender, EventArgs e)
        {
            if (lsbApplications.SelectedItem == null)
            {
                MessageBox.Show("Please select an application first.");
            }
            else
            {
                pnlReviewerProfile.Visible = false;
                pnlApplicationView.Visible = true;

                //Load Application details
                string strApplicationNumber = lsbApplications.SelectedItem.ToString();

                string table, conditional;
                Dictionary<string, string> dictAttributes;
                List<Dictionary<string, string>> resultSet;
                DB database = new DB();

                table = "Application";
                conditional = "WHERE [APP_NUM] = @applicationNumber";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@applicationNumber"] = strApplicationNumber
                };

                resultSet = database.selectQuery(table, 10, conditional, dictAttributes);

                if (resultSet.Count > 0)
                {
                    Dictionary<string, string> resultRow = resultSet[0];
                    foreach (var kv in resultRow)
                    {
                        if (kv.Key.Equals("APP_NUM"))
                        {
                            lblApplicationNumbers.Text = kv.Value;
                        }
                        if (kv.Key.Equals("ADMIN_NUM"))
                        {
                            lblAdminFullName.Text = CommonMethods.getFullName(kv.Value, "Admin", "ADMIN_NUM", 3);
                        }
                        if (kv.Key.Equals("APP_TYPE"))
                        {
                            lblApplicationType.Text = kv.Value;
                        }
                        if (kv.Key.Equals("STUDY_PROGRAM"))
                        {
                            lblStudyProgram.Text = kv.Value;
                        }
                        if (kv.Key.Equals("RESEARCH_METHOD"))
                        {
                            lblCollectingData.Text = kv.Value;
                        }
                        if (kv.Key.Equals("RISK_CATEGORY"))
                        {
                            lblRiskCategory.Text = kv.Value;
                        }
                        if (kv.Key.Equals("STATUS"))
                        {
                            lblStatus.Text = kv.Value;
                        }
                        if (kv.Key.Equals("STU_NUM"))
                        {
                            lblStudentNumber.Text = kv.Value;
                        }
                        if (kv.Key.Equals("SUPERVISOR_NUM"))
                        {
                            lblSupervisor.Text = CommonMethods.getFullName(kv.Value, "Supervisor", "SUPERVISOR_NUM", 3);
                        }
                        if (kv.Key.Equals("DATE_COMPLETED"))
                        {
                            lblDateCompleted.Text = DateTime.Parse(kv.Value).ToString("dddd dd MMMM yyyy");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("APPLICATION NOT FOUND");
                }
            }
        }

        private void btnSelectReviewer_Click(object sender, EventArgs e)
        {
            if (lsbReviewers.SelectedItem == null)
            {
                MessageBox.Show("Please select a reviewer first");
            }
            else
            {
                if (lblSelectedApplicationNumber.Text.Equals("\"\""))
                {
                    MessageBox.Show("Select an application first.");
                }
                else
                {
                    if (lblSelectedReviewerOne.Text.Equals("\"\""))
                    {
                        btnViewReviwerProfile.PerformClick();
                        string strReviewerNumber = lsbReviewers.SelectedItem.ToString();
                        if (lblSelectedReviewerTwo.Text.Equals(strReviewerNumber))
                        {
                            MessageBox.Show(strReviewerNumber + " has already been selected.");
                        }
                        else
                        {
                            lblSelectedReviewerOne.Text = strReviewerNumber;
                            MessageBox.Show(strReviewerNumber + " succesfully accepted.");
                        }
                    }
                    else if (lblSelectedReviewerTwo.Text.Equals("\"\""))
                    {
                        btnViewReviwerProfile.PerformClick();
                        string strReviewerNumber = lsbReviewers.SelectedItem.ToString();
                        if (lblSelectedReviewerOne.Text.Equals(strReviewerNumber))
                        {
                            MessageBox.Show(strReviewerNumber + " has already been selected.");
                        }
                        else
                        {
                            lblSelectedReviewerTwo.Text = strReviewerNumber;
                            MessageBox.Show(strReviewerNumber + " succesfully accepted.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Application: " + lblSelectedApplicationNumber.Text + " already has 2 reviwers, remove one of them to add reviewers to this application.");
                    }
                }
            }
        }

        private void btnRemoveReviewerOne_Click(object sender, EventArgs e)
        {
            lblSelectedReviewerOne.Text = "\"\"";
        }

        private void btnRemoveReviewerTwo_Click(object sender, EventArgs e)
        {
            lblSelectedReviewerTwo.Text = "\"\"";
        }

        private bool ValidateInput() 
        {
            bool valid = true;
            if (lblSelectedReviewerOne.Text.Equals("\"\""))
            {
                MessageBox.Show("Select the first reviewer.");
                valid = false;
            }

            if (lblSelectedReviewerTwo.Text.Equals("\"\""))
            {
                MessageBox.Show("Select the second reviewer.");
                valid = false;
            }

            if (lblSelectedApplicationNumber.Equals("\"\""))
            {
                MessageBox.Show("Select an application");
                valid = false;
            }

            valid = valid && CommonMethods.validateRadioButtonsInGroup(grpStatus, " a status");
            return valid;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            bool validInput = ValidateInput();

            if (validInput)
            {
                string strTable, strRows, strConditional;
                Dictionary<string, string> dictAttributes;
                List<Dictionary<string, string>> resultSet;

                string strReviewerOne = lblSelectedReviewerOne.Text;
                string strReviewerTwo = lblSelectedReviewerTwo.Text;
                string strStatus = CommonMethods.checkedString(grpStatus);
                string strApplicationNumber = lblSelectedApplicationNumber.Text;
                DB dbApplicationAssignemt = new DB();

                //First delete the old application Pair
                strTable = "ApplicationAssignment";
                strConditional = "WHERE APP_NUM = @applicationNumber";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@applicationNumber"] = strApplicationNumber
                };

                dbApplicationAssignemt.deleteQuery(strTable, strConditional, dictAttributes);

                //Now add the new application

                //First reviewer
                strTable = "ApplicationAssignment([APP_NUM], [REVIEWER_NUM])";
                strRows = "(@applicationNumber, @reviewerNumber)";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@applicationNumber"] = strApplicationNumber,
                    ["@reviewerNumber"] = strReviewerOne,
                };

                dbApplicationAssignemt.insertQuery(strTable, strRows, dictAttributes);

                //Second reviewer
                dictAttributes = new Dictionary<string, string>
                {
                    ["@applicationNumber"] = strApplicationNumber,
                    ["@reviewerNumber"] = strReviewerTwo,
                };

                dbApplicationAssignemt.insertQuery(strTable, strRows, dictAttributes);

                if (btnModify.Text.Equals("&Modify"))
                {
                    MessageBox.Show("Status: " + strStatus);
                    //Updating Application Table
                    strTable = "Application";
                    strConditional = "WHERE APP_NUM = @applicationNumber";
                    strRows = "[APP_NUM] = @applicationNumber, [STATUS] = @status";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@applicationNumber"] = strApplicationNumber,
                        ["@status"] = strStatus
                    };

                    dbApplicationAssignemt.updateQuery(strTable, strRows, strConditional, dictAttributes);

                    MessageBox.Show("Application: " + strApplicationNumber + " has been updated");
                }
                else
                {
                    MessageBox.Show("Application: " + strApplicationNumber + " has been created");
                }

                btnReset.PerformClick();
            }
        }

        private void ManageApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pnlReviewerProfile.Visible = false;
            pnlApplicationView.Visible = true;

            foreach (Control control in pnlApplicationView.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    
                    if (!label.Name.Contains("label")) {
                        label.Text = "\"\"";
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
                        label.Text = "\"\"";
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

            lblSelectedApplicationNumber.Text = "\"\"";
            lblSelectedReviewerOne.Text = "\"\"";
            lblSelectedReviewerTwo.Text = "\"\"";
            lblApplicationNumbers.Text = "Application Number: ";
            lblReviewerNumber.Text = "Reviewer Number";

            lsbApplications.SelectedIndex = -1;
            lsbReviewers.SelectedIndex = -1;
        }
    }
}
