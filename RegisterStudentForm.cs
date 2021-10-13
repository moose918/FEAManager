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
            // Validate info

            // check if student exists in DB

            int intSuccessful;
            string strTable, strRows, strStudentNum, strFName, strLName, strEmail, strPasswd, strDOB;
            Dictionary<string, string> dictAttributes;
            DB dbStudent = new DB();

            strStudentNum = txtUsername.Text;
            strFName = txtFName.Text;
            strLName = txtLName.Text;
            strEmail = mtxtEmail.Text;
            MessageBox.Show(strEmail);
            strPasswd = mtxtPassword.Text;
            
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.CustomFormat = "dd/mm/yyyy";
            strDOB = dtpDOB.Text;

            strTable = "Student([STU_NUM], [FNAME], [LNAME], [EMAIL], [PASSWORD], [DOB])";
            strRows = "(@studentNum, @fName, @lName, @email, @passwd, @dob)";
            dictAttributes = new Dictionary<string, string>
            {
                ["@studentNum"] = strStudentNum,
                ["@fName"] = strFName,
                ["@lName"] = strLName,
                ["@email"] = strEmail,
                ["@passwd"] = strPasswd,
                ["@dob"] = strDOB,
            };

            dbStudent.insertQuery(strTable, strRows, dictAttributes);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        public static void loadForm(Form previousForm)
        {
            RegisterStudentForm frmLogin = new RegisterStudentForm();
            previousForm.Visible = false;
            frmLogin.ShowDialog(previousForm);
            previousForm.Visible = true;
        }
    }
}
