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
            LoginController loginController = new LoginController();
            bool validLogin = loginController.validLogin(txtUsername, mtxtPassword, grpUserType);

            if (validLogin)
            {
                if (radAdmin.Checked)
                {
                    CommonMethods.myConfirmationMessageBox("Admin Login Successful");
                    AdminMainMenuForm.loadForm(this);
                }
                else if (radStudent.Checked)
                {
                    CommonMethods.myConfirmationMessageBox("Student Login Successful");
                    StudentMainMenuForm.loadForm(this, loginController.strUsername);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CommonMethods.timeToNearestXMinute(5);
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
