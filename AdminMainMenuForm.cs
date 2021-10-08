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
    public partial class AdminMainMenuForm : Form
    {
        public AdminMainMenuForm()
        {
            InitializeComponent();
        }

        public static void loadForm(Form previousForm)
        {
            AdminMainMenuForm frmAdminMenu = new AdminMainMenuForm();
            previousForm.Visible = false;
            frmAdminMenu.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        private void btnManageReviewers_Click(object sender, EventArgs e)
        {
            // load reviewers

            ManageRevierwerForm.loadForm(this);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnManageApplications_Click(object sender, EventArgs e)
        {
            // load applications

            ManageApplicationForm.loadForm(this);
        }

    }
}
