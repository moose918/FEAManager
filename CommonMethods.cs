using System;
using System.Collections.Generic;
using System.Data;
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
        public static string getFullName(string ID, string table, string IDName, int colCount)
        {
            string conditional;
            Dictionary<string, string> dictAttributes, resultRow;
            List<Dictionary<string, string>> resultSet;
            DB dbLogin = new DB();

            conditional = "WHERE [" + IDName + "] = @identifier";
            dictAttributes = new Dictionary<string, string> 
            { 
                ["@identifier"] = ID
            };

            resultSet = dbLogin.selectQuery(table, colCount, conditional, dictAttributes);

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
            MessageBox.Show("Final: " + output);
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
                MessageBox.Show("Please enter your " + prompt + ".");
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
                MessageBox.Show("Please enter your " + prompt + ".");
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
                MessageBox.Show("Please enter your " + prompt + ".");
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

        private static void clearControl(Control control, Control exclude)
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
                    maskedTextBox.PasswordChar = '*';
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
                MessageBox.Show("Please enter your " + prompt + ".");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool validateTextBox(TextBox textBox, String prompt, int length)
        {
            MessageBox.Show("Got length " + length);
            if (length != -1)
            {
                if (!textBox.Text.Equals(""))
                {
                    if (textBox.TextLength != length)
                    {
                        MessageBox.Show("PLease enter a valid " + prompt + ".");
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
                MessageBox.Show("Please enter a date earler than or equal to " + DateTime.Now.ToString("dd MMMM yyyy"));
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
                MessageBox.Show("Please select " + article + " " + prompt);
                groupBox.Focus();
            }
            return valid;
        }
    }
}
