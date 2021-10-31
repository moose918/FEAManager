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
            RegistrationController registrationController = new RegistrationController();
            bool validRegistration = registrationController.registerStudent(dtpDOB, mtxtTelephone, txtLName, txtFName, mtxtPassword, cmbStudyProgram, mtxtEmail, txtUsername, grpTitle);

            if (validRegistration)
            {
                CommonMethods.myConfirmationMessageBox(registrationController.strStudentNum + " has been created");
                StudentMainMenuForm.loadForm(this, registrationController.strStudentNum);
            }
            else
            {
                CommonMethods.myConfirmationMessageBox("Unsuccesful Registration");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void loadForm(Form previousForm)
        {
            RegisterStudentForm frmLogin = new RegisterStudentForm();
            CommonMethods.getStudyPrograms(frmLogin.cmbStudyProgram);
            previousForm.Visible = false;
            frmLogin.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        public static void loadForm(LoginForm previousForm)
        {
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
    }
}
