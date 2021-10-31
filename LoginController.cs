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
        private TextBox txtUsername;
        private MaskedTextBox mtxtPassword;
        private GroupBox grpUserType;

        public string strUsername, strPassword, strUserType;
        public bool validLogin(TextBox txtUsername, MaskedTextBox mtxtPassword, GroupBox grpUserType)
        {
            this.txtUsername = txtUsername;
            this.mtxtPassword = mtxtPassword;
            this.grpUserType = grpUserType;

            bool validInformation = ValidateInformation();
            if (validInformation)
            {
                string table, conditional;
                Dictionary<string, string> dictAttributes, resultRow;
                List<Dictionary<string, string>> resultSet;
                DB dbLogin = new DB();

                strUsername = txtUsername.Text;
                strPassword = mtxtPassword.Text;
                strUserType = CommonMethods.checkedString(grpUserType);

                if (strUserType.Equals(CommonMethods.typeStudent))
                {
                    table = "Student";
                    conditional = "WHERE [STU_NUM] = @studentNum AND [PASSWORD] = @passwd";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@studentNum"] = strUsername,
                        ["@passwd"] = strPassword
                    };

                    resultSet = dbLogin.selectQuery(table, 1, conditional, dictAttributes);

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
                    table = "Admin";
                    conditional = "WHERE [ADMIN_NUM] = @adminNum AND [PASSWORD] = @passwd";
                    dictAttributes = new Dictionary<string, string>
                    {
                        ["@adminNum"] = strUsername,
                        ["@passwd"] = strPassword
                    };
                    resultSet = dbLogin.selectQuery(table, 1, conditional, dictAttributes);

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
