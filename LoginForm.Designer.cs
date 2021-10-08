
namespace FEAManager
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbStudent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.mtxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(87, 33);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(60, 19);
            this.rdbAdmin.TabIndex = 0;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "&Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbStudent
            // 
            this.rdbStudent.AutoSize = true;
            this.rdbStudent.Location = new System.Drawing.Point(83, 93);
            this.rdbStudent.Name = "rdbStudent";
            this.rdbStudent.Size = new System.Drawing.Size(67, 19);
            this.rdbStudent.TabIndex = 1;
            this.rdbStudent.TabStop = true;
            this.rdbStudent.Text = "&Student";
            this.rdbStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbStudent);
            this.groupBox1.Controls.Add(this.rdbAdmin);
            this.groupBox1.Location = new System.Drawing.Point(469, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Foresight";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowPassword);
            this.panel1.Controls.Add(this.mtxtPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(131, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 142);
            this.panel1.TabIndex = 10;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPassword.Image")));
            this.btnShowPassword.Location = new System.Drawing.Point(268, 92);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(16, 18);
            this.btnShowPassword.TabIndex = 9;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            // 
            // mtxtPassword
            // 
            this.mtxtPassword.Location = new System.Drawing.Point(150, 92);
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.Size = new System.Drawing.Size(114, 20);
            this.mtxtPassword.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(150, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(114, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(479, 40);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ethics Application Manager";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRegister);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Location = new System.Drawing.Point(188, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 77);
            this.panel3.TabIndex = 29;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(281, 18);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 41);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(58, 18);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 41);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 449);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.RadioButton rdbStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnShowPassword;
    }
}

