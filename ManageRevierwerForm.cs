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
    public partial class ManageRevierwerForm : Form
    {
        public ManageRevierwerForm()
        {
            InitializeComponent();
        }

        public static void loadForm(Form previousForm)
        {
            ManageRevierwerForm frmManageReviewer = new ManageRevierwerForm();
            previousForm.Visible = false;
            frmManageReviewer.ShowDialog(previousForm);
            previousForm.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
