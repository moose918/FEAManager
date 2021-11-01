using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEAManager
{

    class Reviewer
    {
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtReviewerNumber;
        private MaskedTextBox mtxtEmail;
        private MaskedTextBox mtxtTelephone;
        private DateTimePicker dtpDOB;
        private ComboBox cbbQulificationLevel;

        public string strReviwerNumber;

        public Reviewer(TextBox txtFName, TextBox txtLName, TextBox txtReviewerNumber,
                        MaskedTextBox mtxtEmail, MaskedTextBox mtxtTelephone,
                        DateTimePicker dtpDOB, ComboBox cbbQulificationLevel)
        {
            this.txtFName = txtFName;
            this.txtLName = txtLName;
            this.txtReviewerNumber = txtReviewerNumber;
            this.mtxtEmail = mtxtEmail;
            this.mtxtTelephone = mtxtTelephone;
            this.dtpDOB = dtpDOB;
            this.cbbQulificationLevel = cbbQulificationLevel;
        }

        public bool createReviewer(string strCurrentReviewer)
        {
            strReviwerNumber = txtReviewerNumber.Text;

            //Validating input
            bool validInformation = ValidateInformation(true, strCurrentReviewer);

            if (validInformation)
            {
                string strTable, strRows;
                Dictionary<string, string> dictAttributes;
                DB dbReviewer = new DB();

                strTable = "Reviewer([REVIEWER_NUM], [FNAME], [LNAME], [QUAL_LEVEL], [DOB], [TELEPHONE], [EMAIL])";
                strRows = "(@reviewerNum, @fName, @lName, @qLevel, @dob, @telephone, @email)";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@reviewerNum"] = txtReviewerNumber.Text,
                    ["@fName"] = txtFName.Text,
                    ["@lName"] = txtLName.Text,
                    ["@qLevel"] = cbbQulificationLevel.Text,
                    ["@dob"] = dtpDOB.Value.ToString("dd/MM/yyyy"),
                    ["@telephone"] = mtxtTelephone.Text,
                    ["@email"] = mtxtEmail.Text
                };

                dbReviewer.insertQuery(strTable, strRows, dictAttributes);

                return true;
            }
            else {return false;}
        }

        public bool deteleReviewer()
        {
            strReviwerNumber = txtReviewerNumber.Text;

            // confirm with user...
            DialogResult result = MessageBox.Show("Are you sure you want to delete reviewer: " + strReviwerNumber + "?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string strTable, strConditional;
                Dictionary<string, string> dictAttributes;
                DB dbReviewer = new DB();

                //MessageBox.Show(strReviwerNumber);
                strTable = "Reviewer";
                strConditional = "WHERE REVIEWER_NUM = @reviewerNum";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@reviewerNum"] = strReviwerNumber
                };

                dbReviewer.deleteQuery(strTable, strConditional, dictAttributes);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateReviewer(string strCurrentReviewer)
        {
            strReviwerNumber = txtReviewerNumber.Text;

            //Validating input
            bool validInformation = ValidateInformation(false, strCurrentReviewer);

            if (validInformation)
            {
                string strTable, strConditional, strParams;
                Dictionary<string, string> dictAttributes;
                DB dbReviewer = new DB();

                strTable = "Reviewer";
                strParams = "[FNAME] = @fName, [LNAME] = @lName, [QUAL_LEVEL] = @qLevel, [DOB] = @dob, [TELEPHONE] = @telephone, [EMAIL] = @email";
                strConditional = "WHERE [REVIEWER_NUM] = @reviewerNum";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@fName"] = txtFName.Text,
                    ["@lName"] = txtLName.Text,
                    ["@qLevel"] = cbbQulificationLevel.Text,
                    ["@dob"] = dtpDOB.Value.ToString("dd/MM/yyyy"),
                    ["@telephone"] = mtxtTelephone.Text,
                    ["@email"] = mtxtEmail.Text,
                    ["@reviewerNum"] = txtReviewerNumber.Text
                };

                int cols = dbReviewer.updateQuery(strTable, strParams, strConditional, dictAttributes);
                return true;
            }

            return false;
        }

        private bool ValidateInformation(bool checkExistance, string strCurrentReviewer)
        {
            bool valid = true;
            valid = CommonMethods.validateTextBox(txtFName, "first name") && valid;
            valid = CommonMethods.validateTextBox(txtLName, "last name") && valid;
            bool validReviewerNumber = CommonMethods.validateTextBox(txtReviewerNumber, "reviewer number");
            if (validReviewerNumber && !checkExistance)
            {
                if (!txtReviewerNumber.Text.Equals(strCurrentReviewer))
                {
                    CommonMethods.myErrorMessageBox("You can not update a reviewers reviewer number");
                    txtReviewerNumber.Text = strCurrentReviewer;
                    txtReviewerNumber.Focus();
                    valid = false;
                }
            }
            valid = validReviewerNumber && valid;
            valid = CommonMethods.validateTextBox(txtReviewerNumber, "reviewer number") && valid;
            valid = CommonMethods.validateTextBox(mtxtEmail, "email") && valid;
            valid = CommonMethods.validateTextBox(mtxtTelephone, "telephone") && valid;
            valid = CommonMethods.validateDOB(dtpDOB) && valid;

            if (validReviewerNumber && checkExistance)
            {
                //Making sure that reviewer does not exist
                string strTable, strConditional, strRows;
                Dictionary<string, string> dictAttributes;
                List<Dictionary<string, string>> resultSet;
                DB dbReviewer = new DB();

                strTable = "Reviewer";
                strConditional = "WHERE [REVIEWER_NUM] = @reviewerNum";
                dictAttributes = new Dictionary<string, string>
                {
                    ["@reviewerNum"] = txtReviewerNumber.Text
                };

                resultSet = dbReviewer.selectQuery(strTable, 1, strConditional, dictAttributes);
                bool exists = (resultSet.Count != 0);

                if (exists)
                {
                    DialogResult result = MessageBox.Show("Reviewer numbeer: " + txtReviewerNumber.Text + " is already taken. Do you want one to be randonly created for you?", "Reviewer Number Taken", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        txtReviewerNumber.Text = CommonMethods.generateUniqueID(CommonMethods.typeReviewer);
                        exists = false;
                    }
                    else
                    {
                        MessageBox.Show(txtReviewerNumber.Text + " already exists. Enter a different unused reviewer number.");
                    }
                }

                valid = valid && !exists;
            }

            return valid;
        }
    }
}
