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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate input

            // check DB of respective user type

            // load respective form if correct info is given
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterStudentForm registerStudentForm = new RegisterStudentForm();

            // only students can register...

            this.Visible = false;
            registerStudentForm.ShowDialog(this);
            this.Visible = true;
        }
    }
}
