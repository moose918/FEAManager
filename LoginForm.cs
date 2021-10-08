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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string table, conditional;
            Dictionary<string, string> dictAttributes, resultRow;
            List<Dictionary<string, string>> resultSet;
            DB dbLogin = new DB();

            string username = txtUsername.Text;
            string passwd = mtxtPassword.Text;

            // Validate input

            // if valid, check DB of respective user type

            // load respective form if correct info is given

            // adminLogin


            if (rdbAdmin.Checked)
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
            if (rdbStudent.Checked)
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

                if (resultSet.Count > 0)
                {
                    resultRow = resultSet[0];
                    foreach (var kv in resultRow)
                    {
                        output += kv.Key + " : " + kv.Value + "\n";
                    }
                    MessageBox.Show(output);

                    StudentMainMenuForm.loadForm(this);
                }
                else
                {
                    MessageBox.Show(" DOES NOT EXIST");
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
            previousForm.Visible = false;
            frmLogin.ShowDialog(previousForm);
            previousForm.Visible = true;
        }
    }
}
