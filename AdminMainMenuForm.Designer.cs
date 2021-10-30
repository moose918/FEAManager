
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbMothYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCounters = new System.Windows.Forms.Panel();
            this.lblNoSupervisors = new System.Windows.Forms.Label();
            this.lblNoReviewers = new System.Windows.Forms.Label();
            this.lblNoStudents = new System.Windows.Forms.Label();
            this.lblNoApplications = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlReviewers = new System.Windows.Forms.Panel();
            this.lblReviewerWithLeastApplications = new System.Windows.Forms.Label();
            this.lblReviewerWithMostApplications = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pblApplicationmStatuses = new System.Windows.Forms.Panel();
            this.lblNoRejected = new System.Windows.Forms.Label();
            this.lblNoPending = new System.Windows.Forms.Label();
            this.lblNoGranted = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlApplicationTypes = new System.Windows.Forms.Panel();
            this.lblNoEthics = new System.Windows.Forms.Label();
            this.lblNoWaiver = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCounters.SuspendLayout();
            this.pnlReviewers.SuspendLayout();
            this.pblApplicationmStatuses.SuspendLayout();
            this.pnlApplicationTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageReviewers
            // 
            this.btnManageReviewers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnManageReviewers.FlatAppearance.BorderSize = 3;
            this.btnManageReviewers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageReviewers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.btnManageReviewers.Location = new System.Drawing.Point(375, 22);
            this.btnManageReviewers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnManageReviewers.Name = "btnManageReviewers";
            this.btnManageReviewers.Size = new System.Drawing.Size(149, 50);
            this.btnManageReviewers.TabIndex = 4;
            this.btnManageReviewers.Text = "Manage &Reviewers";
            this.btnManageReviewers.UseVisualStyleBackColor = true;
            this.btnManageReviewers.Click += new System.EventHandler(this.btnManageReviewers_Click);
            // 
            // btnManageApplications
            // 
            this.btnManageApplications.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnManageApplications.FlatAppearance.BorderSize = 3;
            this.btnManageApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageApplications.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.btnManageApplications.Location = new System.Drawing.Point(705, 22);
            this.btnManageApplications.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnManageApplications.Name = "btnManageApplications";
            this.btnManageApplications.Size = new System.Drawing.Size(147, 49);
            this.btnManageApplications.TabIndex = 5;
            this.btnManageApplications.Text = "Manage &Applications";
            this.btnManageApplications.UseVisualStyleBackColor = true;
            this.btnManageApplications.Click += new System.EventHandler(this.btnManageApplications_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnManageApplications);
            this.panel3.Controls.Add(this.btnManageReviewers);
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.panel3.Location = new System.Drawing.Point(101, 435);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 95);
            this.panel3.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.Location = new System.Drawing.Point(45, 22);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(149, 50);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "&Back";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbMothYear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(300, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 125);
            this.panel1.TabIndex = 0;
            // 
            // cbbMothYear
            // 
            this.cbbMothYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMothYear.FormattingEnabled = true;
            this.cbbMothYear.Location = new System.Drawing.Point(125, 71);
            this.cbbMothYear.Name = "cbbMothYear";
            this.cbbMothYear.Size = new System.Drawing.Size(250, 37);
            this.cbbMothYear.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report for the month of";
            // 
            // pnlCounters
            // 
            this.pnlCounters.BackColor = System.Drawing.Color.White;
            this.pnlCounters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCounters.Controls.Add(this.lblNoSupervisors);
            this.pnlCounters.Controls.Add(this.lblNoReviewers);
            this.pnlCounters.Controls.Add(this.lblNoStudents);
            this.pnlCounters.Controls.Add(this.lblNoApplications);
            this.pnlCounters.Controls.Add(this.label11);
            this.pnlCounters.Controls.Add(this.label10);
            this.pnlCounters.Controls.Add(this.label9);
            this.pnlCounters.Controls.Add(this.label8);
            this.pnlCounters.Controls.Add(this.label2);
            this.pnlCounters.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCounters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlCounters.Location = new System.Drawing.Point(35, 175);
            this.pnlCounters.Name = "pnlCounters";
            this.pnlCounters.Size = new System.Drawing.Size(225, 235);
            this.pnlCounters.TabIndex = 31;
            // 
            // lblNoSupervisors
            // 
            this.lblNoSupervisors.AutoSize = true;
            this.lblNoSupervisors.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSupervisors.Location = new System.Drawing.Point(129, 188);
            this.lblNoSupervisors.Name = "lblNoSupervisors";
            this.lblNoSupervisors.Size = new System.Drawing.Size(30, 23);
            this.lblNoSupervisors.TabIndex = 8;
            this.lblNoSupervisors.Text = "\"\"";
            // 
            // lblNoReviewers
            // 
            this.lblNoReviewers.AutoSize = true;
            this.lblNoReviewers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoReviewers.Location = new System.Drawing.Point(129, 146);
            this.lblNoReviewers.Name = "lblNoReviewers";
            this.lblNoReviewers.Size = new System.Drawing.Size(30, 23);
            this.lblNoReviewers.TabIndex = 7;
            this.lblNoReviewers.Text = "\"\"";
            // 
            // lblNoStudents
            // 
            this.lblNoStudents.AutoSize = true;
            this.lblNoStudents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoStudents.Location = new System.Drawing.Point(129, 104);
            this.lblNoStudents.Name = "lblNoStudents";
            this.lblNoStudents.Size = new System.Drawing.Size(30, 23);
            this.lblNoStudents.TabIndex = 6;
            this.lblNoStudents.Text = "\"\"";
            // 
            // lblNoApplications
            // 
            this.lblNoApplications.AutoSize = true;
            this.lblNoApplications.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoApplications.Location = new System.Drawing.Point(129, 62);
            this.lblNoApplications.Name = "lblNoApplications";
            this.lblNoApplications.Size = new System.Drawing.Size(30, 23);
            this.lblNoApplications.TabIndex = 5;
            this.lblNoApplications.Text = "\"\"";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Supervisors:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Reviewers:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Students:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Applications:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Counters";
            // 
            // pnlReviewers
            // 
            this.pnlReviewers.BackColor = System.Drawing.Color.White;
            this.pnlReviewers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReviewers.Controls.Add(this.lblReviewerWithLeastApplications);
            this.pnlReviewers.Controls.Add(this.lblReviewerWithMostApplications);
            this.pnlReviewers.Controls.Add(this.label13);
            this.pnlReviewers.Controls.Add(this.label12);
            this.pnlReviewers.Controls.Add(this.label3);
            this.pnlReviewers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReviewers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlReviewers.Location = new System.Drawing.Point(295, 175);
            this.pnlReviewers.Name = "pnlReviewers";
            this.pnlReviewers.Size = new System.Drawing.Size(225, 235);
            this.pnlReviewers.TabIndex = 32;
            // 
            // lblReviewerWithLeastApplications
            // 
            this.lblReviewerWithLeastApplications.AutoSize = true;
            this.lblReviewerWithLeastApplications.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewerWithLeastApplications.Location = new System.Drawing.Point(101, 180);
            this.lblReviewerWithLeastApplications.Name = "lblReviewerWithLeastApplications";
            this.lblReviewerWithLeastApplications.Size = new System.Drawing.Size(30, 23);
            this.lblReviewerWithLeastApplications.TabIndex = 10;
            this.lblReviewerWithLeastApplications.Text = "\"\"";
            // 
            // lblReviewerWithMostApplications
            // 
            this.lblReviewerWithMostApplications.AutoSize = true;
            this.lblReviewerWithMostApplications.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewerWithMostApplications.Location = new System.Drawing.Point(101, 105);
            this.lblReviewerWithMostApplications.Name = "lblReviewerWithMostApplications";
            this.lblReviewerWithMostApplications.Size = new System.Drawing.Size(30, 23);
            this.lblReviewerWithMostApplications.TabIndex = 9;
            this.lblReviewerWithMostApplications.Text = "\"\"";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "Least Applications:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "Most Applications:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reviewers";
            // 
            // pblApplicationmStatuses
            // 
            this.pblApplicationmStatuses.BackColor = System.Drawing.Color.White;
            this.pblApplicationmStatuses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblApplicationmStatuses.Controls.Add(this.lblNoRejected);
            this.pblApplicationmStatuses.Controls.Add(this.lblNoPending);
            this.pblApplicationmStatuses.Controls.Add(this.lblNoGranted);
            this.pblApplicationmStatuses.Controls.Add(this.label16);
            this.pblApplicationmStatuses.Controls.Add(this.label15);
            this.pblApplicationmStatuses.Controls.Add(this.label14);
            this.pblApplicationmStatuses.Controls.Add(this.label5);
            this.pblApplicationmStatuses.Controls.Add(this.label4);
            this.pblApplicationmStatuses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pblApplicationmStatuses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pblApplicationmStatuses.Location = new System.Drawing.Point(555, 175);
            this.pblApplicationmStatuses.Name = "pblApplicationmStatuses";
            this.pblApplicationmStatuses.Size = new System.Drawing.Size(225, 235);
            this.pblApplicationmStatuses.TabIndex = 33;
            // 
            // lblNoRejected
            // 
            this.lblNoRejected.AutoSize = true;
            this.lblNoRejected.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRejected.Location = new System.Drawing.Point(119, 187);
            this.lblNoRejected.Name = "lblNoRejected";
            this.lblNoRejected.Size = new System.Drawing.Size(30, 23);
            this.lblNoRejected.TabIndex = 11;
            this.lblNoRejected.Text = "\"\"";
            // 
            // lblNoPending
            // 
            this.lblNoPending.AutoSize = true;
            this.lblNoPending.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPending.Location = new System.Drawing.Point(119, 143);
            this.lblNoPending.Name = "lblNoPending";
            this.lblNoPending.Size = new System.Drawing.Size(30, 23);
            this.lblNoPending.TabIndex = 10;
            this.lblNoPending.Text = "\"\"";
            // 
            // lblNoGranted
            // 
            this.lblNoGranted.AutoSize = true;
            this.lblNoGranted.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoGranted.Location = new System.Drawing.Point(119, 100);
            this.lblNoGranted.Name = "lblNoGranted";
            this.lblNoGranted.Size = new System.Drawing.Size(30, 23);
            this.lblNoGranted.TabIndex = 9;
            this.lblNoGranted.Text = "\"\"";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 187);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 23);
            this.label16.TabIndex = 9;
            this.label16.Text = "Rejected:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 23);
            this.label15.TabIndex = 8;
            this.label15.Text = "Pending:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 23);
            this.label14.TabIndex = 7;
            this.label14.Text = "Granted:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 34);
            this.label5.TabIndex = 3;
            this.label5.Text = "Statuses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "Application";
            // 
            // pnlApplicationTypes
            // 
            this.pnlApplicationTypes.BackColor = System.Drawing.Color.White;
            this.pnlApplicationTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlApplicationTypes.Controls.Add(this.lblNoEthics);
            this.pnlApplicationTypes.Controls.Add(this.lblNoWaiver);
            this.pnlApplicationTypes.Controls.Add(this.label18);
            this.pnlApplicationTypes.Controls.Add(this.label17);
            this.pnlApplicationTypes.Controls.Add(this.label7);
            this.pnlApplicationTypes.Controls.Add(this.label6);
            this.pnlApplicationTypes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlApplicationTypes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlApplicationTypes.Location = new System.Drawing.Point(815, 175);
            this.pnlApplicationTypes.Name = "pnlApplicationTypes";
            this.pnlApplicationTypes.Size = new System.Drawing.Size(225, 235);
            this.pnlApplicationTypes.TabIndex = 33;
            // 
            // lblNoEthics
            // 
            this.lblNoEthics.AutoSize = true;
            this.lblNoEthics.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEthics.Location = new System.Drawing.Point(117, 168);
            this.lblNoEthics.Name = "lblNoEthics";
            this.lblNoEthics.Size = new System.Drawing.Size(30, 23);
            this.lblNoEthics.TabIndex = 12;
            this.lblNoEthics.Text = "\"\"";
            // 
            // lblNoWaiver
            // 
            this.lblNoWaiver.AutoSize = true;
            this.lblNoWaiver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoWaiver.Location = new System.Drawing.Point(117, 108);
            this.lblNoWaiver.Name = "lblNoWaiver";
            this.lblNoWaiver.Size = new System.Drawing.Size(30, 23);
            this.lblNoWaiver.TabIndex = 9;
            this.lblNoWaiver.Text = "\"\"";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 23);
            this.label18.TabIndex = 11;
            this.label18.Text = "Ethics:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 23);
            this.label17.TabIndex = 10;
            this.label17.Text = "Waiver:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 34);
            this.label7.TabIndex = 4;
            this.label7.Text = "Applications";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "Types of";
            // 
            // AdminMainMenuForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.pnlApplicationTypes);
            this.Controls.Add(this.pblApplicationmStatuses);
            this.Controls.Add(this.pnlReviewers);
            this.Controls.Add(this.pnlCounters);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdminMainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Main Menu";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCounters.ResumeLayout(false);
            this.pnlCounters.PerformLayout();
            this.pnlReviewers.ResumeLayout(false);
            this.pnlReviewers.PerformLayout();
            this.pblApplicationmStatuses.ResumeLayout(false);
            this.pblApplicationmStatuses.PerformLayout();
            this.pnlApplicationTypes.ResumeLayout(false);
            this.pnlApplicationTypes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageReviewers;
        private System.Windows.Forms.Button btnManageApplications;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCounters;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlReviewers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pblApplicationmStatuses;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlApplicationTypes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNoSupervisors;
        private System.Windows.Forms.Label lblNoReviewers;
        private System.Windows.Forms.Label lblNoStudents;
        private System.Windows.Forms.Label lblNoApplications;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblReviewerWithLeastApplications;
        private System.Windows.Forms.Label lblReviewerWithMostApplications;
        private System.Windows.Forms.Label lblNoRejected;
        private System.Windows.Forms.Label lblNoPending;
        private System.Windows.Forms.Label lblNoGranted;
        private System.Windows.Forms.Label lblNoEthics;
        private System.Windows.Forms.Label lblNoWaiver;
        private System.Windows.Forms.ComboBox cbbMothYear;
    }
}