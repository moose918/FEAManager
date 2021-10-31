using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace FEAManager
{
    class ReportController
    {
        private Label lblNoSupervisors;
        private Label lblNoReviewers;
        private Label lblNoStudents;
        private Label lblNoApplications;
        private Label lblReviewerWithMostApplications;
        private Label lblReviewerWithLeastApplications;
        private Label lblNoRejected;
        private Label lblNoPending;
        private Label lblNoGranted;
        private Label lblNoEthics;
        private Label lblNoWaiver;
        private Panel pnlReviewers;
        private ComboBox cbbMonthYear;

        public ReportController(Label lblNoSupervisors, Label lblNoReviewers, Label lblNoStudents, Label lblReviewerWithMostApplications, Label lblReviewerWithLeastApplications,
                                Label lblNoRejected, Label lblNoPending, Label lblNoGranted, Label lblNoEthics, Label lblNoWaiver, Label lblNoApplications,
                                Panel pnlReviewers, ComboBox cbbMonthYear)
        {
            this.lblNoSupervisors = lblNoSupervisors;
            this.lblNoReviewers = lblNoReviewers;
            this.lblNoStudents = lblNoStudents;
            this.lblNoApplications = lblNoApplications;
            this.lblReviewerWithMostApplications = lblReviewerWithMostApplications;
            this.lblReviewerWithLeastApplications = lblReviewerWithLeastApplications;
            this.lblNoRejected = lblNoRejected;
            this.lblNoPending = lblNoPending;
            this.lblNoGranted = lblNoGranted;
            this.lblNoEthics = lblNoEthics;
            this.lblNoWaiver = lblNoWaiver;
            this.pnlReviewers = pnlReviewers;
            this.cbbMonthYear = cbbMonthYear;
        }

        public void gererateDefultReport()
        {
            getTimePeriods();

            //Get Number of applications
            int iApplicationNo = 0;

            string table, conditional, columns, strParams;
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
            DB dbReport = new DB();

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

            for (int i = 0; i < resultSet.Count; i++)
            {

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

            //cbbMothYear.Text = DateTime.Now.ToString("MMMM yyyy");\

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

            //Check if report already exists in database.
            string strTimePeroid = CommonMethods.timeToNearestXMinute(5).ToString("dd MMMM yyyy HH:mm");// DateTime.Now.ToString("dd MMMM yyyy HH:mm");
            //MessageBox.Show("Time period: " + strTimePeroid);
            //string strTimePeroid = DateTime.Now.ToString("dd");
            table = "Report";
            conditional = "WHERE [REPORT_TIME] = @reportTime";
            dictAttributes = new Dictionary<string, string>
            {
                ["@reportTime"] = strTimePeroid
            };
            resultSet = dbReport.selectQuery(table, 1, conditional, dictAttributes);
            bool exists = (resultSet.Count != 0);

            if (exists) //Update Querry
            {
                table = "Report";
                strParams = "[ADMIN_NUM] = @adminNumber, [APP_COUNT] = @appCount, [STU_COUNT] = @studentCount, [REV_COUNT] = @revCount, [SUP_COUNT] = @supCount, [ACTIVE_REV] = @mostRev, [INACTIVE_REV] = @leastRev, [GRANTED_COUNT] = @grantedCount, [PENDING_COUNT] = @pendingCount, [REJECTED_COUNT] = @rejectedCount, [WAIVER_COUNT] = @waiverCount, [ETHICS_COUNT] = @ethicsCount";
                conditional = "WHERE REPORT_TIME = @reportTime";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@adminNumber"] = CommonMethods.getAdminNumber(),
                    ["@appCount"] = iApplicationNo.ToString(),
                    ["@studentCount"] = iStudentNo.ToString(),
                    ["@revCount"] = iReviewerNo.ToString(),
                    ["@supCount"] = iSupervisor.ToString(),
                    ["@mostRev"] = strMostReviewerApplications,
                    ["@leastRev"] = strLeastReviewerApplications,
                    ["@grantedCount"] = iGranted.ToString(),
                    ["@pendingCount"] = iPending.ToString(),
                    ["@rejectedCount"] = iRejected.ToString(),
                    ["@waiverCount"] = iWaiverNo.ToString(),
                    ["@ethicsCount"] = iEthicsNo.ToString(),
                    ["@reportTime"] = strTimePeroid
                };

                dbReviewer.updateQuery(table, strParams, conditional, dictAttributes);
                cbbMonthYear.Items.Add(strTimePeroid);
                cbbMonthYear.SelectedIndex = cbbMonthYear.Items.IndexOf(strTimePeroid);
            }
            else       //Insert Querry
            {
                //MessageBox.Show("Insert");
                table = "Report([REPORT_TIME], [ADMIN_NUM], [APP_COUNT], [STU_COUNT], [REV_COUNT], [SUP_COUNT], [ACTIVE_REV], [INACTIVE_REV], [GRANTED_COUNT], [PENDING_COUNT], [REJECTED_COUNT], [WAIVER_COUNT], [ETHICS_COUNT])";
                strParams = "(@reportTime, @adminNUmber, @applicationCount, @studentCount, @reviewerCount, @supervisorCount, @activeReviewer, @inactiveReviewer, @grantedCount, @pendingCount, @rejectedCount, @waiverCount, @ethicsCount)";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@reportTime"] = strTimePeroid,
                    ["@adminNUmber"] = CommonMethods.getAdminNumber(),
                    ["@applicationCount"] = iApplicationNo.ToString(),
                    ["@studentCount"] = iStudentNo.ToString(),
                    ["@reviewerCount"] = iReviewerNo.ToString(),
                    ["@supervisorCount"] = iSupervisor.ToString(),
                    ["@activeReviewer"] = strMostReviewerApplications,
                    ["@inactiveReviewer"] = strLeastReviewerApplications,
                    ["@grantedCount"] = iGranted.ToString(),
                    ["@pendingCount"] = iPending.ToString(),
                    ["@rejectedCount"] = iRejected.ToString(),
                    ["@waiverCount"] = iWaiverNo.ToString(),
                    ["@ethicsCount"] = iEthicsNo.ToString()
                };

                dbStudent.insertQuery(table, strParams, dictAttributes);

                cbbMonthYear.Items.Add(strTimePeroid);
                cbbMonthYear.SelectedIndex = cbbMonthYear.Items.IndexOf(strTimePeroid);
            }
        }

        public bool generateSpecificReport()
        {
            string strTimePeriod = cbbMonthYear.Text;

            string table, conditional;
            Dictionary<string, string> dictAttributes, resultRow;
            List<Dictionary<string, string>> resultSet;
            DB dbLogin = new DB();

            table = "Report";
            conditional = "WHERE [REPORT_TIME] = @reportTime";
            dictAttributes = new Dictionary<string, string>
            {
                ["@reportTime"] = strTimePeriod
            };

            resultSet = dbLogin.selectQuery(table, 13, conditional, dictAttributes);

            if (resultSet.Count == 1)
            {
                resultRow = resultSet[0];
                foreach (var kv in resultRow)
                {
                    if (kv.Key.Equals("APP_COUNT"))
                    {
                        lblNoApplications.Text = kv.Value;
                    }
                    if (kv.Key.Equals("STU_COUNT"))
                    {
                        lblNoStudents.Text = kv.Value;
                    }
                    if (kv.Key.Equals("REV_COUNT"))
                    {
                        lblNoReviewers.Text = kv.Value;
                    }
                    if (kv.Key.Equals("SUP_COUNT"))
                    {
                        lblNoSupervisors.Text = kv.Value;
                    }
                    if (kv.Key.Equals("ACTIVE_REV"))
                    {
                        lblReviewerWithMostApplications.Text = kv.Value;
                    }
                    if (kv.Key.Equals("INACTIVE_REV"))
                    {
                        lblReviewerWithLeastApplications.Text = kv.Value;
                    }
                    if (kv.Key.Equals("GRANTED_COUNT"))
                    {
                        lblNoGranted.Text = kv.Value;
                    }
                    if (kv.Key.Equals("PENDING_COUNT"))
                    {
                        lblNoPending.Text = kv.Value;
                    }
                    if (kv.Key.Equals("REJECTED_COUNT"))
                    {
                        lblNoRejected.Text = kv.Value;
                    }
                    if (kv.Key.Equals("WAIVER_COUNT"))
                    {
                        lblNoWaiver.Text = kv.Value;
                    }
                    if (kv.Key.Equals("ETHICS_COUNT"))
                    {
                        lblNoEthics.Text = kv.Value;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void getTimePeriods()
        {
            cbbMonthYear.Items.Clear();

            string table, conditional;
            Dictionary<string, string> dictAttributes;
            List<Dictionary<string, string>> resultSet;
            DB dbReport = new DB();

            table = "Report";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };
            resultSet = dbReport.selectQuery(table, 1, conditional, dictAttributes);

            if (resultSet.Count != 0)
            {
                foreach (Dictionary<string, string> resultRow in resultSet)
                {
                    cbbMonthYear.Items.Add(resultRow["REPORT_TIME"]);
                }
                cbbMonthYear.Text = (cbbMonthYear.Items[0].ToString());
            }
            else
            {
                //MessageBox.Show("Either the password or username was incorrect.", "Login Faliure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //There are currently no reports saved in the system.
            }
        }
    }
}
