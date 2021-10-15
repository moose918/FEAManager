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

        private bool ValidateInformation(TextBox txtUsername, MaskedTextBox mtxtPassword, GroupBox groupBox)
        {
            bool valid = true;
            valid = CommonMethods.validateTextBox(txtUsername, "username") && valid;

            //Determing correct length
            int length = -1;
            foreach (RadioButton radio in groupBox.Controls)
            {length = (radio.Text.Equals("&Admin") && radio.Checked) ? 15 : (radio.Text.Equals("&Student") && radio.Checked) ? 13 : length;}
            valid = CommonMethods.validateTextBox(txtUsername, "username", length) && valid;
            valid = CommonMethods.validateTextBox(mtxtPassword, "password") && valid;
            valid = CommonMethods.validateRadioButtonsInGroup(groupBox, "user type") && valid;
            return valid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate input

            bool validInformation = ValidateInformation(txtUsername, mtxtPassword, grpUserType);

            // if valid, check DB of respective user type

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

                    resultSet = dbLogin.selectQuery(table, 5, conditional, dictAttributes);

                    string output = "";

                    // load respective form if correct info is given

                    if (resultSet.Count > 0)
                    {
                        resultRow = resultSet[0];
                        foreach (var kv in resultRow)
                        {
                            output += kv.Key + " : " + kv.Value + "\n";
                        }
                        MessageBox.Show(output);

                        AdminMainMenuForm.loadForm(this);
                    }
                    else
                    {
                        MessageBox.Show(" DOES NOT EXIST");
                    }


                }

                // studentLogin
                if (radStudent.Checked)
                {
                    table = "Student";
                    conditional = "WHERE [STU_NUM] = @studentNum AND [PASSWORD] = @passwd";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@studentNum"] = username,
                        ["@passwd"] = passwd
                    };

                    resultSet = dbLogin.selectQuery(table, 6, conditional, dictAttributes);

                    string output = "";

                    // load respective form if correct info is given

                    if (resultSet.Count > 0)
                    {
                        resultRow = resultSet[0];
                        foreach (var kv in resultRow)
                        {
                            output += kv.Key + " : " + kv.Value + "\n";
                        }
                        MessageBox.Show(output);

                        StudentMainMenuForm.loadForm(this, username);
                    }
                    else
                    {
                        MessageBox.Show(" DOES NOT EXIST");
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // validate

            // laod form
            RegisterStudentForm.loadForm(this);
        }

        public static void loadForm (Form previousForm)
        {
            LoginForm frmLogin = new LoginForm();
            frmLogin.clearForm();
            previousForm.Visible = false;
            frmLogin.ShowDialog(previousForm);
            previousForm.Visible = true;
           
        }

        private void clearForm()
        {
            radAdmin.Checked = false;
            radStudent.Checked = false;
            txtUsername.Text = "";
            mtxtPassword.Text = "";
            mtxtPassword.PasswordChar = '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            CommonMethods.passwordControl(mtxtPassword);
        }
    }
}
