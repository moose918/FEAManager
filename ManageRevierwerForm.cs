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
            previousForm.Visible = false;
            frmManageReviewer.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void ManageRevierwerForm_Load(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void btnCreate_click(object sender, EventArgs e)
        {
            //
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strTable, strParams, strConditional;
            Dictionary<string, string> dictAttributes;
            DB dbReviewer = new DB();

            strTable = "Reviewer";
            strParams = "FNAME = @fName, LNAME = @lName, [QUAL_LEVEL] = @qLevel";
            strConditional = "WHERE REVIEWER_NUM = @reviewerNum";
            dictAttributes = new Dictionary<string, string>
            {
                ["@fName"] = txtFName.Text,
                ["@lName"] = txtLName.Text,
                ["@qLevel"] = txtQualificationLevel.Text,
                ["@reviewerNum"] = txtReviewerNumber.Text
            };

            dbReviewer.updateQuery(strTable, strParams, strConditional, dictAttributes);

            refreshDataGrid();
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
                bindingNavigator1.BindingSource = bindingSource;
                dataGridView1.Refresh();

//                conn.Close();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // confirm with user...

            string strTable, strConditional, strReviewerNum;
            Dictionary<string, string> dictAttributes;
            DB dbReviewer = new DB();

            strReviewerNum = dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
    }
}
