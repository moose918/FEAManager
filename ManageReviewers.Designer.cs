
namespace FEAManager
{
    partial class frmManageReviewers
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtReviewerNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.mtxtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQualificationLevel = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnModify);
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Location = new System.Drawing.Point(100, 450);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 95);
            this.panel3.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(687, 22);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(259, 22);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(150, 50);
            this.btnModify.TabIndex = 22;
            this.btnModify.Text = "Update/Create";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(45, 22);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 50);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 43;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 235);
            this.dataGridView1.TabIndex = 28;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(17, 38);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(132, 22);
            this.txtFName.TabIndex = 30;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(169, 38);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(132, 22);
            this.txtLName.TabIndex = 31;
            // 
            // txtReviewerNumber
            // 
            this.txtReviewerNumber.Location = new System.Drawing.Point(18, 39);
            this.txtReviewerNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtReviewerNumber.Name = "txtReviewerNumber";
            this.txtReviewerNumber.Size = new System.Drawing.Size(132, 22);
            this.txtReviewerNumber.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "First Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Location = new System.Drawing.Point(15, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 80);
            this.panel1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Reviewer Number";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtReviewerNumber);
            this.panel4.Location = new System.Drawing.Point(458, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 80);
            this.panel4.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mtxtEmail);
            this.panel2.Controls.Add(this.mtxtTelephone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtQualificationLevel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(595, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 80);
            this.panel2.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Cellphone Number";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(321, 39);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(132, 22);
            this.dtpDOB.TabIndex = 40;
            // 
            // mtxtTelephone
            // 
            this.mtxtTelephone.Location = new System.Drawing.Point(17, 38);
            this.mtxtTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTelephone.Name = "mtxtTelephone";
            this.mtxtTelephone.Size = new System.Drawing.Size(132, 22);
            this.mtxtTelephone.TabIndex = 40;
            // 
            // mtxtEmail
            // 
            this.mtxtEmail.Location = new System.Drawing.Point(169, 38);
            this.mtxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.Size = new System.Drawing.Size(132, 22);
            this.mtxtEmail.TabIndex = 41;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(473, 22);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Qulification Level";
            // 
            // txtQualificationLevel
            // 
            this.txtQualificationLevel.Location = new System.Drawing.Point(321, 38);
            this.txtQualificationLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtQualificationLevel.Name = "txtQualificationLevel";
            this.txtQualificationLevel.Size = new System.Drawing.Size(132, 22);
            this.txtQualificationLevel.TabIndex = 31;
            // 
            // frmManageReviewers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManageReviewers";
            this.Text = "ManageReviewers";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtReviewerNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.MaskedTextBox mtxtTelephone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox mtxtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQualificationLevel;
    }
}