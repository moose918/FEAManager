
namespace FEAManager
{
    partial class RegisterStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudentForm));
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.mtxtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewPassword = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.cmbStudyProgram = new System.Windows.Forms.ComboBox();
            this.mtxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpTitle = new System.Windows.Forms.GroupBox();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.radMs = new System.Windows.Forms.RadioButton();
            this.radMr = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.lblHeading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(178, 20);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(744, 46);
            this.lblHeading.TabIndex = 19;
            this.lblHeading.Text = "Please enter your registration details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.mtxtTelephone);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(51, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 284);
            this.panel1.TabIndex = 0;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(205, 159);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(249, 26);
            this.dtpDOB.TabIndex = 3;
            // 
            // mtxtTelephone
            // 
            this.mtxtTelephone.Location = new System.Drawing.Point(205, 223);
            this.mtxtTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTelephone.Mask = "(999) 000-0000";
            this.mtxtTelephone.Name = "mtxtTelephone";
            this.mtxtTelephone.Size = new System.Drawing.Size(249, 26);
            this.mtxtTelephone.TabIndex = 4;
            this.mtxtTelephone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(205, 92);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(249, 26);
            this.txtLName.TabIndex = 2;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(205, 27);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(249, 26);
            this.txtFName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Telephone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "First Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnViewPassword);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.mtxtPassword);
            this.panel2.Controls.Add(this.cmbStudyProgram);
            this.panel2.Controls.Add(this.mtxtEmail);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(575, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 284);
            this.panel2.TabIndex = 5;
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewPassword.BackgroundImage")));
            this.btnViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewPassword.Location = new System.Drawing.Point(428, 92);
            this.btnViewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Size = new System.Drawing.Size(26, 26);
            this.btnViewPassword.TabIndex = 8;
            this.btnViewPassword.UseVisualStyleBackColor = true;
            this.btnViewPassword.Click += new System.EventHandler(this.btnViewPassword_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Password:";
            // 
            // mtxtPassword
            // 
            this.mtxtPassword.Location = new System.Drawing.Point(205, 92);
            this.mtxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '*';
            this.mtxtPassword.Size = new System.Drawing.Size(216, 26);
            this.mtxtPassword.TabIndex = 7;
            // 
            // cmbStudyProgram
            // 
            this.cmbStudyProgram.FormattingEnabled = true;
            this.cmbStudyProgram.Items.AddRange(new object[] {
            "Honours",
            "Coursework Masters",
            "Full Research Masters",
            "PHD"});
            this.cmbStudyProgram.Location = new System.Drawing.Point(205, 222);
            this.cmbStudyProgram.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStudyProgram.Name = "cmbStudyProgram";
            this.cmbStudyProgram.Size = new System.Drawing.Size(249, 26);
            this.cmbStudyProgram.TabIndex = 10;
            // 
            // mtxtEmail
            // 
            this.mtxtEmail.Location = new System.Drawing.Point(205, 159);
            this.mtxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.Size = new System.Drawing.Size(249, 26);
            this.mtxtEmail.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(205, 27);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(249, 26);
            this.txtUsername.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Study Program:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "E-mail address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Useranme:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnCreate);
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Location = new System.Drawing.Point(100, 450);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 95);
            this.panel3.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(705, 22);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 50);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreate.FlatAppearance.BorderSize = 3;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(375, 22);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(149, 50);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.Location = new System.Drawing.Point(45, 22);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(149, 50);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grpTitle
            // 
            this.grpTitle.BackColor = System.Drawing.Color.White;
            this.grpTitle.Controls.Add(this.radOther);
            this.grpTitle.Controls.Add(this.radMs);
            this.grpTitle.Controls.Add(this.radMr);
            this.grpTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTitle.Location = new System.Drawing.Point(400, 385);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Size = new System.Drawing.Size(300, 58);
            this.grpTitle.TabIndex = 11;
            this.grpTitle.TabStop = false;
            this.grpTitle.Text = "Title";
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Location = new System.Drawing.Point(202, 25);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(72, 22);
            this.radOther.TabIndex = 14;
            this.radOther.TabStop = true;
            this.radOther.Text = "Other";
            this.radOther.UseVisualStyleBackColor = true;
            // 
            // radMs
            // 
            this.radMs.AutoSize = true;
            this.radMs.Location = new System.Drawing.Point(111, 25);
            this.radMs.Name = "radMs";
            this.radMs.Size = new System.Drawing.Size(48, 22);
            this.radMs.TabIndex = 13;
            this.radMs.TabStop = true;
            this.radMs.Text = "Ms";
            this.radMs.UseVisualStyleBackColor = true;
            // 
            // radMr
            // 
            this.radMr.AutoSize = true;
            this.radMr.Location = new System.Drawing.Point(22, 25);
            this.radMr.Name = "radMr";
            this.radMr.Size = new System.Drawing.Size(46, 22);
            this.radMr.TabIndex = 12;
            this.radMr.TabStop = true;
            this.radMr.Text = "Mr";
            this.radMr.UseVisualStyleBackColor = true;
            // 
            // RegisterStudentForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 553);
            this.Controls.Add(this.grpTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeading);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grpTitle.ResumeLayout(false);
            this.grpTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.MaskedTextBox mtxtTelephone;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtPassword;
        private System.Windows.Forms.ComboBox cmbStudyProgram;
        private System.Windows.Forms.MaskedTextBox mtxtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnViewPassword;
        private System.Windows.Forms.GroupBox grpTitle;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.RadioButton radMs;
        private System.Windows.Forms.RadioButton radMr;
    }
}