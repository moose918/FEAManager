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
    public partial class AdminMainMenuForm : Form
    {
        public AdminMainMenuForm()
        {
            InitializeComponent();
        }

        public static void loadForm(Form previousForm)
        {
            AdminMainMenuForm frmAdminMenu = new AdminMainMenuForm();
            frmAdminMenu.generateReport();
            previousForm.Visible = false;
            frmAdminMenu.ShowDialog(previousForm);
            previousForm.Visible = true;
        }
        private void generateReport()
        {
            //Get Number of applications
            int iApplicationNo = 0;

            string table, conditional, columns;
            Dictionary<string, string> dictAttributes;
            List<Dictionary<string, string>> resultSet;
            DB dbApplication = new DB();
            DB dbStudent = new DB();
            DB dbReviewer = new DB();
            DB dbSupervisor = new DB();
            DB dbEthics = new DB();
            DB dbWaiver = new DB();
            DB dbApplicationAssignment = new DB();
            DB dbQuerry = new DB();

            //Get Numbe of Applications
            table = "Application";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };
            resultSet = dbApplication.selectQuery(table, 1, conditional, dictAttributes);
            iApplicationNo = resultSet.Count;

            //Get Number of Students
            int iStudentNo = 0;
            table = "Student";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };
            resultSet = dbStudent.selectQuery(table, 1, conditional, dictAttributes);
            iStudentNo = resultSet.Count;

            //Get Number of Reviewers
            int iReviewerNo = 0;
            table = "Reviewer";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };
            resultSet = dbReviewer.selectQuery(table, 1, conditional, dictAttributes);
            iReviewerNo = resultSet.Count;

            //Get Number of Supervisors
            int iSupervisor = 0;
            table = "Supervisor";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };
            resultSet = dbSupervisor.selectQuery(table, 1, conditional, dictAttributes);
            iSupervisor = resultSet.Count;

            //Getting Reviewers with most / least amount of applications
            string strLeastReviewerApplications = "";
            string strMostReviewerApplications = "";

            table = "ApplicationAssignment, Reviewer";
            conditional = "where Reviewer.REVIEWER_NUM = ApplicationAssignment.REVIEWER_NUM group by ApplicationAssignment.REVIEWER_NUM order by Count(APP_NUM) desc";
            columns = "ApplicationAssignment.REVIEWER_NUM, min(Reviewer.FNAME) as [FNAME], min(Reviewer.LNAME) as [LNAME], Count(APP_NUM) as [NO_APPLICATIONS]";
            dictAttributes = new Dictionary<string, string> { };
            resultSet = dbQuerry.selectQuery(table, 4, conditional, dictAttributes, columns);
            for (int i = 0; i < resultSet.Count; i++)
            {
                string strFName = "";
                string strLName = "";
                if (i == 0 || (i != 0 && i == resultSet.Count - 1))
                {
                    foreach (var kv in resultSet[i])
                    {
                        strFName = (kv.Key.Equals("FNAME")) ? kv.Value : strFName;
                        strLName = (kv.Key.Equals("LNAME")) ? kv.Value : strLName;
                    }
                }

                strMostReviewerApplications = (i == 0) ? strFName + " " + strLName : strMostReviewerApplications;
                strLeastReviewerApplications = (i != 0 && i == resultSet.Count - 1) ? strFName + " " + strLName : strLeastReviewerApplications;
            }

            //Getting number of granted / rejected / pending applications
            int iGranted = 0;
            int iRejected = 0;
            int iPending = 0;

            table = "Application";
            conditional = "group by STATUS";
            columns = "STATUS, Count(*) as [NUMBER]";
            dictAttributes = new Dictionary<string, string> { };
            resultSet = dbQuerry.selectQuery(table, 2, conditional, dictAttributes, columns);
            
            for (int i = 0; i < resultSet.Count; i++) {

                Dictionary<string, string> resultRow = resultSet[i];

                string strStatus = resultRow["STATUS"];
                int iCount = Int32.Parse(resultRow["NUMBER"]);

                iGranted = (strStatus.Equals("Granted")) ? iCount : iGranted;
                iRejected = (strStatus.Equals("Rejected")) ? iCount : iRejected;
                iPending = (strStatus.Equals("Pending")) ? iCount : iPending;
            }

            //Get Number of Ethics Applications
            int iEthicsNo = 0;
            table = "Ethics";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };
            resultSet = dbSupervisor.selectQuery(table, 1, conditional, dictAttributes);
            iEthicsNo = resultSet.Count;

            //Get Number of Waiver
            int iWaiverNo = 0;
            table = "Waiver";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };
            resultSet = dbSupervisor.selectQuery(table, 1, conditional, dictAttributes);
            iWaiverNo = resultSet.Count;

            cbbMothYear.Text = DateTime.Now.ToString("MMMM yyyy");
            lblNoApplications.Text = iApplicationNo.ToString();
            lblNoStudents.Text = iStudentNo.ToString();
            lblNoEthics.Text = iEthicsNo.ToString();
            lblNoGranted.Text = iGranted.ToString();
            lblNoPending.Text = iPending.ToString();
            lblNoRejected.Text = iRejected.ToString();
            lblNoReviewers.Text = iReviewerNo.ToString();
            lblNoSupervisors.Text = iSupervisor.ToString();
            lblNoWaiver.Text = iWaiverNo.ToString();
            lblReviewerWithLeastApplications.Text = strLeastReviewerApplications;
            lblReviewerWithLeastApplications.Location = new Point((pnlReviewers.Size.Width - lblReviewerWithLeastApplications.Size.Width) / 2, lblReviewerWithLeastApplications.Location.Y);
            lblReviewerWithMostApplications.Text = strMostReviewerApplications;
            lblReviewerWithMostApplications.Location = new Point((pnlReviewers.Size.Width - lblReviewerWithMostApplications.Size.Width) / 2, lblReviewerWithMostApplications.Location.Y);

        }

        private void btnManageReviewers_Click(object sender, EventArgs e)
        {
            // load reviewers

            ManageRevierwerForm.loadForm(this);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm.loadForm(this);
        }

        private void btnManageApplications_Click(object sender, EventArgs e)
        {
            // load applications

            ManageApplicationForm.loadForm(this);
        }

    }
}
