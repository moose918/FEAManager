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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            /**
             * Register / Create button
             * User interface creates RegistrationController
             * Registration Controller handles input validation and registration validation
             * If the Registration is valid, then the student main page will be loaded and displayed.
             * **/
            RegistrationController registrationController = new RegistrationController();
            bool validRegistration = registrationController.registerStudent(dtpDOB, mtxtTelephone, txtLName, txtFName, mtxtPassword, cmbStudyProgram, mtxtEmail, txtUsername, grpTitle);

            if (validRegistration)
            {
                CommonMethods.myConfirmationMessageBox(registrationController.strStudentNum + " has been created");
                StudentMainMenuForm.loadForm(this, registrationController.strStudentNum);
                this.Close();
            }
            else
            {
                CommonMethods.myConfirmationMessageBox("Unsuccesful Registration");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            /**
             * Load form was called by the previous form the called for this form.
             * Hence that form will make itself visible after this form closes
             * **/
            this.Close();
        }

        public static void loadForm(LoginForm previousForm)
        {
            /**
             * Method called by LoginForm
             * Will load this form on top of the LoginForm
             * Makes the Login form invisible.
             * When this form closes, the LoginForm will be made visible.
             * Preliminary functions of the login form are also called.
             * **/
            RegisterStudentForm frmLogin = new RegisterStudentForm();
            CommonMethods.getStudyPrograms(frmLogin.cmbStudyProgram);
            previousForm.preliminaryActions();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want a student number to be automatically generated for you?", "Generate Student Number", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtUsername.Text = CommonMethods.generateUniqueID(CommonMethods.typeStudent);
                CommonMethods.myConfirmationMessageBox("You can use student number: " + txtUsername.Text);
            }
            else
            {
                CommonMethods.myConfirmationMessageBox("Student number generation aborted.");
            }
        }
    }
}
