
namespace FEAManager
{
    partial class AdminMainMenuForm
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
            this.btnManageReviewers = new System.Windows.Forms.Button();
            this.btnManageApplications = new System.Windows.Forms.Button();
            this.btnGenarateReport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfEthicsApplication = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageReviewers
            // 
            this.btnManageReviewers.Location = new System.Drawing.Point(281, 18);
            this.btnManageReviewers.Name = "btnManageReviewers";
            this.btnManageReviewers.Size = new System.Drawing.Size(112, 41);
            this.btnManageReviewers.TabIndex = 0;
            this.btnManageReviewers.Text = "Manage &Reviewers";
            this.btnManageReviewers.UseVisualStyleBackColor = true;
            this.btnManageReviewers.Click += new System.EventHandler(this.btnManageReviewers_Click);
            // 
            // btnManageApplications
            // 
            this.btnManageApplications.Location = new System.Drawing.Point(529, 18);
            this.btnManageApplications.Name = "btnManageApplications";
            this.btnManageApplications.Size = new System.Drawing.Size(110, 40);
            this.btnManageApplications.TabIndex = 1;
            this.btnManageApplications.Text = "Manage &Applications";
            this.btnManageApplications.UseVisualStyleBackColor = true;
            this.btnManageApplications.Click += new System.EventHandler(this.btnManageApplications_Click);
            // 
            // btnGenarateReport
            // 
            this.btnGenarateReport.Location = new System.Drawing.Point(56, 102);
            this.btnGenarateReport.Name = "btnGenarateReport";
            this.btnGenarateReport.Size = new System.Drawing.Size(112, 41);
            this.btnGenarateReport.TabIndex = 2;
            this.btnGenarateReport.Text = "&Genarate Monthly Report";
            this.btnGenarateReport.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnManageApplications);
            this.panel3.Controls.Add(this.btnManageReviewers);
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Location = new System.Drawing.Point(75, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 77);
            this.panel3.TabIndex = 29;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(34, 18);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 41);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "&Back";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 61);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Report for the month of ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Number of Ethics Application";
            // 
            // lblNumberOfEthicsApplication
            // 
            this.lblNumberOfEthicsApplication.AutoSize = true;
            this.lblNumberOfEthicsApplication.Location = new System.Drawing.Point(176, 175);
            this.lblNumberOfEthicsApplication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfEthicsApplication.Name = "lblNumberOfEthicsApplication";
            this.lblNumberOfEthicsApplication.Size = new System.Drawing.Size(15, 15);
            this.lblNumberOfEthicsApplication.TabIndex = 33;
            this.lblNumberOfEthicsApplication.Text = "\"\"";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNumberOfEthicsApplication);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnGenarateReport);
            this.panel2.Location = new System.Drawing.Point(300, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 223);
            this.panel2.TabIndex = 34;
            // 
            // AdminMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "AdminMainMenuForm";
            this.Text = "Admin Main Menu";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageReviewers;
        private System.Windows.Forms.Button btnManageApplications;
        private System.Windows.Forms.Button btnGenarateReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfEthicsApplication;
        private System.Windows.Forms.Panel panel2;
    }
}