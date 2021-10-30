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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool ValidateInformation()
        {
            bool valid = true;
            valid = CommonMethods.validateTextBox(txtUsername, "username") && valid;
            valid = CommonMethods.validateTextBox(mtxtPassword, "password") && valid;
            valid = CommonMethods.validateRadioButtonsInGroup(grpUserType, "user type") && valid;
            return valid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validInformation = ValidateInformation();
            if (validInformation)
            {
                string table, conditional;
                Dictionary<string, string> dictAttributes, resultRow;
                List<Dictionary<string, string>> resultSet;
                DB dbLogin = new DB();

                string username = txtUsername.Text;
                string passwd = mtxtPassword.Text;


                if (radAdmin.Checked)
                {
                    table = "Admin";
                    conditional = "WHERE [ADMIN_NUM] = @adminNum AND [PASSWORD] = @passwd";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@adminNum"] = username,
                        ["@passwd"] = passwd
                    };
                    resultSet = dbLogin.selectQuery(table, 1, conditional, dictAttributes);

                    if (resultSet.Count != 0)
                    {
                        CommonMethods.myConfirmationMessageBox("Admin Login Successful");
                        AdminMainMenuForm.loadForm(this);
                    }
                    else
                    {
                        MessageBox.Show("Either the password or username was incorrect.", "Login Faliure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radStudent.Checked)
                {
                    table = "Student";
                    conditional = "WHERE [STU_NUM] = @studentNum AND [PASSWORD] = @passwd";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@studentNum"] = username,
                        ["@passwd"] = passwd
                    };

                    resultSet = dbLogin.selectQuery(table, 1, conditional, dictAttributes);

                    if (resultSet.Count != 0)
                    {
                        CommonMethods.myConfirmationMessageBox("Student  Login Successful");
                        StudentMainMenuForm.loadForm(this, username);
                    }
                    else
                    {
                        MessageBox.Show("Either the password or username was incorrect.", "Login Faliure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterStudentForm.loadForm(this);
        }

        public static void loadForm (Form previousForm)
        {
            LoginForm frmLogin = new LoginForm();
            previousForm.Visible = false;
            frmLogin.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        public void preliminaryActions()
        {
            clearForm();
        }

        private void clearForm()
        {
            CommonMethods.clearForm(this);
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            CommonMethods.passwordControl(mtxtPassword);
        }
    }
}
