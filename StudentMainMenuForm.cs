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
        public StudentMainMenuForm()
        {
            InitializeComponent();
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateInformation()
        {
            bool valid = true;
            valid = CommonMethods.validateTextBox(txtFName, "first name") && valid;
            valid = CommonMethods.validateTextBox(txtLName, "last name") && valid;
            valid = CommonMethods.validateTextBox(mtxtTelephone, "telephone") && valid;
            valid = CommonMethods.validateTextBox(cmbStudyProgram, "study program") && valid;
            valid = CommonMethods.validateTextBox(mtxtPassword, "password") && valid;
            valid = CommonMethods.validateTextBox(mtxtEmail, "email") && valid;
            valid = CommonMethods.validateTextBox(txtStudentNumber, "student number") && valid;
            valid = CommonMethods.validateTextBox(txtStudentNumber, "student number", 13) && valid;
            valid = CommonMethods.validateRadioButtonsInGroup(grpTitle, "title") && valid;

            return valid;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbcStudentMenu.SelectedTab == tbcStudentMenu.TabPages[tbcStudentMenu.Text])
            {
                //Validate information
                bool validInformation = ValidateInformation();

                if (validInformation)
                {
                    //Update student information

                    string strTable, strParams, strConditional;
                    Dictionary<string, string> dictAttributes;
                    DB dbReviewer = new DB();

                    strTable = "Student";
                    strParams = "[STU_NUM] = @stuNumber, [FNAME] = @fName, [LNAME] = @lName, [EMAIL] = @email, [PASSWORD] = @password, [TELEPHONE] = @telephone, [STUDY_PROGRAM] = @studyProgram, [TITLE] = @title";
                    strConditional = "WHERE STU_NUM = @stuNumber";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@stuNumber"] = txtStudentNumber.Text,
                        ["@fName"] = txtFName.Text,
                        ["@lName"] = txtLName.Text,
                        ["@email"] = mtxtEmail.Text,
                        ["@password"] = mtxtPassword.Text,
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
                
            }
        }

        public static void loadForm(Form previousForm, String strStudentNumber)
        {
            StudentMainMenuForm frmStudentMainMenu = new StudentMainMenuForm();
            frmStudentMainMenu.loadDetails(strStudentNumber);
            previousForm.Visible = false;
            frmStudentMainMenu.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        private void loadDetails(String strStudentNumber)
        {
            string table, conditional;
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
                        //txtStudentNumber.Text = kv.Value;
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
                MessageBox.Show(" DOES NOT EXIST");
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
    }
}
