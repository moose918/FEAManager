using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEAManager
{
    class ApplicationAssignment
    {
        public string strReviewerOne = "", strReviewerTwo = "" , strApplicationNumber = "", strStatus = "";
        private GroupBox grpStatus;
        private Button btnViewReviwerProfile, btnModify;
        private Label lblSelectedApplicationNumber, lblSelectedReviewerOne, lblSelectedReviewerTwo;
        private static List<List<string>> arrReviewers = new List<List<string>>();
        private static List<List<string>> arrApplication = new List<List<string>>();

        private static void addToReviewers(string strFullName, string strReviewerNumber)
        {
            List<string> tmpArr = new List<string>();
            tmpArr.Add(strReviewerNumber);
            tmpArr.Add(strFullName);
            arrReviewers.Add(tmpArr);
        }

        private static void addToApplication(string strFullName, string strApplicationNumber)
        {
            List<string> tmpArr = new List<string>();
            tmpArr.Add(strApplicationNumber);
            tmpArr.Add(strFullName);
            arrApplication.Add(tmpArr);
        }

        private static void clearArrays()
        {
            arrReviewers = new List<List<string>>();
            arrApplication = new List<List<string>>();
        }

        public static void loadDetails(ListBox lsbApplications, ListBox lsbReviewers)
        {
            clearArrays();
            lsbApplications.Items.Clear();
            lsbReviewers.Items.Clear();

            string table, conditional;
            Dictionary<string, string> dictAttributes;
            List<Dictionary<string, string>> resultSet;
            DB database = new DB();

            string strReviewerNumber = "";
            string strApplicationNumbber = "";
            string strStudentNumber = "";

            table = "Reviewer";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };

            resultSet = database.selectQuery(table, 3, conditional, dictAttributes);

            if (resultSet.Count > 0)
            {
                foreach (Dictionary<string, string> resultRow in resultSet)
                {
                    string strFName = "";
                    string strLName = "";
                    foreach (var kv in resultRow)
                    {
                        if (kv.Key.Equals("REVIEWER_NUM"))
                        {
                            strReviewerNumber = kv.Value;
                        }
                        if (kv.Key.Equals("FNAME"))
                        {
                            strFName= kv.Value;
                        }
                        if (kv.Key.Equals("LNAME"))
                        {
                            strLName = kv.Value;
                        }
                    }

                    lsbReviewers.Items.Add(strFName + " " + strLName);
                    addToReviewers(strFName + " " + strLName, strReviewerNumber);
                }
            }
            else
            {
                //MessageBox.Show("No Reviewers");
            }

            table = "Application";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };

            resultSet = database.selectQuery(table, 9, conditional, dictAttributes);

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
                        if (kv.Key.Equals("STU_NUM"))
                        {
                            strStudentNumber = kv.Value;
                        }
                    }
                    string strStudentFullName = CommonMethods.getFullName(strStudentNumber, CommonMethods.typeStudent);
                    lsbApplications.Items.Add(strStudentFullName);
                    addToApplication(strStudentFullName, strApplicationNumbber);
                }
            }
            else
            {
                //MessageBox.Show("No Applications");
            }
        }

        public ApplicationAssignment(GroupBox grpStatus, Button btnViewReviwerProfile, Label lblSelectedApplicationNumber, Button btnModify,
                                    Label lblSelectedReviewerOne, Label lblSelectedReviewerTwo, int selectedIndex, bool[] worked)
        {
            if (selectedIndex == -1)
            {
                CommonMethods.myErrorMessageBox("Please select an application");
                worked[0] = false;
                return;
            }

            this.grpStatus = grpStatus;
            this.btnViewReviwerProfile = btnViewReviwerProfile;
            this.btnModify = btnModify;
            this.lblSelectedApplicationNumber = lblSelectedApplicationNumber;
            this.lblSelectedReviewerOne = lblSelectedReviewerOne;
            this.lblSelectedReviewerTwo = lblSelectedReviewerTwo;

            //Load Application details
            this.strApplicationNumber = arrApplication[selectedIndex][0];
            this.lblSelectedApplicationNumber = lblSelectedApplicationNumber;
            lblSelectedApplicationNumber.Text = strApplicationNumber;

            string table, conditional;
            Dictionary<string, string> dictApplicationAssignmenetAttributes, dictApplicationAttributes;
            List<Dictionary<string, string>> resultSet;
            List<string> reviewerNumbers = new List<string>();
            DB dbApplicationAssignment = new DB();
            DB dbApplication = new DB();

            table = "ApplicationAssignment";
            conditional = "WHERE [APP_NUM] = @applicationNumber";
            dictApplicationAssignmenetAttributes = new Dictionary<string, string>
            {
                ["@applicationNumber"] = strApplicationNumber
            };

            resultSet = dbApplicationAssignment.selectQuery(table, 2, conditional, dictApplicationAssignmenetAttributes);

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
                btnModify.Text = "&Create";
            }

            lblSelectedReviewerOne.Text = (reviewerNumbers.Count > 0) ? reviewerNumbers[0] : CommonMethods.blankPlaceholder;
            lblSelectedReviewerTwo.Text = (reviewerNumbers.Count > 1) ? reviewerNumbers[1] : CommonMethods.blankPlaceholder;

            table = "Application";
            conditional = "WHERE [APP_NUM] = @applicationNumber";
            dictApplicationAttributes = new Dictionary<string, string>
            {
                ["@applicationNumber"] = strApplicationNumber
            };

            resultSet = dbApplication.selectQuery(table, 10, conditional, dictApplicationAttributes);

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
                //MessageBox.Show("Application doesnt exist.");
            }

            strStatus = CommonMethods.checkedString(grpStatus);
            strReviewerOne = lblSelectedReviewerOne.Text;
            strReviewerTwo = lblSelectedReviewerTwo.Text;

            worked[0] = true;

        }

        public void viewApplication(Panel pnlReviewerProfile, Panel pnlApplicationView, int iApplicationIndex, Label lblApplicationNumbers,
                                    Label lblAdminFullName, Label lblApplicationType, Label lblStudyProgram, Label lblCollectingData,
                                    Label lblRiskCategory, Label lblStatus, Label lblStudentNumber, Label lblStudentFullName,
                                    Label lblSupervisor, Label lblDateCompleted)
        {
            if (iApplicationIndex == -1)
            {
                CommonMethods.myErrorMessageBox("Please select an application first.");
                return;
            }

            pnlReviewerProfile.Visible = false;
            pnlApplicationView.Visible = true;

            //Load Application details
            string table, conditional;
            Dictionary<string, string> dictApplicationAttributes;
            List<Dictionary<string, string>> resultSet;
            DB database = new DB();

            string strLocalApplicationNumber = arrApplication[iApplicationIndex][0];

            table = "Application";
            conditional = "WHERE [APP_NUM] = @applicationNumber";
            dictApplicationAttributes = new Dictionary<string, string>
            {
                ["@applicationNumber"] = strLocalApplicationNumber
            };

            resultSet = database.selectQuery(table, 10, conditional, dictApplicationAttributes);

            if (resultSet.Count > 0)
            {
                Dictionary<string, string> resultRow = resultSet[0];
                foreach (var kv in resultRow)
                {
                    if (kv.Key.Equals("APP_NUM"))
                    {
                        lblApplicationNumbers.Text = "Applicant: " + kv.Value;
                        CommonMethods.centraliseControlInContainer(lblApplicationNumbers, pnlApplicationView);
                        //lblApplicationNumbers.Location = new Point((pnlApplicationView.Width - lblApplicationNumbers.Width) / 2, lblApplicationNumbers.Location.Y);
                    }
                    if (kv.Key.Equals("ADMIN_NUM"))
                    {
                        lblAdminFullName.Text = CommonMethods.getFullName(kv.Value, CommonMethods.typeAdmin);
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
                        string strStudentName = CommonMethods.getFullName(kv.Value, CommonMethods.typeStudent);
                        lblStudentFullName.Text = strStudentName;
                    }
                    if (kv.Key.Equals("SUPERVISOR_NUM"))
                    {
                        lblSupervisor.Text = CommonMethods.getFullName(kv.Value, CommonMethods.typeSupervisor);
                    }
                    if (kv.Key.Equals("DATE_COMPLETED"))
                    {
                        lblDateCompleted.Text = DateTime.Parse(kv.Value).ToString("dddd dd MMMM yyyy");
                    }
                }
            }
            else
            {
                //Should never happen
                //MessageBox.Show("APPLICATION NOT FOUND");
            }
        }

        public void viewReviewer(Panel pnlApplicationView, Panel pnlReviewerProfile, int selectedIndex, Label lblReviewerNumber,
                                 Label lblFirstName, Label lblLastName, Label lblQualificationLevel, Label lblDateOfBirth,
                                 Label lblTelephoneNumber, Label lblEmail)
        {
            if (selectedIndex == -1)
            {
                CommonMethods.myErrorMessageBox("Please select a reviewer");
                return;
            }

            pnlApplicationView.Visible = false;
            pnlReviewerProfile.Visible = true;

            //Load reviwer details

            string table, conditional;
            Dictionary<string, string> dictReviewerAttributes;
            List<Dictionary<string, string>> resultSet;
            DB dbReviewer = new DB();

            string strLocalReviewerNumber = arrReviewers[selectedIndex][0];

            table = "Reviewer";
            conditional = "WHERE [REVIEWER_NUM] = @reviewerNumber";
            dictReviewerAttributes = new Dictionary<string, string>
            {
                ["@reviewerNumber"] = strLocalReviewerNumber
            };

            resultSet = dbReviewer.selectQuery(table, 7, conditional, dictReviewerAttributes);

            if (resultSet.Count > 0)
            {
                Dictionary<string, string> resultRow = resultSet[0];
                foreach (var kv in resultRow)
                {
                    if (kv.Key.Equals("REVIEWER_NUM"))
                    {
                        lblReviewerNumber.Text = "Reviewer: " + kv.Value;
                        CommonMethods.centraliseControlInContainer(lblReviewerNumber, pnlReviewerProfile);
                        //lblReviewerNumber.Location = new Point((pnlReviewerProfile.Width - lblReviewerNumber.Width) / 2, lblReviewerNumber.Location.Y);
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
                //Should Never Happen
                //MessageBox.Show("REVIEWER NOT FOUND");
            }
        }

        public bool createApplicationAssignment()
        {
            bool validInput = ValidateInput();

            if (validInput)
            {
                string strTable, strRows, strConditional;
                Dictionary<string, string> dictAttributes;
                DB dbApplicationAssignemt = new DB();

                strStatus = CommonMethods.checkedString(grpStatus);

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

                return true;
            }

            return false;
        }

        public void removeReviewerOne(Label label)
        {
            strReviewerOne = "";
            label.Text = CommonMethods.blankPlaceholder;
        }

        public void removeReviewerTwo(Label label)
        {
            strReviewerTwo = "";
            label.Text = CommonMethods.blankPlaceholder;
        }

        public void addReviewerToApplication(int selectedIndex)
        {
            if (selectedIndex == -1)
            {
                CommonMethods.myErrorMessageBox("Please select a reviewer first");
            }
            else
            {
                if (strApplicationNumber.Length == 0)
                {
                    CommonMethods.myErrorMessageBox("Select an application first.");
                }
                else
                {
                    if (strReviewerOne.Length == 0 || strReviewerOne.Equals(CommonMethods.blankPlaceholder))
                    {
                        btnViewReviwerProfile.PerformClick();
                        string strReviewerNumber = arrReviewers[selectedIndex][0];
                        string strReviewerName = arrReviewers[selectedIndex][1];
                        if (lblSelectedReviewerTwo.Text.Equals(strReviewerNumber))
                        {
                            CommonMethods.myErrorMessageBox(strReviewerName + " has already been selected.");
                        }
                        else
                        {
                            lblSelectedReviewerOne.Text = strReviewerNumber;
                            strReviewerOne = strReviewerNumber;
                            CommonMethods.myConfirmationMessageBox(strReviewerName + " succesfully accepted.");
                        }
                    }
                    else if (strReviewerTwo.Length == 0 || strReviewerTwo.Equals(CommonMethods.blankPlaceholder))
                    {
                        btnViewReviwerProfile.PerformClick();
                        string strReviewerNumber = arrReviewers[selectedIndex][0];
                        string strReviewerName = arrReviewers[selectedIndex][1];
                        if (lblSelectedReviewerOne.Text.Equals(strReviewerNumber))
                        {
                            CommonMethods.myErrorMessageBox(strReviewerName + " has already been selected.");
                        }
                        else
                        {
                            lblSelectedReviewerTwo.Text = strReviewerNumber;
                            strReviewerTwo = strReviewerNumber;
                            CommonMethods.myConfirmationMessageBox(strReviewerName + " succesfully accepted.");
                        }
                    }
                    else
                    {
                        CommonMethods.myErrorMessageBox("Application: " + strApplicationNumber + " already has 2 reviwers, remove one of them to add reviewers to this application.");
                    }
                }
            }
        }

        private bool ValidateInput()
        {
            bool valid = true;
            if (strReviewerOne.Length == 0)
            {
                CommonMethods.myErrorMessageBox("Select the first reviewer.");
                valid = false;
            }

            if (strReviewerTwo.Length == 0)
            {
                CommonMethods.myErrorMessageBox("Select the second reviewer.");
                valid = false;
            }

            if (strApplicationNumber.Length == 0)
            {
                CommonMethods.myErrorMessageBox("Select an second reviewer.");
                valid = false;
            }

            valid = valid && CommonMethods.validateRadioButtonsInGroup(grpStatus, " a status");
            return valid;
        }

        public bool updateApplicationAssignment()
        {
            bool validInput = ValidateInput();

            if (validInput)
            {
                string strTable, strRows, strConditional;
                Dictionary<string, string> dictAttributes;
                DB dbApplicationAssignemt = new DB();
                DB dbApplication = new DB();

                strStatus = CommonMethods.checkedString(grpStatus);

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

                //Updating Application Table
                strTable = "Application";
                strConditional = "WHERE APP_NUM = @applicationNumber";
                strRows = "[STATUS] = @status";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@status"] = strStatus,
                    ["@applicationNumber"] = strApplicationNumber
                };

                int cols = dbApplication.updateQuery(strTable, strRows, strConditional, dictAttributes);
                /*MessageBox.Show("Affectred: " + cols);
                MessageBox.Show("Applnum: " + strApplicationNumber);
                MessageBox.Show("Status to: " + strStatus);*/

                return true;
            }
            return false;
        }

        public void reset()
        {
            strReviewerOne = "";
            strReviewerTwo = "";
            strApplicationNumber = "";
            strStatus = "";
        }
    }
}
