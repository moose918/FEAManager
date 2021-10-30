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
    public partial class FullScreenForm : Form
    {
        public FullScreenForm()
        {
            InitializeComponent();
        }

        public static void loadForm(Form previousForm, String imageName)
        {
            FullScreenForm frmFullScreen = new FullScreenForm();
            previousForm.Visible = false;
            frmFullScreen.setScreen(imageName);
            frmFullScreen.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        private void setScreen(string imageName)
        {
            if (imageName.Equals(CommonMethods.applicantForm))
            {
                ptbApplicantForm.Visible = true;
                ptbRishkCategoryTable.Visible = false;
            }
            else if (imageName.Equals(CommonMethods.riskCategoryTable))
            {
                ptbApplicantForm.Visible = false;
                ptbRishkCategoryTable.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
