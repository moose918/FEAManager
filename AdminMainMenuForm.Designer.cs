
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainMenuForm));
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
            this.btnManageReviewers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnManageReviewers.FlatAppearance.BorderSize = 3;
            this.btnManageReviewers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageReviewers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.btnManageReviewers.Location = new System.Drawing.Point(375, 22);
            this.btnManageReviewers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnManageReviewers.Name = "btnManageReviewers";
            this.btnManageReviewers.Size = new System.Drawing.Size(149, 50);
            this.btnManageReviewers.TabIndex = 0;
            this.btnManageReviewers.Text = "Manage &Reviewers";
            this.btnManageReviewers.UseVisualStyleBackColor = true;
            this.btnManageReviewers.Click += new System.EventHandler(this.btnManageReviewers_Click);
            // 
            // btnManageApplications
            // 
            this.btnManageApplications.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnManageApplications.FlatAppearance.BorderSize = 3;
            this.btnManageApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageApplications.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.btnManageApplications.Location = new System.Drawing.Point(705, 22);
            this.btnManageApplications.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnManageApplications.Name = "btnManageApplications";
            this.btnManageApplications.Size = new System.Drawing.Size(147, 49);
            this.btnManageApplications.TabIndex = 1;
            this.btnManageApplications.Text = "Manage &Applications";
            this.btnManageApplications.UseVisualStyleBackColor = true;
            this.btnManageApplications.Click += new System.EventHandler(this.btnManageApplications_Click);
            // 
            // btnGenarateReport
            // 
            this.btnGenarateReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenarateReport.FlatAppearance.BorderSize = 3;
            this.btnGenarateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenarateReport.Location = new System.Drawing.Point(75, 135);
            this.btnGenarateReport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGenarateReport.Name = "btnGenarateReport";
            this.btnGenarateReport.Size = new System.Drawing.Size(150, 50);
            this.btnGenarateReport.TabIndex = 2;
            this.btnGenarateReport.Text = "&Genarate Monthly Report";
            this.btnGenarateReport.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnManageApplications);
            this.panel3.Controls.Add(this.btnManageReviewers);
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.panel3.Location = new System.Drawing.Point(101, 406);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 95);
            this.panel3.TabIndex = 29;
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.Location = new System.Drawing.Point(45, 22);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(149, 50);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "&Back";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 75);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 31);
            this.comboBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Report for the month of ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.Location = new System.Drawing.Point(25, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Number of Ethics Application";
            // 
            // lblNumberOfEthicsApplication
            // 
            this.lblNumberOfEthicsApplication.AutoSize = true;
            this.lblNumberOfEthicsApplication.Location = new System.Drawing.Point(139, 240);
            this.lblNumberOfEthicsApplication.Name = "lblNumberOfEthicsApplication";
            this.lblNumberOfEthicsApplication.Size = new System.Drawing.Size(22, 16);
            this.lblNumberOfEthicsApplication.TabIndex = 33;
            this.lblNumberOfEthicsApplication.Text = "\"\"";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblNumberOfEthicsApplication);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnGenarateReport);
            this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.panel2.Location = new System.Drawing.Point(400, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 274);
            this.panel2.TabIndex = 34;
            // 
            // AdminMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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