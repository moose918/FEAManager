using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEAManager
{
    class LoginController
    {
        /**
         * Login Controller
         * Controlls all the heavier logic on the logon form
         * Every controller will have a reference to the objects on their respective form
        **/
        private TextBox txtUsername;
        private MaskedTextBox mtxtPassword;
        private GroupBox grpUserType;

        public string strUsername, strPassword, strUserType;
        public bool validLogin(TextBox txtUsername, MaskedTextBox mtxtPassword, GroupBox grpUserType)
        {
            /**
             * Main logic to check if a login is valid
             * First, input is validated. 
             * Secondly, depending on the userType, a user with said userName and password will searched for in 
             * their respective database.
             * If they are found, then the login is valid.
             * They are found if after doing the select query, there is at least 1 result in the result set
             * Realistically, if there is more than 1 result in the rtesult set, then theres an issue in the database
             * But, we dont need to look for that at the moment.
             * **/
            this.txtUsername = txtUsername;
            this.mtxtPassword = mtxtPassword;
            this.grpUserType = grpUserType;

            bool validInformation = ValidateInformation();
            if (validInformation)
            {
                string table, conditional;
                Dictionary<string, string> dictStudentAttributes, dictAdminAttributes;
                List<Dictionary<string, string>> resultSet;
                DB dbStudent = new DB();
                DB dbAdmin = new DB();

                strUsername = txtUsername.Text;
                strPassword = mtxtPassword.Text;
                strUserType = CommonMethods.checkedString(grpUserType);

                if (strUserType.Equals(CommonMethods.typeStudent))
                {
                    table = CommonMethods.typeStudent;
                    conditional = "WHERE [STU_NUM] = @studentNum AND [PASSWORD] = @passwd";
                    dictStudentAttributes = new Dictionary<string, string>
                    {
                        ["@studentNum"] = strUsername,
                        ["@passwd"] = strPassword
                    };

                    resultSet = dbStudent.selectQuery(table, 1, conditional, dictStudentAttributes);

                    if (resultSet.Count != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (strUserType.Equals(CommonMethods.typeAdmin))
                {
                    table = CommonMethods.typeAdmin;
                    conditional = "WHERE [ADMIN_NUM] = @adminNum AND [PASSWORD] = @passwd";
                    dictAdminAttributes = new Dictionary<string, string>
                    {
                        ["@adminNum"] = strUsername,
                        ["@passwd"] = strPassword
                    };
                    resultSet = dbStudent.selectQuery(table, 1, conditional, dictAdminAttributes);

                    if (resultSet.Count != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private bool ValidateInformation()
        {
            bool valid = true;
            valid = CommonMethods.validateTextBox(txtUsername, "username") && valid;
            valid = CommonMethods.validateTextBox(mtxtPassword, "password") && valid;
            valid = CommonMethods.validateRadioButtonsInGroup(grpUserType, "user type") && valid;
            return valid;
        }
    }


}
