using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEAManager
{
    public partial class StudentMainMenuForm : Form
    {
        public StudentMainMenuForm()
        {
            InitializeComponent();
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        public static void loadForm(Form previousForm)
        {
            StudentMainMenuForm frmStudentMainMenu = new StudentMainMenuForm();
            previousForm.Visible = false;
            frmStudentMainMenu.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
