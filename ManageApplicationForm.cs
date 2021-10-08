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
    public partial class ManageApplicationForm : Form
    {
        public ManageApplicationForm()
        {
            InitializeComponent();
        }
        public static void loadForm(Form previousForm)
        {
            ManageApplicationForm frmManageApplication = new ManageApplicationForm();
            previousForm.Visible = false;
            frmManageApplication.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
