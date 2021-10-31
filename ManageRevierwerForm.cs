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
        private Reviewer reviewer;
        public ManageRevierwerForm()
        {
            InitializeComponent();
        }

        public static void loadForm(Form previousForm)
        {
            ManageRevierwerForm frmManageReviewer = new ManageRevierwerForm();
            CommonMethods.getStudyPrograms(frmManageReviewer.cbbQulificationLevel);
            frmManageReviewer.refreshDataGrid();
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

        public static void loadForm(AdminMainMenuForm previousForm)
        {
            ManageRevierwerForm frmManageReviewer = new ManageRevierwerForm();
            CommonMethods.getStudyPrograms(frmManageReviewer.cbbQulificationLevel);
            frmManageReviewer.refreshDataGrid();
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
            previousForm.preliminaryActions();
            previousForm.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageRevierwerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fEAManager_DBDataSet.Reviewer' table. You can move, or remove it, as needed.
            this.reviewerTableAdapter.Fill(this.fEAManager_DBDataSet.Reviewer);
            // TODO: This line of code loads data into the 'fEAManager_DBDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.fEAManager_DBDataSet.Admin);
            refreshDataGrid();
        }

        private void btnCreate_click(object sender, EventArgs e)
        {
            bool createdReviewer = reviewer.createReviewer();
            if (createdReviewer)
            {
                CommonMethods.myConfirmationMessageBox(reviewer.strReviwerNumber + " has been succesfully created");
                refreshDataGrid();
                refreshLables();
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
            bool updatedReviewer = reviewer.updateReviewer();
            if (updatedReviewer)
            {
                CommonMethods.myConfirmationMessageBox(reviewer.strReviwerNumber + " has been succesfully updated");
                refreshDataGrid();
                refreshLables();
            }
        }

        private void refreshLables()
        {
            String strReviewerNum, strDOB, strFName, strLName, strTelephone, strEmail, strQualificationLevel;
            if (dataGridView1.CurrentRow != null)
            {
                if (dataGridView1.CurrentRow.Index >= 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count)
                {
                    bool allNotNull = true;
                    for (int i = 0; i < dataGridView1.CurrentRow.Cells.Count; i++)
                    {
                        if (dataGridView1.CurrentRow.Cells[i].Value == null)
                        {
                            allNotNull = false;
                            break;
                        }
                    }

                    if (allNotNull)
                    {
                        List<String> allEntries = new List<string>();
                        strReviewerNum = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        strFName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        strLName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        strQualificationLevel = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        strDOB = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        strTelephone = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                        strEmail = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                        allEntries.Add(strReviewerNum);
                        allEntries.Add(strFName);
                        allEntries.Add(strLName);
                        allEntries.Add(strQualificationLevel);
                        allEntries.Add(strTelephone);
                        allEntries.Add(strDOB);
                        allEntries.Add(strEmail);

                        bool notAllEmpty = true;

                        foreach (string line in allEntries)
                        {
                            if (line.Length == 0)
                            {
                                notAllEmpty = false;
                                break;
                            }
                        }

                        if (notAllEmpty)
                        {
                            txtReviewerNumber.Text = strReviewerNum;
                            txtLName.Text = strLName;
                            txtFName.Text = strFName;
                            cbbQulificationLevel.Text = strQualificationLevel;
                            mtxtTelephone.Text = strTelephone;
                            mtxtEmail.Text = strEmail;
                            dtpDOB.Value = DateTime.Parse(strDOB);
                        }
                    }
                }
            }
        }

        private void refreshDataGrid()
        {
            reviewer = new Reviewer(txtFName, txtLName, txtReviewerNumber, mtxtEmail, mtxtTelephone, dtpDOB, cbbQulificationLevel);

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

                conn.Close();
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                /*dataGridView1.Columns[i].Width = dataGridView1.Width / dataGridView1.Columns.Count - 10;*/
                dataGridView1.Columns[i].Width = 141;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool deteledReviewr = reviewer.deteleReviewer();
            if (deteledReviewr)
            {
                CommonMethods.myConfirmationMessageBox(reviewer.strReviwerNumber + " has been succesfulyl deleted");
                refreshLables();
                refreshDataGrid();
            }
            else
            {
                CommonMethods.myConfirmationMessageBox("Delete aborted");
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            //refreshLables();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            //refreshLables();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            //refreshLables();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            //refreshLables();
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
            //refreshLables();
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            //refreshLables();
            //MessageBox.Show("Changed");
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            refreshLables();
            //MessageBox.Show("Change");
        }
    }
}
