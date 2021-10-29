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
        private String strStudentNumber = "";

        public StudentMainMenuForm()
        {
            InitializeComponent();
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {

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
                valid = CommonMethods.validateTextBox(txtStudentNumber, "student number", 13) && valid;
                valid = CommonMethods.validateRadioButtonsInGroup(grpTitle, "title") && valid;
                valid = CommonMethods.validateDOB(dtpDetailsDateOfBirth) && valid;
            }
            else
            {
                valid = CommonMethods.validateRadioButtonsInGroup(gpbApplicationType, "application type") && valid;
                valid = CommonMethods.validateRadioButtonsInGroup(gpbCollectingData, "last name") && valid;
                valid = CommonMethods.validateRadioButtonsInGroup(gpbStudyProgram, "telephone") && valid;
                valid = CommonMethods.validateTextBox(txtSupervisorFirstName, "supervisor\'s first name") && valid;
                valid = CommonMethods.validateTextBox(txtSupervisorFirstName, "supervisor\'s last name") && valid;
                valid = CommonMethods.validateTextBox(mtxtSupervisorEmail, "supervisor\'s email") && valid;
                valid = CommonMethods.validateTextBox(mtxtSupervisorCellphone, "supervisor\'s cellphone") && valid;
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
                    valid = CommonMethods.validateRadioButtonsInGroup(rpbCollaborationWaiver, "indication of whether this application is a multi-student application or not.") && valid;
                }
            }

            return valid;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbcStudentMenu.SelectedIndex == 0)
            {
                //Validate information
                bool validInformation = ValidateInformation(0);

                if (validInformation)
                {
                    //Update student information

                    string strTable, strParams, strConditional;
                    Dictionary<string, string> dictAttributes;
                    DB dbReviewer = new DB();

                    strTable = "Student";
                    strParams = "[STU_NUM] = @stuNumber, [FNAME] = @fName, [LNAME] = @lName, [EMAIL] = @email, [PASSWORD] = @password, [DOB] = @dob, [TELEPHONE] = @telephone, [STUDY_PROGRAM] = @studyProgram, [TITLE] = @title";
                    strConditional = "WHERE STU_NUM = @stuNumber";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@stuNumber"] = txtStudentNumber.Text,
                        ["@fName"] = txtFName.Text,
                        ["@lName"] = txtLName.Text,
                        ["@email"] = mtxtEmail.Text,
                        ["@password"] = mtxtPassword.Text,
                        ["@dob"] = dtpDetailsDateOfBirth.Value.ToString("dd/MM/yyyy"),
                        ["@telephone"] = mtxtTelephone.Text,
                        ["@studyProgram"] = cmbStudyProgram.Text,
                        ["@title"] = CommonMethods.checkedString(grpTitle)
                    };

                    dbReviewer.updateQuery(strTable, strParams, strConditional, dictAttributes);

                    loadDetails(txtStudentNumber.Text);
                }
            }
            else
            {
                string strApplicationNumber = genereateUniqueApplicationNumber();
                string strAdnimNumber = getAdminNumber();
                string strApplicationType = CommonMethods.checkedString(gpbApplicationType);
                string strStudyProgram = CommonMethods.checkedString(gpbStudyProgram);
                string strResearchMethod = CommonMethods.checkedString(gpbCollectingData);
                string strRiskCategory = CommonMethods.checkedString(gpbApplicationRiskCategory);
                string strSupervisorNumber = getSupervisorNumber();
                string strStatus = "Pending";
                string strSupervisorfName = txtSupervisorFirstName.Text;
                string strSupervisorlName = txtSupervisorLastName.Text;
                string strSupervisorEmail = mtxtSupervisorEmail.Text;
                string strSupervisorTelephone = mtxtSupervisorCellphone.Text;
                string strDateCompleted = dtpDateCompleted.Value.ToString("dd/MM/yyyy");

                bool validInformation = ValidateInformation(1);

                //bool validInformation = true;

                if (validInformation)
                {
                    string strTable, strRows, strConditional;
                    Dictionary<string, string> dictAttributes;
                    List<Dictionary<string, string>> resultSet;
                    DB dbStudent = new DB();
                    DB dbSupervisor = new DB();
                    DB dbEthics = new DB();
                    DB dbWaiver = new DB();

                    //Checking that this supervisor does not already exist in the database. 

                    strTable = "Supervisor";
                    strConditional = "WHERE [SUPERVISOR_NUM] = @supervisorNumber";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@supervisorNumber"] = strSupervisorNumber
                    };

                    resultSet = dbSupervisor.selectQuery(strTable, 1, strConditional, dictAttributes);

                    if (resultSet.Count <= 0)
                    {
                        strTable = "Supervisor([SUPERVISOR_NUM], [FNAME], [LNAME], [EMAIL], [TELEPHONE])";
                        strRows = "(@supervisorNumber, @supervisorFirstName, @supervisorLastName, @supervisorEmail, @supervisorTelephone)";
                        dictAttributes = new Dictionary<string, string>
                        {
                            ["@supervisorNumber"] = strSupervisorNumber,
                            ["@supervisorFirstName"] = strSupervisorfName,
                            ["@supervisorLastName"] = strSupervisorlName,
                            ["@supervisorEmail"] = strSupervisorEmail,
                            ["@supervisorTelephone"] = strSupervisorTelephone
                        };

                        dbStudent.insertQuery(strTable, strRows, dictAttributes);
                    }

                    strTable = "Application([APP_NUM], [ADMIN_NUM], [APP_TYPE], [STUDY_PROGRAM], [RESEARCH_METHOD], [RISK_CATEGORY], [STATUS], [STU_NUM], [SUPERVISOR_NUM], [DATE_COMPLETED])";
                    strRows = "(@applicationNumber, @adminNumber, @applicationType, @studyProgram, @researchMethod, @riskCategory, @status, @studentNumber, @supervisorNumber, @dateCompleted)";
                    dictAttributes = new Dictionary<string, string>
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

                    dbStudent.insertQuery(strTable, strRows, dictAttributes);

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
                        dictAttributes = new Dictionary<string, string>
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

                        dbEthics.insertQuery(strTable, strRows, dictAttributes);
                    }
                    else if (radWaiver.Checked)
                    {
                        string strDegreeWaiver = CommonMethods.checkedString(gpbDegreeWaiver);
                        strDegreeWaiver = (strDegreeWaiver.Equals("Other")) ? txtEthicsOtherDegree.Text : strDegreeWaiver;

                        strTable = "Waiver([PROJECT_TITLE], [APP_NUM], [DEGREE], [AIMS_AND_OBJECTIVES], [ABSTRACT], [DATA_REUSE], [COLLABORATION])";
                        strRows = "(@projectTitle, @appNum, @degree, @aimsObjectives, @abstract, @dataReuse, @collaboration)";
                        dictAttributes = new Dictionary<string, string>
                        {
                            ["@projectTitle"] = txtWaiverProjectTitle.Text,
                            ["@appNum"] = strApplicationNumber,
                            ["@degree"] = strDegreeWaiver,
                            ["@aimsObjectives"] = rtbAimsAndObjectives.Text,
                            ["@abstract"] = rtbAbstractSummary.Text,
                            ["@dataReuse"] = CommonMethods.yesNo(gpbPermissionsWaiver),
                            ["@collaboration"] = CommonMethods.yesNo(rpbCollaborationWaiver)
                        };

                        dbWaiver.insertQuery(strTable, strRows, dictAttributes);
                    }

                    MessageBox.Show("Application " + strApplicationNumber + " has been created");
                }
            }
        }

        private String genereateUniqueApplicationNumber()
        {
            string table, conditional;
            Dictionary<string, string> dictAttributes, resultRow;
            List<Dictionary<string, string>> resultSet;
            DB dbLogin = new DB();
            String applicationNumber = "APP" + CommonMethods.generateDigits();

            table = "Application";
            conditional = "WHERE [APP_NUM] = @applicationNumber";
            dictAttributes = new Dictionary<string, string>
            {
                ["@applicationNumber"] = applicationNumber
            };

            resultSet = dbLogin.selectQuery(table, 8, conditional, dictAttributes);

            while (resultSet.Count > 0)
            {
                applicationNumber = "APP" + CommonMethods.generateDigits();
                resultSet = dbLogin.selectQuery(table, 8, conditional, dictAttributes);
            }
            return applicationNumber;
        }

        public static void loadForm(Form previousForm, String strStudentNumber)
        {
            StudentMainMenuForm frmStudentMainMenu = new StudentMainMenuForm();
            frmStudentMainMenu.loadDetails(strStudentNumber);
            frmStudentMainMenu.strStudentNumber = strStudentNumber;
            previousForm.Visible = false;
            frmStudentMainMenu.initializePanels();
            frmStudentMainMenu.setAdminName();
            frmStudentMainMenu.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        private void setAdminName()
        {
            String adminName = getAdminName();
            if (!adminName.Equals(""))
            {
                lblAdminName.Text = adminName;
            }
            else
            {
                lblAdminName.Text = "\"\"";
            }
        }

        private void initializePanels()
        {
            pnlRiskCategoryTable.Visible = false;
            pnlRiskCategoryTable.Location = new Point(445, 21);
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

        private string getAdminNumber()
        {
            string table, conditional;
            Dictionary<string, string> dictAttributes, resultRow;
            List<Dictionary<string, string>> resultSet;
            DB dbLogin = new DB();

            table = "Admin";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };

            resultSet = dbLogin.selectQuery(table, 5, conditional, dictAttributes);

            if (resultSet.Count > 0)
            {
                resultRow = resultSet[0];
                String adminNumber = "";
                foreach (var kv in resultRow)
                {
                    if (kv.Key.Equals("ADMIN_NUM"))
                    {
                        adminNumber = kv.Value;
                    }
                }
                return adminNumber;
            }
            else
            {
                return "";
            }
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
                ["@fName"] = txtSupervisorFirstName.Text,
                ["@lName"] = txtSupervisorLastName.Text
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

        private string getAdminName() 
        {
            string table, conditional;
            Dictionary<string, string> dictAttributes, resultRow;
            List<Dictionary<string, string>> resultSet;
            DB dbLogin = new DB();

            table = "Admin";
            conditional = "";
            dictAttributes = new Dictionary<string, string>{};

            resultSet = dbLogin.selectQuery(table, 5, conditional, dictAttributes);

            if (resultSet.Count > 0)
            {
                resultRow = resultSet[0];
                String fName = "", lName = "";
                foreach (var kv in resultRow)
                {
                    if (kv.Key.Equals("FNAME"))
                    {
                        fName = kv.Value;
                    }
                    if (kv.Key.Equals("LNAME"))
                    {
                        lName = kv.Value;
                    }
                }
                return fName + " " + lName;
            }
            else
            {
                return "";
            }
        }

        private void loadDetails(String strStudentNumber)
        {
            string table, conditional, strSupervisorNumber = "";
            Dictionary<string, string> dictAttributes, resultRow;
            List<Dictionary<string, string>> resultSet;
            DB dbLogin = new DB();

            table = "Student";
            conditional = "WHERE [STU_NUM] = @studentNum";
            dictAttributes = new Dictionary<string, string>
            {
                ["@studentNum"] = strStudentNumber
            };

            resultSet = dbLogin.selectQuery(table, 9, conditional, dictAttributes);

            if (resultSet.Count > 0)
            {
                resultRow = resultSet[0];
                foreach (var kv in resultRow)
                {
                    if (kv.Key.Equals("STU_NUM"))
                    {
                        txtStudentNumber.Text = kv.Value;
                    }
                    if (kv.Key.Equals("FNAME"))
                    {
                        txtFName.Text = kv.Value;
                    }
                    if (kv.Key.Equals("LNAME"))
                    {
                        txtLName.Text = kv.Value;
                    }
                    if (kv.Key.Equals("EMAIL"))
                    {
                        mtxtEmail.Text = kv.Value;
                    }
                    if (kv.Key.Equals("PASSWORD"))
                    {
                        mtxtPassword.Text = kv.Value;
                    }
                    if (kv.Key.Equals("DOB"))
                    {
                        dtpDetailsDateOfBirth.Value = DateTime.Parse(kv.Value);
                    }
                    if (kv.Key.Equals("TELEPHONE"))
                    {
                        mtxtTelephone.Text = kv.Value;
                    }
                    if (kv.Key.Equals("STUDY_PROGRAM"))
                    {
                        cmbStudyProgram.Text = kv.Value;
                    }
                    if (kv.Key.Equals("TITLE"))
                    {
                        foreach (RadioButton radioButton in grpTitle.Controls)
                        {
                            if (radioButton.Text.Equals(kv.Value))
                            {
                                radioButton.Checked = true;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Student DOES NOT EXIST");
            }

            table = "Application";
            conditional = "WHERE [STU_NUM] = @studentNum";
            dictAttributes = new Dictionary<string, string>
            {
                ["@studentNum"] = strStudentNumber
            };

            resultSet = dbLogin.selectQuery(table, 9, conditional, dictAttributes);

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
                        if (kv.Value.Equals("Colecting Data"))
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

                table = "Supervisor";
                conditional = "WHERE [SUPERVISOR_NUM] = @supervisorNumber";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@supervisorNumber"] = strSupervisorNumber
                };

                resultSet = dbLogin.selectQuery(table, 3, conditional, dictAttributes);

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
                else
                {
                    MessageBox.Show("Supervisor DOES NOT EXIST");
                }
            }
            else
            {
                MessageBox.Show("Application DOES NOT EXIST");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm.loadForm(this);
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
    }
}
