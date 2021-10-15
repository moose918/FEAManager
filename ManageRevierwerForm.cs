using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEAManager
{
    public partial class ManageRevierwerForm : Form
    {
        public ManageRevierwerForm()
        {
            InitializeComponent();
        }

        public static void loadForm(Form previousForm)
        {
            ManageRevierwerForm frmManageReviewer = new ManageRevierwerForm();
            frmManageReviewer.loadDetails();
            try
            {
                frmManageReviewer.npiReviewers.BindingSource.Position = 1;
            }
            catch
            {
                frmManageReviewer.npiReviewers.BindingSource.Position = 0;
            }
            frmManageReviewer.refreshLables();
            previousForm.Visible = false;
            frmManageReviewer.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        private void loadDetails()
        {
            refreshDataGrid();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm.loadForm(this);
        }

        private void ManageRevierwerForm_Load(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void btnCreate_click(object sender, EventArgs e)
        {
            //Validating input
            bool validInformation = ValidateInformation();

            if (validInformation)
            {
                //Making sure that reviewer does not exist
                bool exists = false;

                string strTable, strParams, strConditional, strRows;
                Dictionary<string, string> dictAttributes;
                List<Dictionary<string, string>> resultSet;
                DB dbReviewer = new DB();

                strTable = "Reviewer";
                strConditional = "WHERE [REVIEWER_NUM] = @reviewerNum";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@reviewerNum"] = txtReviewerNumber.Text
                };

                resultSet = dbReviewer.selectQuery(strTable, 7, strConditional, dictAttributes);

                if (resultSet.Count > 0)
                {
                    exists = true;
                    MessageBox.Show(txtReviewerNumber.Text + " already exists, you can not create them again");
                    btnClear.PerformClick();
                }
                else
                {
                    exists = false;
                }

                if (!exists)
                {
                    strTable = "Reviewer([REVIEWER_NUM], [FNAME], [LNAME], [QUAL_LEVEL], [DOB], [TELEPHONE], [EMAIL])";
                    strRows = "(@reviewerNum, @fName, @lName, @qLevel, @dob, @telephone, @email)";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@reviewerNum"] = txtReviewerNumber.Text,
                        ["@fName"] = txtFName.Text,
                        ["@lName"] = txtLName.Text,
                        ["@qLevel"] = txtQualificationLevel.Text,
                        ["@dob"] = dtpDOB.Value.ToString("dd/MM/yyyy"),
                        ["@telephone"] = mtxtTelephone.Text,
                        ["@email"] = mtxtEmail.Text
                    };

                    dbReviewer.insertQuery(strTable, strRows, dictAttributes);

                    loadDetails();
                    refreshDataGrid();
                }
            }
        }

        private bool ValidateInformation()
        {
            bool valid = true;
            valid = CommonMethods.validateTextBox(txtFName, "first name") && valid;
            valid = CommonMethods.validateTextBox(txtLName, "last name") && valid;
            valid = CommonMethods.validateTextBox(txtReviewerNumber, "reviewer number") && valid;
            valid = CommonMethods.validateTextBox(txtReviewerNumber, "reviewer number", 13) && valid;
            valid = CommonMethods.validateTextBox(mtxtEmail, "email") && valid;
            valid = CommonMethods.validateTextBox(mtxtTelephone, "telephone") && valid;
            valid = CommonMethods.validateDOB(dtpDOB) && valid;

            return valid;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validating input
            bool validInformation = ValidateInformation();

            if (validInformation)
            {
                //Making sure that reviewr 
                bool exists = false;

                string strTable, strParams, strConditional;
                Dictionary<string, string> dictAttributes;
                List<Dictionary<string, string>> resultSet;
                DB dbReviewer = new DB();

                strTable = "Reviewer";
                strConditional = "WHERE [REVIEWER_NUM] = @reviewerNum";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@reviewerNum"] = txtReviewerNumber.Text
                };

                resultSet = dbReviewer.selectQuery(strTable, 7, strConditional, dictAttributes);

                if (resultSet.Count > 0)
                {
                    exists = true;
                }
                else
                {
                    exists = false;
                    MessageBox.Show(txtReviewerNumber.Text + " Does not exists. You can rather create said reviewer");
                    btnClear.PerformClick();
                }

                if (exists)
                {
                    strTable = "Reviewer";
                    strParams = "[REVIEWER_NUM] = @reviewerNum, [FNAME] = @fName, [LNAME] = @lName, [QUAL_LEVEL] = @qLevel, [DOB] = @dob, [TELEPHONE] = @telephone, [EMAIL] = @email";
                    //strParams = "[REVIEWER_NUM] = @reviewerNum, [FNAME] = @fName, [LNAME] = @lName, [QUAL_LEVEL] = @qLevel, [TELEPHONE] = @telephone, [EMAIL] = @email";
                    strConditional = "WHERE REVIEWER_NUM = @reviewerNum";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@reviewerNum"] = txtReviewerNumber.Text,
                        ["@fName"] = txtFName.Text,
                        ["@lName"] = txtLName.Text,
                        ["@qLevel"] = txtQualificationLevel.Text,
                        ["@dob"] = dtpDOB.Value.ToString("dd/MM/yyyy"),
                        ["@telephone"] = mtxtTelephone.Text,
                        ["@email"] = mtxtEmail.Text
                    };

                    dbReviewer.updateQuery(strTable, strParams, strConditional, dictAttributes);
                    
                    loadDetails();
                    refreshDataGrid();
                }
            }
        }

        private void refreshLables()
        {
            String strReviewerNum, strDOB, strFName, strLName, strTelephone, strEmail, strQualificationLevel;
            strReviewerNum = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            strFName= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            strLName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            strQualificationLevel = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            strDOB = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            strTelephone = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            strEmail = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            txtReviewerNumber.Text = strReviewerNum;
            txtLName.Text = strLName;
            txtFName.Text = strFName;
            txtQualificationLevel.Text = strQualificationLevel;
            mtxtTelephone.Text = strTelephone;
            mtxtEmail.Text = strEmail;
            dtpDOB.Value = DateTime.Parse(strDOB);

        }

        private void refreshDataGrid()
        {
            // TODO: This line of code loads data into the 'tblReviewer.Reviewer' table. You can move, or remove it, as needed.
            string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = FEAManager_DB.accdb";
            BindingSource bindingSource;
            DataTable reviwerTable = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Reviewer", conn);

                conn.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                reviwerTable.Clear();
                adapter.Fill(reviwerTable);
                bindingSource = new BindingSource(reviwerTable, null);
                dataGridView1.DataSource = bindingSource;
                npiReviewers.BindingSource = bindingSource;
                dataGridView1.Refresh();

//                conn.Close();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            String strReviewerNum = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            // confirm with user...
            DialogResult result = MessageBox.Show("Are you sure you want to delete reviewer: " + strReviewerNum + "?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string strTable, strConditional;
                Dictionary<string, string> dictAttributes;
                DB dbReviewer = new DB();

                MessageBox.Show(strReviewerNum);
                strTable = "Reviewer";
                strConditional = "WHERE REVIEWER_NUM = @reviewerNum";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@reviewerNum"] = strReviewerNum
                };

                dbReviewer.deleteQuery(strTable, strConditional, dictAttributes);

                refreshDataGrid();
            }
            else
            {
                MessageBox.Show("Delete Aborted");
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            refreshLables();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            refreshLables();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            refreshLables();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            refreshLables();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                npiReviewers.BindingSource.Position = 1;
            }
            catch
            {
                npiReviewers.BindingSource.Position = 0;
            }
            refreshDataGrid();
            refreshLables();
        }
    }
}
