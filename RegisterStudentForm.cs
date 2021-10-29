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
    public partial class RegisterStudentForm : Form
    {
        public RegisterStudentForm()
        {
            InitializeComponent();
        }

        private bool ValidateInformation()
        {
            bool valid = true;
            valid = CommonMethods.validateTextBox(txtFName, "first name") && valid;
            valid = CommonMethods.validateTextBox(txtLName, "last name") && valid;
            valid = CommonMethods.validateDOB(dtpDOB) && valid;
            valid = CommonMethods.validateTextBox(mtxtTelephone, "telephone number") && valid;
            valid = CommonMethods.validateTextBox(txtUsername, "username") && valid;
            valid = CommonMethods.validateTextBox(txtUsername, "username", 13) && valid;
            valid = CommonMethods.validateTextBox(mtxtPassword, "password") && valid;
            valid = CommonMethods.validateTextBox(mtxtEmail, "email address") && valid;
            valid = CommonMethods.validateTextBox(cmbStudyProgram, "study program") && valid;
            valid = CommonMethods.validateRadioButtonsInGroup(grpTitle, "title") && valid;

            return valid;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validate information
            bool validInformation = ValidateInformation();

            if (validInformation)
            {
                int intSuccessful;
                string strTable, strRows, strConditional, strStudentNum, strFName, strLName, strEmail, strPasswd, strDOB, strTelephone, strStudyProgram, strTitle;
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

                // check if student exists in DB
                bool exists = false;

                strTable = "Student";
                strConditional = "WHERE [STU_NUM] = @stuNum";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@stuNum"] = strStudentNum
                };

                resultSet = dbStudent.selectQuery(strTable, 8, strConditional, dictAttributes);

                if (resultSet.Count > 0)
                {
                    exists = true;
                    MessageBox.Show(strStudentNum + " already exists. They can not register again");
                    CommonMethods.clearForm(this);
                }
                else
                {
                    exists = false;
                }

                if (!exists)
                {
                    // load respective form if correct info is given

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

                    MessageBox.Show(strStudentNum + " has been created");
                    StudentMainMenuForm.loadForm(this, strStudentNum);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm.loadForm(this);
        }

        public static void loadForm(Form previousForm)
        {
            RegisterStudentForm frmLogin = new RegisterStudentForm();
            previousForm.Visible = false;
            frmLogin.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            CommonMethods.passwordControl(mtxtPassword);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CommonMethods.clearForm(this);
        }

        private void cmbStudyProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
