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
            /**
             * Login button
             * User interface creates LoginController
             * Login Controller handles input validation and login validation
             * If the login is valid, then the respective user main page will be loaded
             * **/

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
            else
            {
                CommonMethods.myConfirmationMessageBox("Unsuccesful Login");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Opens registration form.
            RegisterStudentForm.loadForm(this);
        }

        public void preliminaryActions()
        {
            /**
             * Preliminary actions
             * The tasks that need to be done before this form can be visible again.
             * Called by other forms that use this form as the previous form
             * So the AdminMainMenu and StudentMainMenu
             * **/
            clearForm();
        }

        private void clearForm()
        {
            //Removing edits on all groupBoxes, textboxes etc.
            CommonMethods.clearForm(this);
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            //Button to remove that mask on the password
            CommonMethods.passwordControl(mtxtPassword);
        }
    }
}
