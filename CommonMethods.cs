using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEAManager
{
    class CommonMethods
    {
        private static char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        public static string blankPlaceholder = "\"\"";

        public static char passwordChar = '*';

        public static string applicantForm = "af";

        public static string riskCategoryTable = "rct";

        public static string typeStudent = "Student";

        public static string typeAdmin = "Admin";

        public static string typeSupervisor = "Supervisor";

        public static string typeReviewer = "Reviewer";

        public static string typeApplication = "Application";

        private static string getPrefix(string userType)
        {
            if (userType.Equals(typeStudent))
            {
                return "STU";
            }
            if (userType.Equals(typeReviewer))
            {
                return "REV";
            }
            if (userType.Equals(typeAdmin))
            {
                return "ADMIN";
            }
            if (userType.Equals(typeSupervisor))
            {
                return "SUP";
            }
            if (userType.Equals(typeApplication))
            {
                return "APP";
            }
            return "";
        }

        private static string getIDName(string userType)
        {
            if (userType.Equals(typeStudent))
            {
                return "STU_NUM";
            }
            if (userType.Equals(typeReviewer))
            {
                return "REVIEWER_NUM";
            }
            if (userType.Equals(typeAdmin))
            {
                return "ADMIN_NUM";
            }
            if (userType.Equals(typeSupervisor))
            {
                return "SUPERVISOR_NUM";
            }
            if (userType.Equals(typeApplication))
            {
                return "APP_NUM";
            }
            return "";
        }

        public static string generateUniqueID(string userType)
        {
            string table, conditional;
            Dictionary<string, string> dictAttributes;
            List<Dictionary<string, string>> resultSet;
            DB database = new DB();

            string prefix = getPrefix(userType);
            
            string identification = prefix + CommonMethods.generateDigits();

            table = userType;
            conditional = "WHERE [" + getIDName(userType) + "] = @identified";
            dictAttributes = new Dictionary<string, string>
            {
                ["@identified"] = identification
            };

            resultSet = database.selectQuery(table, 1, conditional, dictAttributes);

            while (resultSet.Count != 0)
            {
                identification = prefix + CommonMethods.generateDigits();
                resultSet = database.selectQuery(table, 1, conditional, dictAttributes);
            }
            return identification;
        }

        public static DateTime timeToNearestXMinute(int degree)
        {
            DateTime someTime = DateTime.Now;
            int currMinute = DateTime.Now.Minute;
            //MessageBox.Show("CurrMinute / degree: " + currMinute + " / " + degree + " = " + (currMinute / degree));
            //MessageBox.Show("Decimal that = " + (decimal)(currMinute / degree));
            currMinute = (int) (Math.Ceiling((decimal)(((decimal)currMinute / (decimal)degree))) * (decimal)degree);
            TimeSpan ts = new TimeSpan(someTime.Hour, currMinute, someTime.Second);
            someTime = someTime.Date + ts;

            //MessageBox.Show("CurrTime: " + DateTime.Now.ToString("HH:mm:ss"));
            //MessageBox.Show("SomeTime: " + someTime.ToString("HH:mm:ss"));
            //MessageBox.Show("currentMinute: " + currMinute);
            return someTime;
        }

        public static void centraliseControlInContainer(Control control, Control container)
        {
            control.Location = new Point((container.Width - control.Width) / 2, control.Location.Y);
        }

        public static string getAdminNumber()
        {
            string table, conditional;
            Dictionary<string, string> dictAttributes, resultRow;
            List<Dictionary<string, string>> resultSet;
            DB dbLogin = new DB();

            table = "Admin";
            conditional = "";
            dictAttributes = new Dictionary<string, string> { };

            resultSet = dbLogin.selectQuery(table, 5, conditional, dictAttributes);

            if (resultSet.Count > 0)
            {
                resultRow = resultSet[0];
                String adminNumber = "";
                foreach (var kv in resultRow)
                {
                    if (kv.Key.Equals("ADMIN_NUM"))
                    {
                        adminNumber = kv.Value;
                    }
                }
                MessageBox.Show("admine no: " + adminNumber);
                return adminNumber;
            }
            else
            {
                MessageBox.Show("admine no: ");
                return "";
            }
        }

        public static void addNewChanges(List<List<string>> changes, List<List<string>> newChanges)
        {
            /*MessageBox.Show("Add new Change call, original changes keys");
            foreach (List<string> row in changes)
            {
                MessageBox.Show(row[0]);
            }
            MessageBox.Show("Done");

            MessageBox.Show("New changes keys");
            foreach (List<string> row in newChanges)
            {
                MessageBox.Show(row[0]);
            }
            MessageBox.Show("Done");*/

            for (int i = 0; i < newChanges.Count; i++)
            {
                string key = newChanges[i][0];
                string change = newChanges[i][1];

                for (int j = 0; j < changes.Count; j++)
                {
                    string changeKey = changes[j][0];

                    if (changeKey.Equals(key)) {
                        changes[j].Add(change);
                        //MessageBox.Show("Added new, now: " + changes[j].Count);
                    }
                }
            }
        }

        public static bool manageChanges(List<List<string>> changes)
        {
            /*MessageBox.Show("Manage changes call, printing everything");
            foreach (List<string> row in changes)
            {
                string line = "";
                foreach (string col in row)
                {
                    line += col + ", ";
                }
                MessageBox.Show(line);
            }
            MessageBox.Show("Done");*/

            List<string> lines = new List<string>();
            foreach (List<string> row in changes)
            {
                string key = row[0];
                if (!row[1].Equals(row[2]))
                {
                    if (key.Equals("password"))
                    {
                        lines.Add("Change your password");
                    }
                    else
                    {
                        lines.Add("Change your " + key + " from " + row[1] + " to " + row[2]);
                    }
                }
                row.RemoveAt(2);
            }

            if (lines.Count == 0)
            {
                MessageBox.Show("No changes were made", "Confimation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                string prompt = "Are you sure you want to make the following changes?\n\n";
                foreach (string line in lines)
                {
                    prompt += line + "\n";
                }
                
                DialogResult result = MessageBox.Show(prompt, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Update Aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
        }

        public static void getStudyPrograms(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Honours");
            comboBox.Items.Add("Coursework Masters");
            comboBox.Items.Add("Full Research Masters");
            comboBox.Items.Add("PHD");
        }

        public static void myErrorMessageBox(string prompt)
        {
            MessageBox.Show(prompt, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void myConfirmationMessageBox(string prompt)
        {
            MessageBox.Show(prompt, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static int getColumnCount(string userType)
        {
            if (userType.Equals(typeStudent))
            {
                return 9;
            }
            if (userType.Equals(typeReviewer))
            {
                return 7;
            }
            if (userType.Equals(typeAdmin))
            {
                return 5;
            }
            if (userType.Equals(typeSupervisor))
            {
                return 5;
            }
            if (userType.Equals(typeApplication))
            {
                return 10;
            }
            return 0;
        }

        public static string getFullName(string ID, string userType)
        {
            string conditional;
            Dictionary<string, string> dictAttributes, resultRow;
            List<Dictionary<string, string>> resultSet;
            DB dbLogin = new DB();

            string IDName = getIDName(userType);
            int colCount = getColumnCount(userType);

            conditional = "WHERE [" + IDName + "] = @identifier";
            dictAttributes = new Dictionary<string, string> 
            { 
                ["@identifier"] = ID
            };

            resultSet = dbLogin.selectQuery(userType, colCount, conditional, dictAttributes);

            if (resultSet.Count > 0)
            {
                resultRow = resultSet[0];
                String fName = "", lName = "";
                foreach (var kv in resultRow)
                {
                    if (kv.Key.Equals("FNAME"))
                    {
                        fName = kv.Value;
                    }
                    if (kv.Key.Equals("LNAME"))
                    {
                        lName = kv.Value;
                    }
                }
                return fName + " " + lName;
            }
            else
            {
                return "";
            }
        }

        public static string cblToString(CheckedListBox clb)
        {
            string output = "";
            for (int i = 0; i < clb.Items.Count; i++)
            {
                bool blnChecked = clb.GetItemChecked(i);
                if (blnChecked){
                    //CheckBox cb = (CheckBox) clb.Items[i];
                    output += clb.Items[i] + ", ";
                }
            }
            if (output.Length != 0)
            {
                output = output.Substring(0, output.Length - 2);
            }
            return output;
        }

        public static void setRadWithText(string name, GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Text.Equals(name))
                    {
                        radioButton.Checked = true;
                        break;
                    }
                }
            }
        }

        public static String generateDigits()
        {
            String digits = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                digits += random.Next(0, 9).ToString();
            }
            return digits;
        }

        public static String checkedString(GroupBox groupBox)
        {
            String text = "";
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton) control;
                    if (radioButton.Checked)
                    {
                        text = radioButton.Text;
                        return text;
                    }
                }
            }
            return "";
        }

        public static string yesNo(GroupBox groupBox)
        {
            string ans = "0";
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Checked && radioButton.Text.Equals("Yes"))
                    {
                        ans = "-1";
                        return ans;
                    }
                    else if (radioButton.Checked && radioButton.Text.Equals("No"))
                    {
                        ans = "0";
                        return ans;
                    }
                }
            }
            return ans;
        }

        public static void passwordControl(MaskedTextBox maskededit)
        {
            maskededit.PasswordChar = (maskededit.PasswordChar == '*') ? '\0' : '*';
        }

        public static bool validateTextBox(TextBox textBox, String prompt)
        {
            if(textBox.TextLength == 0)
            {
                myErrorMessageBox("Please enter your " + prompt + ".");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool validateTextBox(RichTextBox textBox, String prompt)
        {
            if (textBox.TextLength == 0)
            {
                myErrorMessageBox("Please enter your " + prompt + ".");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool validateTextBox(MaskedTextBox textBox, String prompt)
        {
            if (textBox.TextLength == 0)
            {
                myErrorMessageBox("Please enter your " + prompt + ".");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
            return true;
        }

        private static void clearContainer(Control container, Control exclude)
        {
            foreach (Control control in container.Controls)
            {
                clearControl(control, exclude);
            }
        }

        public static void clearControl(Control control, Control exclude)
        {
            if (control != exclude)
            {
                if (control.Controls != null)
                {
                    clearContainer(control, exclude);
                }

                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }

                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.Value = DateTime.Now;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.Text = "";
                }

                if (control is MaskedTextBox)
                {
                    MaskedTextBox maskedTextBox = (MaskedTextBox)control;
                    maskedTextBox.Text = "";
                    maskedTextBox.PasswordChar = passwordChar;
                }

                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
            }
        }

        public static void clearForm(Form form)
        {
            clearControl(form, null);
        }

        public static void clearForm(Form form, Control exclude)
        {
            clearControl(form, exclude);
        }

        public static bool validateTextBox(ComboBox textBox, String prompt)
        {
            if (textBox.Text.Equals(""))
            {
                myErrorMessageBox("Please enter your " + prompt + ".");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool validateTextBox(TextBox textBox, String prompt, int length)
        {
            if (length != -1)
            {
                if (!textBox.Text.Equals(""))
                {
                    if (textBox.TextLength != length)
                    {
                        myErrorMessageBox("PLease enter a valid " + prompt + ".");
                        textBox.Text = "";
                        textBox.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool validateDOB(DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.Value > DateTime.Now)
            {
                string prompt = "Please enter a date earler than or equal to " + DateTime.Now.ToString("dd MMMM yyyy");
                myErrorMessageBox(prompt);
                dateTimePicker.Value = DateTime.Now;
                dateTimePicker.Focus();
                return false;
            }
            return true;
        }

        public static bool validateRadioButtonsInGroup(GroupBox groupBox, String prompt)
        {
            bool valid = false;
            foreach(Control control in groupBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Checked)
                    {
                        valid = true;
                        break;
                    }
                }
            }
            if (!valid)
            {
                String article = (vowels.Contains(prompt[0])) ? "an" : "a";
                myErrorMessageBox("Please select " + article + " " + prompt);
                groupBox.Focus();
            }
            return valid;
        }
    }
}
