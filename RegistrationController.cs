using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEAManager
{
    class RegistrationController
    {

        private DateTimePicker dtpDOB;
        private MaskedTextBox mtxtTelephone;
        private TextBox txtLName;
        private TextBox txtFName;
        private MaskedTextBox mtxtPassword;
        private ComboBox cmbStudyProgram;
        private MaskedTextBox mtxtEmail;
        private TextBox txtUsername;
        private GroupBox grpTitle;

        public string strStudentNum;

        public RegistrationController() { }

        private bool ValidateInformation()
        {
            bool valid = true;
            valid = CommonMethods.validateTextBox(txtFName, "first name") && valid;
            valid = CommonMethods.validateTextBox(txtLName, "last name") && valid;
            valid = CommonMethods.validateDOB(dtpDOB) && valid;
            valid = CommonMethods.validateTextBox(mtxtTelephone, "telephone number") && valid;
            bool validUsername = CommonMethods.validateTextBox(txtUsername, "username");
            valid = validUsername && valid;
            valid = CommonMethods.validateTextBox(txtUsername, "username", CommonMethods.typeStudent) && valid;
            valid = CommonMethods.validateTextBox(mtxtPassword, "password") && valid;
            valid = CommonMethods.validateTextBox(mtxtEmail, "email address") && valid;
            valid = CommonMethods.validateTextBox(cmbStudyProgram, "study program") && valid;
            valid = CommonMethods.validateRadioButtonsInGroup(grpTitle, "title") && valid;

            if (validUsername)
            {
                string strTable, strConditional;
                Dictionary<string, string> dictAttributes;
                List<Dictionary<string, string>> resultSet;
                DB dbStudent = new DB();

                strTable = "Student";
                strConditional = "WHERE [STU_NUM] = @stuNum";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@stuNum"] = txtUsername.Text
                };

                resultSet = dbStudent.selectQuery(strTable, 1, strConditional, dictAttributes);
                bool exists = (resultSet.Count != 0);
                valid = valid && !exists;

                if (exists)
                {
                    MessageBox.Show(strStudentNum + " already exists. They can not register again", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
            }

            return valid;
        }

        public bool registerStudent(DateTimePicker dtpDOB, MaskedTextBox mtxtTelephone, TextBox txtLName, TextBox txtFName,
                    MaskedTextBox mtxtPassword, ComboBox cmbStudyProgram, MaskedTextBox mtxtEmail, TextBox txtUsername, GroupBox grpTitle)
        {
            this.dtpDOB = dtpDOB;
            this.mtxtTelephone = mtxtTelephone;
            this.txtLName = txtLName;
            this.txtFName = txtFName;
            this.mtxtPassword = mtxtPassword;
            this.cmbStudyProgram = cmbStudyProgram;
            this.mtxtEmail = mtxtEmail;
            this.txtUsername = txtUsername;
            this.grpTitle = grpTitle;

            bool validInformation = ValidateInformation();
            
            if (validInformation)
            {
                string strTable, strRows, strConditional, strFName, strLName, strEmail, strPasswd, strDOB, strTelephone, strStudyProgram, strTitle;
                Dictionary<string, string> dictAttributes;
                List<Dictionary<string, string>> resultSet;
                DB dbStudent = new DB();

                strStudentNum = txtUsername.Text;
                strFName = txtFName.Text;
                strLName = txtLName.Text;
                strEmail = mtxtEmail.Text;
                strPasswd = mtxtPassword.Text;
                strTelephone = mtxtTelephone.Text;
                strStudyProgram = cmbStudyProgram.Text;
                strDOB = dtpDOB.Value.ToString("dd/MM/yyyy");
                strTitle = CommonMethods.checkedString(grpTitle);

                strTable = "Student([STU_NUM], [FNAME], [LNAME], [EMAIL], [PASSWORD], [DOB], [TELEPHONE], [STUDY_PROGRAM], [TITLE])";
                strRows = "(@studentNum, @fName, @lName, @email, @passwd, @dob, @telephone, @studyProgram, @title)";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@studentNum"] = strStudentNum,
                    ["@fName"] = strFName,
                    ["@lName"] = strLName,
                    ["@email"] = strEmail,
                    ["@passwd"] = strPasswd,
                    ["@dob"] = strDOB,
                    ["@telephone"] = strTelephone,
                    ["@studyProgram"] = strStudyProgram,
                    ["@title"] = strTitle
                };

                dbStudent.insertQuery(strTable, strRows, dictAttributes);
                return true;
            }

            return false;
        }
    }
}
