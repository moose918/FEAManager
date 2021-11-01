using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEAManager
{
    class Student
    {


        private string strStudentNumber, strFName, strLName, strTitle, strStudyProgram, strTelephone, strEmail, strPassword, strDOB;
        
        public string strApplicationNumber;

        private List<List<string>> changes = new List<List<string>>();

        /**Controls For Student Details**/
        private MaskedTextBox mtxtTelephone, mtxtPassword, mtxtEmail;
        private TextBox txtStudentNumber, txtFName, txtLName;
        private ComboBox cmbStudyProgram;
        private GroupBox grpTitle;
        private DateTimePicker dtpDetailsDateOfBirth;
        /**Controls For Student Details**/

        /**Controls for Student Application**/
        ComboBox cmbSupervisorEmail, cmbSupervisorFirstName, cmbSupervisorLastName;

        MaskedTextBox cmbSupervisorCellphone;


        DateTimePicker dtpDateCompleted;

        RadioButton radWaiverDegreePurposeOther, radNo, radDataReuseEthicsYes, radPermissionReuseEthicsYes, radEthicsDegreePruposeOther;
        RadioButton radRiskExposureYes, radVulnerableYes, radEthics, radReadRiskTableYes, radInvolveHumansYes, radrelationshipsYes, radWaiver;

        CheckedListBox clbdataDisposal, cblHowDataWillBeCollected;

        TextBox txtWaiverOtherDegree, txtWaiverProjectTitle, txtEthicsOtherDegree, txtEthicsProjectTitle;

        RichTextBox rtbAbstractSummary, rtbAimsAndObjectives, rtbDataProtectionDuringResearch, rtbAnonymityConfidentialityMethod, rtbParticipantSelectionMathods;
        RichTextBox rtbResearchLocation, rtbExplainConflictResolution, rtbEthicsAbstractSummary;
        RichTextBox rtbEthicsAimsAndObjectives, rtbAddressPotentialRisks, rtbAddressingVulnerabilities;

        GroupBox gpbApplicationType, gpbReadRiskTable, gpbInvolveHumans, gpbApplicationRiskCategory, gpbStudyProgram;
        GroupBox gpbCollectingData, gpbDegreeEthics, gpnVulnurableCategoriesEthics, gpbExperts;
        GroupBox gpbPermissionsEthicsIfYes, gpbPermissionsEthics, gpbFormalPermissionLocation, gpbPersonalConflictsEthics;
        GroupBox gpbAdditionalResearchersEthics, gpbConfirmation, gpbDegreeWaiver, rpbCollaborationWaiver;
        GroupBox gpbPermissionsWaiverIfYes, gpbPermissionsWaiver, gpbAnonymityResulting, gpbAnonymityProcess, gpbConfidentialityProcess;
        GroupBox gpbInformedConcentGatheringMethod, gpbIncentivesEthics;
        /**Controls for Student Application**/


        public Student(string strStudentNumber, MaskedTextBox mtxtTelephone, MaskedTextBox mtxtPassword, MaskedTextBox mtxtEmail, TextBox txtStudentNumber, TextBox txtFName, TextBox txtLName, ComboBox cmbStudyProgram, GroupBox grpTitle, DateTimePicker dtpDetailsDateOfBirth,
                       TextBox txtApplicationType, TextBox txtDetailsAdminNumber, TextBox txtApplicationNumber, RadioButton radDetailsCollectingDataNo, RadioButton radDetailsCollectingDataYes, GroupBox gpbStatus, GroupBox gpbRiskCategory, DateTimePicker dtpDateCompleted,
                       Button btnCancelApplication, TextBox txtDetailsSupervisor, Panel pnlCurrentApplication,
                       
                       MaskedTextBox cmbSupervisorCellphone, ComboBox cmbSupervisorEmail, ComboBox cmbSupervisorFirstName, ComboBox cmbSupervisorLastName,
                       RadioButton radWaiverDegreePurposeOther, RadioButton radNo, RadioButton radDataReuseEthicsYes, RadioButton radPermissionReuseEthicsYes, RadioButton radEthicsDegreePruposeOther,
                       RadioButton radRiskExposureYes, RadioButton radVulnerableYes, RadioButton radEthics, RadioButton radReadRiskTableYes, RadioButton radInvolveHumansYes, RadioButton radrelationshipsYes, RadioButton radWaiver,
                       CheckedListBox clbdataDisposal, CheckedListBox  cblHowDataWillBeCollected,
                       TextBox txtWaiverOtherDegree, TextBox txtWaiverProjectTitle, TextBox txtEthicsOtherDegree, TextBox txtEthicsProjectTitle,
                       RichTextBox rtbAbstractSummary, RichTextBox rtbAimsAndObjectives, RichTextBox rtbDataProtectionDuringResearch, RichTextBox rtbAnonymityConfidentialityMethod, RichTextBox rtbParticipantSelectionMathods,
                       RichTextBox rtbResearchLocation, RichTextBox rtbExplainConflictResolution, RichTextBox rtbEthicsAbstractSummary,
                       RichTextBox rtbEthicsAimsAndObjectives, RichTextBox rtbAddressPotentialRisks, RichTextBox rtbAddressingVulnerabilities,

                       GroupBox gpbApplicationType, GroupBox gpbReadRiskTable, GroupBox gpbInvolveHumans, GroupBox gpbApplicationRiskCategory, GroupBox gpbStudyProgram,
                       GroupBox gpbCollectingData, GroupBox gpbDegreeEthics, GroupBox gpnVulnurableCategoriesEthics, GroupBox gpbExperts,
                       GroupBox gpbPermissionsEthicsIfYes, GroupBox gpbPermissionsEthics, GroupBox gpbFormalPermissionLocation, GroupBox gpbPersonalConflictsEthics,
                       GroupBox gpbAdditionalResearchersEthics, GroupBox gpbConfirmation, GroupBox gpbDegreeWaiver, GroupBox rpbCollaborationWaiver,
                       GroupBox gpbPermissionsWaiverIfYes, GroupBox gpbPermissionsWaiver, GroupBox gpbAnonymityResulting, GroupBox gpbAnonymityProcess, GroupBox gpbConfidentialityProcess,
                       GroupBox gpbInformedConcentGatheringMethod, GroupBox gpbIncentivesEthics)
        {
            /**For controls on student details**/
            this.mtxtTelephone = mtxtTelephone;
            this.mtxtPassword = mtxtPassword;
            this.mtxtEmail = mtxtEmail;
            this.txtStudentNumber = txtStudentNumber;
            this.txtFName = txtFName;
            this.txtLName = txtLName;
            this.cmbStudyProgram = cmbStudyProgram;
            this.grpTitle = grpTitle;
            this.dtpDetailsDateOfBirth = dtpDetailsDateOfBirth;
            /**For controls on student details**/

            /**For controls on Create Application**/
            this.cmbSupervisorCellphone = cmbSupervisorCellphone;
            this.cmbSupervisorEmail = cmbSupervisorEmail;
            this.cmbSupervisorFirstName = cmbSupervisorFirstName;
            this.cmbSupervisorLastName = cmbSupervisorLastName;

            this.dtpDateCompleted = dtpDateCompleted;

            this.radWaiverDegreePurposeOther = radWaiverDegreePurposeOther;
            this.radNo = radNo;
            this.radDataReuseEthicsYes  = radDataReuseEthicsYes;
            this.radPermissionReuseEthicsYes = radPermissionReuseEthicsYes;
            this.radEthicsDegreePruposeOther = radEthicsDegreePruposeOther; ;
            this.radRiskExposureYes = radRiskExposureYes;
            this.radVulnerableYes = radVulnerableYes;
            this.radEthics = radEthics;
            this.radReadRiskTableYes = radReadRiskTableYes;
            this.radInvolveHumansYes = radInvolveHumansYes;
            this.radrelationshipsYes = radrelationshipsYes;
            this.radWaiver = radWaiver;

            this.clbdataDisposal = clbdataDisposal;
            this.cblHowDataWillBeCollected = cblHowDataWillBeCollected;

            this.txtWaiverOtherDegree = txtWaiverOtherDegree;
            this.txtWaiverProjectTitle = txtWaiverProjectTitle;
            this.txtEthicsOtherDegree = txtEthicsOtherDegree;
            this.txtEthicsProjectTitle = txtEthicsProjectTitle;

            this.rtbAbstractSummary = rtbAbstractSummary;
            this.rtbAimsAndObjectives = rtbAimsAndObjectives;
            this.rtbDataProtectionDuringResearch = rtbDataProtectionDuringResearch;
            this.rtbAnonymityConfidentialityMethod = rtbAnonymityConfidentialityMethod;
            this.rtbParticipantSelectionMathods = rtbParticipantSelectionMathods;
            this.rtbResearchLocation = rtbResearchLocation;
            this.rtbExplainConflictResolution = rtbExplainConflictResolution;
            this.rtbEthicsAbstractSummary = rtbEthicsAbstractSummary;
            this.rtbEthicsAimsAndObjectives = rtbEthicsAimsAndObjectives;
            this.rtbAddressPotentialRisks = rtbAddressPotentialRisks;
            this.rtbAddressingVulnerabilities = rtbAddressingVulnerabilities;

            this.gpbApplicationType = gpbApplicationType;
            this.gpbReadRiskTable = gpbReadRiskTable;
            this.gpbInvolveHumans = gpbInvolveHumans;
            this.gpbApplicationRiskCategory = gpbApplicationRiskCategory;
            this.gpbStudyProgram = gpbStudyProgram;
            this.gpbCollectingData = gpbCollectingData;
            this.gpbDegreeEthics = gpbDegreeEthics;
            this.gpnVulnurableCategoriesEthics = gpnVulnurableCategoriesEthics;
            this.gpbExperts = gpbExperts;
            this.gpbPermissionsEthicsIfYes = gpbPermissionsEthicsIfYes;
            this.gpbPermissionsEthics = gpbPermissionsEthics;
            this.gpbFormalPermissionLocation = gpbFormalPermissionLocation;
            this.gpbPersonalConflictsEthics = gpbPersonalConflictsEthics;
            this.gpbAdditionalResearchersEthics = gpbAdditionalResearchersEthics;
            this.gpbConfirmation = gpbConfirmation;
            this.gpbDegreeWaiver = gpbDegreeWaiver;
            this.rpbCollaborationWaiver = rpbCollaborationWaiver;
            this.gpbPermissionsWaiverIfYes = gpbPermissionsWaiverIfYes;
            this.gpbPermissionsWaiver = gpbPermissionsWaiver;
            this.gpbAnonymityResulting = gpbAnonymityResulting;
            this.gpbAnonymityProcess = gpbAnonymityProcess;
            this.gpbConfidentialityProcess = gpbConfidentialityProcess;
            this.gpbInformedConcentGatheringMethod = gpbInformedConcentGatheringMethod;
            this.gpbIncentivesEthics = gpbIncentivesEthics;
            /**For controls on Create Application**/

            this.strStudentNumber = strStudentNumber;


            CommonMethods.getStudyPrograms(cmbStudyProgram);

            string table, conditional, strSupervisorNumber = "";
            Dictionary<string, string> dictStudentAttributes, dictApplicationAttributes, dictSupervisorAttributes, resultRow;
            List<Dictionary<string, string>> resultSet;
            DB dbStudent = new DB();
            DB dbApplication = new DB();
            DB dbSupervisor = new DB();

            table = "Student";
            conditional = "WHERE [STU_NUM] = @studentNum";
            dictStudentAttributes = new Dictionary<string, string>
            {
                ["@studentNum"] = strStudentNumber
            };

            resultSet = dbStudent.selectQuery(table, 9, conditional, dictStudentAttributes);

            if (resultSet.Count > 0)
            {
                changes = new List<List<string>>();
                resultRow = resultSet[0];
                foreach (var kv in resultRow)
                {
                    if (kv.Key.Equals("STU_NUM"))
                    {
                        strStudentNumber = kv.Value;

                        List<string> line = new List<string>();
                        line.Add("student number");
                        line.Add(strStudentNumber);
                        changes.Add(line);

                        txtStudentNumber.Text = strStudentNumber;
                    }
                    if (kv.Key.Equals("FNAME"))
                    {
                        strFName = kv.Value;

                        List<string> line = new List<string>();
                        line.Add("first name");
                        line.Add(strFName);
                        changes.Add(line);

                        txtFName.Text = strFName;
                    }
                    if (kv.Key.Equals("LNAME"))
                    {
                        strLName = kv.Value;

                        List<string> line = new List<string>();
                        line.Add("last name");
                        line.Add(strLName);
                        changes.Add(line);

                        txtLName.Text = strLName;
                    }
                    if (kv.Key.Equals("EMAIL"))
                    {
                        strEmail = kv.Value;

                        List<string> line = new List<string>();
                        line.Add("email address");
                        line.Add(strEmail);
                        changes.Add(line);

                        mtxtEmail.Text = strEmail;
                    }
                    if (kv.Key.Equals("PASSWORD"))
                    {
                        strPassword = kv.Value;

                        List<string> line = new List<string>();
                        line.Add("password");
                        line.Add(strPassword);
                        changes.Add(line);

                        mtxtPassword.Text = strPassword;
                    }
                    if (kv.Key.Equals("DOB"))
                    {
                        DateTime actualValue = DateTime.Parse(kv.Value);
                        strDOB = DateTime.Parse(kv.Value).ToString("dd/MM/yyyy");

                        List<string> line = new List<string>();
                        line.Add("date of birth");
                        line.Add(strDOB);
                        changes.Add(line);

                        dtpDetailsDateOfBirth.Value = actualValue;
                    }
                    if (kv.Key.Equals("TELEPHONE"))
                    {
                        strTelephone = kv.Value;

                        List<string> line = new List<string>();
                        line.Add("telephone number");
                        line.Add(strTelephone);
                        changes.Add(line);

                        mtxtTelephone.Text = strTelephone;
                    }
                    if (kv.Key.Equals("STUDY_PROGRAM"))
                    {
                        strStudyProgram = kv.Value;

                        List<string> line = new List<string>();
                        line.Add("study program");
                        line.Add(strStudyProgram);
                        changes.Add(line);

                        cmbStudyProgram.Text = strStudyProgram;
                    }
                    if (kv.Key.Equals("TITLE"))
                    {
                        foreach (RadioButton radioButton in grpTitle.Controls)
                        {
                            if (radioButton.Text.Equals(kv.Value))
                            {
                                strTitle = kv.Value;

                                List<string> line = new List<string>();
                                line.Add("title");
                                line.Add(strTitle);
                                changes.Add(line);

                                radioButton.Checked = true;
                                break;
                            }
                        }
                    }
                }
            }

            table = "Application";
            conditional = "WHERE [STU_NUM] = @studentNum";
            dictApplicationAttributes = new Dictionary<string, string>
            {
                ["@studentNum"] = strStudentNumber
            };

            resultSet = dbApplication.selectQuery(table, 9, conditional, dictApplicationAttributes);

            if (resultSet.Count > 0)
            {
                resultRow = resultSet[0];
                foreach (var kv in resultRow)
                {
                    if (kv.Key.Equals("APP_NUM"))
                    {
                        txtApplicationNumber.Text = kv.Value;
                    }
                    if (kv.Key.Equals("ADMIN_NUM"))
                    {
                        txtDetailsAdminNumber.Text = kv.Value;
                    }
                    if (kv.Key.Equals("APP_TYPE"))
                    {
                        txtApplicationType.Text = kv.Value;
                    }
                    if (kv.Key.Equals("RESEARCH_METHOD"))
                    {
                        if (kv.Value.Equals("Yes"))
                        {
                            radDetailsCollectingDataYes.Checked = true;
                        }
                        else
                        {
                            radDetailsCollectingDataNo.Checked = true;
                        }
                    }
                    if (kv.Key.Equals("RISK_CATEGORY"))
                    {
                        CommonMethods.setRadWithText(kv.Value, gpbRiskCategory);
                    }
                    if (kv.Key.Equals("STATUS"))
                    {
                        CommonMethods.setRadWithText(kv.Value, gpbStatus);
                    }
                    if (kv.Key.Equals("DATE_COMPLETED"))
                    {
                        dtpDateCompleted.Value = DateTime.Parse(kv.Value);
                    }
                    if (kv.Key.Equals("SUPERVISOR_NUM"))
                    {
                        strSupervisorNumber = kv.Value;
                    }
                }

                btnCancelApplication.Enabled = true;

                table = "Supervisor";
                conditional = "WHERE [SUPERVISOR_NUM] = @supervisorNumber";
                dictSupervisorAttributes = new Dictionary<string, string>
                {
                    ["@supervisorNumber"] = strSupervisorNumber
                };
                
                resultSet = dbSupervisor.selectQuery(table, 3, conditional, dictSupervisorAttributes);

                if (resultSet.Count > 0)
                {
                    resultRow = resultSet[0];
                    string strSupervisorFName = "", strSupervisorLName = "";
                    foreach (var kv in resultRow)
                    {
                        if (kv.Key.Equals("FNAME"))
                        {
                            strSupervisorFName = kv.Value;
                        }
                        if (kv.Key.Equals("LNAME"))
                        {
                            strSupervisorLName = kv.Value;
                        }
                    }
                    txtDetailsSupervisor.Text = strSupervisorFName + " " + strSupervisorLName;
                }

                this.strApplicationNumber = txtApplicationNumber.Text;
            }
            else
            {
                CommonMethods.clearControl(pnlCurrentApplication, null);
                btnCancelApplication.Enabled = false;
            }
        }

        public bool updateStudent()
        {
            bool validInformation = ValidateInformation(0);
            if (validInformation)
            {
                bool confirmedUpdate = ConfirmUpdate();

                if (confirmedUpdate)
                {
                    string strTable, strParams, strConditional;
                    Dictionary<string, string> dictAttributes;
                    DB dbReviewer = new DB();

                    strTable = "Student";
                    strParams = "[FNAME] = @fName, [LNAME] = @lName, [EMAIL] = @email, [PASSWORD] = @password, [DOB] = @dob, [TELEPHONE] = @telephone, [STUDY_PROGRAM] = @studyProgram, [TITLE] = @title";
                    strConditional = "WHERE STU_NUM = @stuNumber";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@fName"] = txtFName.Text,
                        ["@lName"] = txtLName.Text,
                        ["@email"] = mtxtEmail.Text,
                        ["@password"] = mtxtPassword.Text,
                        ["@dob"] = dtpDetailsDateOfBirth.Value.ToString("dd/MM/yyyy"),
                        ["@telephone"] = mtxtTelephone.Text,
                        ["@studyProgram"] = cmbStudyProgram.Text,
                        ["@title"] = CommonMethods.checkedString(grpTitle),
                        ["@stuNumber"] = txtStudentNumber.Text
                    };

                    dbReviewer.updateQuery(strTable, strParams, strConditional, dictAttributes);

                    CommonMethods.myConfirmationMessageBox("Your student details have been updated successfully");

                    return true;
                }
            }
            return false;
        }

        private bool ConfirmUpdate()
        {
            List<List<string>> newChanges = new List<List<string>>();
            List<string> line = new List<string>();

            line = new List<string>();
            line.Add("student number");
            line.Add(txtStudentNumber.Text);
            newChanges.Add(line);

            line = new List<string>();
            line.Add("first name");
            line.Add(txtFName.Text);
            newChanges.Add(line);

            line = new List<string>();
            line.Add("last name");
            line.Add(txtLName.Text);
            newChanges.Add(line);

            line = new List<string>();
            line.Add("email address");
            line.Add(mtxtEmail.Text);
            newChanges.Add(line);

            line = new List<string>();
            line.Add("password");
            line.Add(mtxtPassword.Text);
            newChanges.Add(line);

            line = new List<string>();
            line.Add("date of birth");
            line.Add(dtpDetailsDateOfBirth.Value.ToString("dd/MM/yyyy"));
            newChanges.Add(line);

            line = new List<string>();
            line.Add("study program");
            line.Add(cmbStudyProgram.Text);
            newChanges.Add(line);

            line = new List<string>();
            line.Add("telephone number");
            line.Add(mtxtTelephone.Text);
            newChanges.Add(line);

            line = new List<string>();
            line.Add("title");
            line.Add(CommonMethods.checkedString(grpTitle));
            newChanges.Add(line);

            CommonMethods.addNewChanges(changes, newChanges);
            return CommonMethods.manageChanges(changes);
        }

        private bool ValidateInformation(int tabIndex)
        {
            bool valid = true;
            if (tabIndex == 0)
            {
                valid = CommonMethods.validateTextBox(txtFName, "first name") && valid;
                valid = CommonMethods.validateTextBox(txtLName, "last name") && valid;
                valid = CommonMethods.validateTextBox(mtxtTelephone, "telephone") && valid;
                valid = CommonMethods.validateTextBox(cmbStudyProgram, "study program") && valid;
                valid = CommonMethods.validateTextBox(mtxtPassword, "password") && valid;
                valid = CommonMethods.validateTextBox(mtxtEmail, "email") && valid;
                valid = CommonMethods.validateTextBox(txtStudentNumber, "student number") && valid;
                valid = CommonMethods.validateTextBox(txtStudentNumber, "student number", CommonMethods.typeStudent) && valid;
                valid = CommonMethods.validateRadioButtonsInGroup(grpTitle, "title") && valid;
                valid = CommonMethods.validateDOB(dtpDetailsDateOfBirth) && valid;
            }
            else
            {
                valid = CommonMethods.validateRadioButtonsInGroup(gpbApplicationType, "application type") && valid;
                valid = CommonMethods.validateRadioButtonsInGroup(gpbCollectingData, "last name") && valid;
                valid = CommonMethods.validateRadioButtonsInGroup(gpbStudyProgram, "telephone") && valid;
                valid = CommonMethods.validateTextBox(cmbSupervisorFirstName, "supervisor\'s first name") && valid;
                valid = CommonMethods.validateTextBox(cmbSupervisorFirstName, "supervisor\'s last name") && valid;
                valid = CommonMethods.validateTextBox(cmbSupervisorEmail, "supervisor\'s email") && valid;
                valid = CommonMethods.validateTextBox(cmbSupervisorCellphone, "supervisor\'s cellphone") && valid;
                valid = CommonMethods.validateRadioButtonsInGroup(gpbApplicationRiskCategory, "risk category") && valid;
                valid = CommonMethods.validateRadioButtonsInGroup(gpbInvolveHumans, "option pertaining human involvement") && valid;
                valid = CommonMethods.validateDOB(dtpDateCompleted) && valid;

                if (radInvolveHumansYes.Checked && !radEthics.Checked)
                {
                    valid = false;
                    MessageBox.Show("Your project involves human participants. Apply for Ethics Clearance");
                    gpbApplicationType.Focus();
                }

                if (!radReadRiskTableYes.Checked)
                {
                    valid = false;
                    MessageBox.Show("Read the risk category table before completing the form.");
                    gpbReadRiskTable.Focus();
                }

                if (radEthics.Checked)
                {
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbExperts, "indication of your participants expertise.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpnVulnurableCategoriesEthics, "indication of whether the research will involve vulnurable categories.") && valid;
                    
                    if (rtbAddressingVulnerabilities.Text.Equals("") && radVulnerableYes.Checked)
                    {
                        MessageBox.Show("You have indicated that vulnurable categories will be involved. Please enter how you will address these existing vulnurabilities.");
                        rtbAddressingVulnerabilities.Focus();
                        valid = false;
                    }

                    valid = CommonMethods.validateRadioButtonsInGroup(gpnVulnurableCategoriesEthics, "indication of whether the research will expose researchers and participants to harm, they optherwise would not experience.") && valid;

                    if (rtbAddressPotentialRisks.Text.Equals("") && radRiskExposureYes.Checked)
                    {
                        MessageBox.Show("You have indicated that participants / researchers will be exposed to potentiual harm they otherwuise wouldnt be exposed to. Please enter how you will address these existing potential harmful situations.");
                        rtbAddressPotentialRisks.Focus();
                        valid = false;
                    }

                    valid = CommonMethods.validateTextBox(txtEthicsProjectTitle, "title for this ethics application.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbDegreeEthics, "indication of the degree this application will be used for.") && valid;

                    if (radEthicsDegreePruposeOther.Checked && txtEthicsOtherDegree.Text.Equals(""))
                    {
                        MessageBox.Show("You have indicated that the degree this project will be used for is other. Please a description of other.");
                        txtEthicsOtherDegree.Focus();
                        valid = false;
                    }

                    valid = CommonMethods.validateTextBox(rtbEthicsAimsAndObjectives, "aims and objectives for this project.") && valid;
                    valid = CommonMethods.validateTextBox(rtbEthicsAbstractSummary, "summary of the abstract.") && valid;

                    valid = CommonMethods.validateRadioButtonsInGroup(gpbPermissionsEthics, "indication of whether the study will reuse data that has already been collected by other researchers.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbPermissionsEthicsIfYes, "indication of whether you have permission to use the data collected by other researchers.") && valid;

                    if (CommonMethods.checkedString(gpbPermissionsEthics).Equals("Yes") && CommonMethods.checkedString(gpbPermissionsEthicsIfYes).Equals("No"))
                    {
                        CommonMethods.myErrorMessageBox("You indicated that you will reuse collected by pther reviewers. You need permission so complete this application");
                        valid = false;
                        gpbPermissionsEthicsIfYes.Focus();
                    }

                    if (radDataReuseEthicsYes.Checked && !radPermissionReuseEthicsYes.Checked)
                    {
                        MessageBox.Show("You have indicated that you are going to reuse data that already been collected by other researchers. You may not make an application without gaining permissions ot use said data first.");
                        gpbPermissionsEthicsIfYes.Focus();
                        valid = false;
                    }

                    valid = CommonMethods.validateRadioButtonsInGroup(gpbAdditionalResearchersEthics, "indication of whether there will be any additional researchers.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbPersonalConflictsEthics, "indication of whether you have any personal involvement with any of the participants or the organizer.") && valid;

                    if (radrelationshipsYes.Checked && rtbExplainConflictResolution.Text.Equals(""))
                    {
                        MessageBox.Show("You have indicated that your project might have personal conflicts. Please specify how these conflics are going to be addressed.");
                        rtbExplainConflictResolution.Focus();
                        valid = false;
                    }

                    valid = CommonMethods.validateTextBox(rtbResearchLocation, "locations for where the research will be conducted.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbFormalPermissionLocation, "indication of whether you have recieved formal permission to use those reseach locations.") && valid;

                    if (radNo.Checked && cblHowDataWillBeCollected.CheckedItems.Count != 0)
                    {
                        CheckBoxList test = new CheckBoxList();
                        CommonMethods.myErrorMessageBox("You indicated that you will not be collecting data. However, you have entered methods for collecting data on human participants.");
                        gpbCollectingData.Focus();
                        valid = false;
                    }

                    valid = CommonMethods.validateTextBox(rtbParticipantSelectionMathods, "method of identifying and selecting participants.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbFormalPermissionLocation, "indication of whether you will be giving participants incentives for participating.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbInformedConcentGatheringMethod, "indication of how you will be getting informed concent from the participants.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbConfidentialityProcess, "indication of whether you can or can not guarantee confidentiality of participants during the data collection process.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbAnonymityProcess, "indication of whether you can or can not guarantee anonymity of participants during the data collection process.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbAnonymityResulting, "indication of whether you can or can not guarantee anonymity of participants in resulting research papers / reports.") && valid;

                    valid = CommonMethods.validateTextBox(rtbAnonymityConfidentialityMethod, "methods for managing issues of anonymity and confidentiality in the project.") && valid;
                    valid = CommonMethods.validateTextBox(rtbDataProtectionDuringResearch, "methods for protecting the data while research is in progress.") && valid;

                    if (clbdataDisposal.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Please indicate at least 1 method of data disposal after research has concluded.");
                        clbdataDisposal.Focus();
                        valid = false;
                    }
                }
                else
                {
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbConfirmation, "a confirmation for this waiver application.") && valid;

                    if (CommonMethods.checkedString(gpbConfirmation).Equals("No"))
                    {
                        CommonMethods.myErrorMessageBox("You need to understand the implications of involving human participants if you want to comeplete your application.");
                        valid = false;
                        gpbConfirmation.Focus();
                    }

                    valid = CommonMethods.validateTextBox(txtWaiverProjectTitle, "title for this waiver application.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbDegreeWaiver, "indication of the degree this application will be used for.") && valid;

                    if (radWaiverDegreePurposeOther.Checked && txtWaiverOtherDegree.Text.Equals(""))
                    {
                        MessageBox.Show("You have indicated that the degree this project will be used for is other. Please a description of other.");
                        txtWaiverOtherDegree.Focus();
                        valid = false;
                    }

                    valid = CommonMethods.validateTextBox(rtbAimsAndObjectives, "aims and objectives for this project.") && valid;
                    valid = CommonMethods.validateTextBox(rtbAbstractSummary, "summary of the abstract.") && valid;

                    valid = CommonMethods.validateRadioButtonsInGroup(gpbPermissionsWaiver, "indication of whether the study will reuse data that has already been collected by other researchers.") && valid;
                    valid = CommonMethods.validateRadioButtonsInGroup(gpbPermissionsWaiverIfYes, "indication of whether you have permission to use the data collected by other researchers.") && valid;
                    
                    if (CommonMethods.checkedString(gpbPermissionsWaiver).Equals("Yes") && CommonMethods.checkedString(gpbPermissionsWaiverIfYes).Equals("No"))
                    {
                        CommonMethods.myErrorMessageBox("You indicated that you will reuse collected by pther reviewers. You need permission so complete this application");
                        valid = false;
                        gpbPermissionsWaiverIfYes.Focus();
                    }

                    valid = CommonMethods.validateRadioButtonsInGroup(rpbCollaborationWaiver, "indication of whether this application is a multi-student application or not.") && valid;
                }
            }

            return valid;
        }

        private string getSupervisorNumber()
        {
            string table, conditional;
            Dictionary<string, string> dictAttributes, resultRow;
            List<Dictionary<string, string>> resultSet;
            DB dbLogin = new DB();

            table = "Supervisor";
            conditional = "WHERE [FNAME] = @fName AND [LNAME] = @lName";
            dictAttributes = new Dictionary<string, string>
            {
                ["@fName"] = cmbSupervisorFirstName.Text,
                ["@lName"] = cmbSupervisorLastName.Text
            };

            resultSet = dbLogin.selectQuery(table, 5, conditional, dictAttributes);

            String strSupervisorNumber = "";

            if (resultSet.Count > 0)
            {
                resultRow = resultSet[0];
                foreach (var kv in resultRow)
                {
                    if (kv.Key.Equals("SUPERVISOR_NUM"))
                    {
                        strSupervisorNumber = kv.Value;
                    }
                }
                return strSupervisorNumber;
            }
            else
            {
                strSupervisorNumber = "SUP" + CommonMethods.generateDigits();
                table = "Supervisor";
                conditional = "WHERE [SUPERVISOR_NUM] = @supervisorNumber";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@supervisorNumber"] = strSupervisorNumber
                };

                resultSet = dbLogin.selectQuery(table, 1, conditional, dictAttributes);

                while (resultSet.Count > 0)
                {
                    strSupervisorNumber = "SUP" + CommonMethods.generateDigits();
                    resultSet = dbLogin.selectQuery(table, 1, conditional, dictAttributes);
                }
                return strSupervisorNumber;
            }
        }

        public bool createApplication()
        {
            strApplicationNumber = CommonMethods.generateUniqueID(CommonMethods.typeApplication);
            string strAdnimNumber = CommonMethods.getAdminNumber();
            string strApplicationType = CommonMethods.checkedString(gpbApplicationType);
            string strStudyProgram = CommonMethods.checkedString(gpbStudyProgram);
            string strResearchMethod = CommonMethods.checkedString(gpbCollectingData);
            string strRiskCategory = CommonMethods.checkedString(gpbApplicationRiskCategory);
            string strSupervisorNumber = getSupervisorNumber();
            string strStatus = "Pending";
            string strSupervisorfName = cmbSupervisorFirstName.Text;
            string strSupervisorlName = cmbSupervisorLastName.Text;
            string strSupervisorEmail = cmbSupervisorEmail.Text;
            string strSupervisorTelephone = cmbSupervisorCellphone.Text;
            string strDateCompleted = dtpDateCompleted.Value.ToString("dd/MM/yyyy");

            bool validInformation = ValidateInformation(1);

            //bool validInformation = true;

            if (validInformation)
            {
                string strTable, strRows, strConditional;
                Dictionary<string, string> dictStudentAttributes, dictSupervisorAttributes, dictEthicsAttributes, dictWaiverAttributes, dictApplicationAttributes;
                List<Dictionary<string, string>> resultSet;
                DB dbStudent = new DB();
                DB dbSupervisor = new DB();
                DB dbEthics = new DB();
                DB dbWaiver = new DB();
                DB dbApplication = new DB();

                //Checking that this supervisor does not already exist in the database. 

                strTable = "Supervisor";
                strConditional = "WHERE [SUPERVISOR_NUM] = @supervisorNumber";
                dictSupervisorAttributes = new Dictionary<string, string>
                {
                    ["@supervisorNumber"] = strSupervisorNumber
                };

                resultSet = dbSupervisor.selectQuery(strTable, 1, strConditional, dictSupervisorAttributes);

                if (resultSet.Count == 0)
                {
                    strTable = "Supervisor([SUPERVISOR_NUM], [FNAME], [LNAME], [EMAIL], [TELEPHONE])";
                    strRows = "(@supervisorNumber, @supervisorFirstName, @supervisorLastName, @supervisorEmail, @supervisorTelephone)";
                    dictSupervisorAttributes = new Dictionary<string, string>
                    {
                        ["@supervisorNumber"] = strSupervisorNumber,
                        ["@supervisorFirstName"] = strSupervisorfName,
                        ["@supervisorLastName"] = strSupervisorlName,
                        ["@supervisorEmail"] = strSupervisorEmail,
                        ["@supervisorTelephone"] = strSupervisorTelephone
                    };

                    dbSupervisor.insertQuery(strTable, strRows, dictSupervisorAttributes);
                }

                strTable = "Application([APP_NUM], [ADMIN_NUM], [APP_TYPE], [STUDY_PROGRAM], [RESEARCH_METHOD], [RISK_CATEGORY], [STATUS], [STU_NUM], [SUPERVISOR_NUM], [DATE_COMPLETED])";
                strRows = "(@applicationNumber, @adminNumber, @applicationType, @studyProgram, @researchMethod, @riskCategory, @status, @studentNumber, @supervisorNumber, @dateCompleted)";
                dictApplicationAttributes = new Dictionary<string, string>
                {
                    ["@applicationNumber"] = strApplicationNumber,
                    ["@adminNumber"] = strAdnimNumber,
                    ["@applicationType"] = strApplicationType,
                    ["@studyProgram"] = strStudyProgram,
                    ["@researchMethod"] = strResearchMethod,
                    ["@riskCategory"] = strRiskCategory,
                    ["@status"] = strStatus,
                    ["@studentNumber"] = strStudentNumber,
                    ["@supervisorNumber"] = strSupervisorNumber,
                    ["@dateCompleted"] = strDateCompleted
                };

                dbApplication.insertQuery(strTable, strRows, dictApplicationAttributes);

                if (radEthics.Checked)
                {
                    string strDegreeEthics = CommonMethods.checkedString(gpbDegreeEthics);
                    strDegreeEthics = (strDegreeEthics.Equals("Other")) ? txtEthicsOtherDegree.Text : strDegreeEthics;

                    strTable = "Ethics([PROJECT_TITLE], [APP_NUM], [DEGREE], [AIMS_AND_OBJECTIVES], [ABSTRACT], [DATA_REUSE], [COLLABORATION], [CONFLICT_OF_INTEREST_RESOLUTION]," +
                            "[EXPERTS], [VULNERABILITY_ADDRESSING], [POTENTIAL_HARM_ADDRESSING], [RESEARCH_LOCATIONS], [FORMAL_PERMISSION]," +
                            "[DATA_BEING_COLLECTED], [PARTICIPANT_SELECTION_CRITERIA], [INCENTIVES], [INFORMED_CONSENT_METHOD], [CONFIDENTIALITY_PROCESS]," +
                            "[ANONYMITY_PROCESS], [ANONYMITY_PUBLICATION], [ANONYMITY_ADDRESAL], [METHOS_OF_DATA_PROTECTION], [DATA_DISPOSAL])";
                    strRows = "(@projectTitle, @appNum, @degree, @aimsObjectives, @abstract, @dataReuse, @collaboration, @conflictOfInterestResolution," +
                               "@experts, @vulnerabilityAddressing, @potentialHarmAddressing, @researchLocations, @formalPermission," +
                               "@dataBeingCollected, @participantSelectionCriteria, @incentives, @informedConsentMethod, @confidentialityProcess," +
                               "@anonymityProcess, @anoanymityPublication, @anonymityAddresal, @methodsOfDataProtection, @dataDisposal)";
                    dictEthicsAttributes = new Dictionary<string, string>
                    {
                        ["@projectTitle"] = txtEthicsProjectTitle.Text,
                        ["@appNum"] = strApplicationNumber,
                        ["@degree"] = strDegreeEthics,
                        ["@aimsObjectives"] = rtbEthicsAimsAndObjectives.Text,
                        ["@abstract"] = rtbEthicsAbstractSummary.Text,
                        ["@dataReuse"] = CommonMethods.yesNo(gpbPermissionsEthics),
                        ["@collaboration"] = CommonMethods.yesNo(gpbAdditionalResearchersEthics),
                        ["@conflictOfInterestResolution"] = rtbExplainConflictResolution.Text,
                        ["@experts"] = CommonMethods.yesNo(gpbExperts),
                        ["@vulnerabilityAddressing"] = rtbAddressingVulnerabilities.Text,
                        ["@potentialHarmAddressing"] = rtbAddressPotentialRisks.Text,
                        ["@researchLocations"] = rtbResearchLocation.Text,
                        ["@formalPermission"] = CommonMethods.checkedString(gpbFormalPermissionLocation),
                        ["@dataBeingCollected"] = CommonMethods.cblToString(cblHowDataWillBeCollected),
                        ["@participantSelectionCriteria"] = rtbParticipantSelectionMathods.Text,
                        ["@incentives"] = CommonMethods.yesNo(gpbIncentivesEthics),
                        ["@informedConsentMethod"] = CommonMethods.checkedString(gpbInformedConcentGatheringMethod),
                        ["@confidentialityProcess"] = CommonMethods.yesNo(gpbConfidentialityProcess),
                        ["@anonymityProcess"] = CommonMethods.yesNo(gpbAnonymityProcess),
                        ["@anoanymityPublication"] = CommonMethods.yesNo(gpbAnonymityResulting),
                        ["@anonymityAddresal"] = rtbAnonymityConfidentialityMethod.Text,
                        ["@methodsOfDataProtection"] = rtbDataProtectionDuringResearch.Text,
                        ["@dataDisposal"] = CommonMethods.cblToString(clbdataDisposal)
                    };

                    dbEthics.insertQuery(strTable, strRows, dictEthicsAttributes);
                }
                else if (radWaiver.Checked)
                {
                    string strDegreeWaiver = CommonMethods.checkedString(gpbDegreeWaiver);
                    strDegreeWaiver = (strDegreeWaiver.Equals("Other")) ? txtEthicsOtherDegree.Text : strDegreeWaiver;

                    strTable = "Waiver([PROJECT_TITLE], [APP_NUM], [DEGREE], [AIMS_AND_OBJECTIVES], [ABSTRACT], [DATA_REUSE], [COLLABORATION])";
                    strRows = "(@projectTitle, @appNum, @degree, @aimsObjectives, @abstract, @dataReuse, @collaboration)";
                    dictWaiverAttributes = new Dictionary<string, string>
                    {
                        ["@projectTitle"] = txtWaiverProjectTitle.Text,
                        ["@appNum"] = strApplicationNumber,
                        ["@degree"] = strDegreeWaiver,
                        ["@aimsObjectives"] = rtbAimsAndObjectives.Text,
                        ["@abstract"] = rtbAbstractSummary.Text,
                        ["@dataReuse"] = CommonMethods.yesNo(gpbPermissionsWaiver),
                        ["@collaboration"] = CommonMethods.yesNo(rpbCollaborationWaiver)
                    };

                    dbWaiver.insertQuery(strTable, strRows, dictWaiverAttributes);
                }

                return true;
            }
            return false;
        }

        public bool cancelApplication()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel your application? This action is not reversable?", "Cancel Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string strTable, strConditional;
                Dictionary<string, string> dictApplicationAttributes, dictApplicationAssigmentAttributes, dictEthicsAttributes, dictWaiverAttributes;
                DB dbApplication = new DB();
                DB dbApplicationAssignment = new DB();
                DB dbWaiver = new DB();
                DB dbEthics = new DB();

                strTable = "ApplicationAssignment";
                strConditional = "WHERE APP_NUM = @applicationNumber";
                dictApplicationAssigmentAttributes = new Dictionary<string, string>
                {
                    ["@applicationNumber"] = strApplicationNumber
                };

                dbApplicationAssignment.deleteQuery(strTable, strConditional, dictApplicationAssigmentAttributes);

                strTable = "Ethics";
                strConditional = "WHERE APP_NUM = @applicationNumber";
                dictEthicsAttributes = new Dictionary<string, string>
                {
                    ["@applicationNumber"] = strApplicationNumber
                };

                dbEthics.deleteQuery(strTable, strConditional, dictEthicsAttributes);

                strTable = "Waiver";
                strConditional = "WHERE APP_NUM = @applicationNumber";
                dictWaiverAttributes = new Dictionary<string, string>
                {
                    ["@applicationNumber"] = strApplicationNumber
                };

                dbWaiver.deleteQuery(strTable, strConditional, dictWaiverAttributes);

                strTable = "Application";
                strConditional = "WHERE APP_NUM = @applicationNumber";
                dictApplicationAttributes = new Dictionary<string, string>
                {
                    ["@applicationNumber"] = strApplicationNumber
                };

                dbApplication.deleteQuery(strTable, strConditional, dictApplicationAttributes);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
