using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEAManager
{
    class CommonMethods
    {

        public static String checkedString(GroupBox groupBox)
        {
            String text = "";
            foreach (RadioButton radioButton in groupBox.Controls)
            {
                text = (radioButton.Checked) ? radioButton.Text : text;
            }
            return text;
        }

        private static char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

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
            foreach(RadioButton radioButton in groupBox.Controls)
            {
                if (radioButton.Checked)
                {
                    valid = true;
                    break;
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
