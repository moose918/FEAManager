
namespace FEAManager
{
    partial class ManageApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageApplicationForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlReviewerProfile = new System.Windows.Forms.Panel();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.lblQualificationLevel = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbReviewers = new System.Windows.Forms.ListBox();
            this.btnSelectReviewer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemoveReviewerTwo = new System.Windows.Forms.Button();
            this.btnRemoveReviewerOne = new System.Windows.Forms.Button();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.radPending = new System.Windows.Forms.RadioButton();
            this.radRejected = new System.Windows.Forms.RadioButton();
            this.radGranted = new System.Windows.Forms.RadioButton();
            this.lblSelectedReviewerTwo = new System.Windows.Forms.Label();
            this.lblSelectedReviewerOne = new System.Windows.Forms.Label();
            this.lblSelectedApplicationNumber = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnViewReviwerProfile = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnViewApplication = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.lsbApplications = new System.Windows.Forms.ListBox();
            this.pnlApplicationView = new System.Windows.Forms.Panel();
            this.lblRiskCategory = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblStudyProgram = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCollectingData = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDateCompleted = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblApplicationType = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAdminFullName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.pnlReviewerProfile.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlApplicationView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnModify);
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Location = new System.Drawing.Point(75, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 77);
            this.panel3.TabIndex = 29;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(529, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 41);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(281, 18);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(112, 41);
            this.btnModify.TabIndex = 22;
            this.btnModify.Text = "&Update";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(34, 18);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 41);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlReviewerProfile
            // 
            this.pnlReviewerProfile.AutoScroll = true;
            this.pnlReviewerProfile.Controls.Add(this.lblDateOfBirth);
            this.pnlReviewerProfile.Controls.Add(this.lblEmail);
            this.pnlReviewerProfile.Controls.Add(this.lblTelephoneNumber);
            this.pnlReviewerProfile.Controls.Add(this.lblQualificationLevel);
            this.pnlReviewerProfile.Controls.Add(this.lblLastName);
            this.pnlReviewerProfile.Controls.Add(this.lblFirstName);
            this.pnlReviewerProfile.Controls.Add(this.label3);
            this.pnlReviewerProfile.Controls.Add(this.label5);
            this.pnlReviewerProfile.Controls.Add(this.label7);
            this.pnlReviewerProfile.Controls.Add(this.label6);
            this.pnlReviewerProfile.Controls.Add(this.label8);
            this.pnlReviewerProfile.Controls.Add(this.label9);
            this.pnlReviewerProfile.Controls.Add(this.label4);
            this.pnlReviewerProfile.Location = new System.Drawing.Point(566, 20);
            this.pnlReviewerProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlReviewerProfile.Name = "pnlReviewerProfile";
            this.pnlReviewerProfile.Size = new System.Drawing.Size(225, 327);
            this.pnlReviewerProfile.TabIndex = 30;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(123, 272);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(15, 15);
            this.lblDateOfBirth.TabIndex = 54;
            this.lblDateOfBirth.Text = "\"\"";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(123, 226);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(15, 15);
            this.lblEmail.TabIndex = 53;
            this.lblEmail.Text = "\"\"";
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Location = new System.Drawing.Point(123, 180);
            this.lblTelephoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(15, 15);
            this.lblTelephoneNumber.TabIndex = 52;
            this.lblTelephoneNumber.Text = "\"\"";
            // 
            // lblQualificationLevel
            // 
            this.lblQualificationLevel.AutoSize = true;
            this.lblQualificationLevel.Location = new System.Drawing.Point(123, 133);
            this.lblQualificationLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQualificationLevel.Name = "lblQualificationLevel";
            this.lblQualificationLevel.Size = new System.Drawing.Size(15, 15);
            this.lblQualificationLevel.TabIndex = 51;
            this.lblQualificationLevel.Text = "\"\"";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(123, 87);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(15, 15);
            this.lblLastName.TabIndex = 50;
            this.lblLastName.Text = "\"\"";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(123, 41);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(15, 15);
            this.lblFirstName.TabIndex = 49;
            this.lblFirstName.Text = "\"\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Cellphone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Date Of Birth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Email Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Qualification Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Reviewer profile for:";
            // 
            // lsbReviewers
            // 
            this.lsbReviewers.FormattingEnabled = true;
            this.lsbReviewers.Items.AddRange(new object[] {
            "This is where",
            "the revierwe names",
            "will go"});
            this.lsbReviewers.Location = new System.Drawing.Point(19, 41);
            this.lsbReviewers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbReviewers.Name = "lsbReviewers";
            this.lsbReviewers.Size = new System.Drawing.Size(188, 95);
            this.lsbReviewers.TabIndex = 31;
            // 
            // btnSelectReviewer
            // 
            this.btnSelectReviewer.Location = new System.Drawing.Point(44, 148);
            this.btnSelectReviewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectReviewer.Name = "btnSelectReviewer";
            this.btnSelectReviewer.Size = new System.Drawing.Size(112, 20);
            this.btnSelectReviewer.TabIndex = 35;
            this.btnSelectReviewer.Text = "Select Reviewer";
            this.btnSelectReviewer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Reviewers";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRemoveReviewerTwo);
            this.panel4.Controls.Add(this.btnRemoveReviewerOne);
            this.panel4.Controls.Add(this.grpStatus);
            this.panel4.Controls.Add(this.lblSelectedReviewerTwo);
            this.panel4.Controls.Add(this.lblSelectedReviewerOne);
            this.panel4.Controls.Add(this.lblSelectedApplicationNumber);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Location = new System.Drawing.Point(19, 226);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 122);
            this.panel4.TabIndex = 38;
            // 
            // btnRemoveReviewerTwo
            // 
            this.btnRemoveReviewerTwo.Location = new System.Drawing.Point(267, 83);
            this.btnRemoveReviewerTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveReviewerTwo.Name = "btnRemoveReviewerTwo";
            this.btnRemoveReviewerTwo.Size = new System.Drawing.Size(56, 19);
            this.btnRemoveReviewerTwo.TabIndex = 52;
            this.btnRemoveReviewerTwo.Text = "Remove";
            this.btnRemoveReviewerTwo.UseVisualStyleBackColor = true;
            // 
            // btnRemoveReviewerOne
            // 
            this.btnRemoveReviewerOne.Location = new System.Drawing.Point(267, 50);
            this.btnRemoveReviewerOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveReviewerOne.Name = "btnRemoveReviewerOne";
            this.btnRemoveReviewerOne.Size = new System.Drawing.Size(56, 19);
            this.btnRemoveReviewerOne.TabIndex = 51;
            this.btnRemoveReviewerOne.Text = "Remove";
            this.btnRemoveReviewerOne.UseVisualStyleBackColor = true;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.radPending);
            this.grpStatus.Controls.Add(this.radRejected);
            this.grpStatus.Controls.Add(this.radGranted);
            this.grpStatus.Location = new System.Drawing.Point(342, 12);
            this.grpStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpStatus.Size = new System.Drawing.Size(112, 98);
            this.grpStatus.TabIndex = 50;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // radPending
            // 
            this.radPending.AutoSize = true;
            this.radPending.Location = new System.Drawing.Point(16, 65);
            this.radPending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radPending.Name = "radPending";
            this.radPending.Size = new System.Drawing.Size(71, 19);
            this.radPending.TabIndex = 2;
            this.radPending.TabStop = true;
            this.radPending.Text = "Pending";
            this.radPending.UseVisualStyleBackColor = true;
            // 
            // radRejected
            // 
            this.radRejected.AutoSize = true;
            this.radRejected.Location = new System.Drawing.Point(16, 45);
            this.radRejected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radRejected.Name = "radRejected";
            this.radRejected.Size = new System.Drawing.Size(74, 19);
            this.radRejected.TabIndex = 1;
            this.radRejected.TabStop = true;
            this.radRejected.Text = "Rejected";
            this.radRejected.UseVisualStyleBackColor = true;
            // 
            // radGranted
            // 
            this.radGranted.AutoSize = true;
            this.radGranted.Location = new System.Drawing.Point(16, 24);
            this.radGranted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radGranted.Name = "radGranted";
            this.radGranted.Size = new System.Drawing.Size(69, 19);
            this.radGranted.TabIndex = 0;
            this.radGranted.TabStop = true;
            this.radGranted.Text = "Granted";
            this.radGranted.UseVisualStyleBackColor = true;
            // 
            // lblSelectedReviewerTwo
            // 
            this.lblSelectedReviewerTwo.AutoSize = true;
            this.lblSelectedReviewerTwo.Location = new System.Drawing.Point(159, 85);
            this.lblSelectedReviewerTwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedReviewerTwo.Name = "lblSelectedReviewerTwo";
            this.lblSelectedReviewerTwo.Size = new System.Drawing.Size(15, 15);
            this.lblSelectedReviewerTwo.TabIndex = 49;
            this.lblSelectedReviewerTwo.Text = "\"\"";
            // 
            // lblSelectedReviewerOne
            // 
            this.lblSelectedReviewerOne.AutoSize = true;
            this.lblSelectedReviewerOne.Location = new System.Drawing.Point(159, 53);
            this.lblSelectedReviewerOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedReviewerOne.Name = "lblSelectedReviewerOne";
            this.lblSelectedReviewerOne.Size = new System.Drawing.Size(15, 15);
            this.lblSelectedReviewerOne.TabIndex = 48;
            this.lblSelectedReviewerOne.Text = "\"\"";
            // 
            // lblSelectedApplicationNumber
            // 
            this.lblSelectedApplicationNumber.AutoSize = true;
            this.lblSelectedApplicationNumber.Location = new System.Drawing.Point(159, 20);
            this.lblSelectedApplicationNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedApplicationNumber.Name = "lblSelectedApplicationNumber";
            this.lblSelectedApplicationNumber.Size = new System.Drawing.Size(15, 15);
            this.lblSelectedApplicationNumber.TabIndex = 47;
            this.lblSelectedApplicationNumber.Text = "\"\"";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(38, 85);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 15);
            this.label21.TabIndex = 46;
            this.label21.Text = "2. Reviewer Number:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(38, 53);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 15);
            this.label20.TabIndex = 45;
            this.label20.Text = "1. Reviewer Number:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(38, 20);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 15);
            this.label19.TabIndex = 44;
            this.label19.Text = "Application Number: ";
            // 
            // btnViewReviwerProfile
            // 
            this.btnViewReviwerProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnViewReviwerProfile.Image")));
            this.btnViewReviwerProfile.Location = new System.Drawing.Point(161, 148);
            this.btnViewReviwerProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewReviwerProfile.Name = "btnViewReviwerProfile";
            this.btnViewReviwerProfile.Size = new System.Drawing.Size(19, 20);
            this.btnViewReviwerProfile.TabIndex = 39;
            this.btnViewReviwerProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewReviwerProfile.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnViewReviwerProfile);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnSelectReviewer);
            this.panel5.Controls.Add(this.lsbReviewers);
            this.panel5.Location = new System.Drawing.Point(19, 20);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 183);
            this.panel5.TabIndex = 41;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnViewApplication);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnAddApplication);
            this.panel6.Controls.Add(this.lsbApplications);
            this.panel6.Location = new System.Drawing.Point(286, 20);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 183);
            this.panel6.TabIndex = 42;
            // 
            // btnViewApplication
            // 
            this.btnViewApplication.Image = ((System.Drawing.Image)(resources.GetObject("btnViewApplication.Image")));
            this.btnViewApplication.Location = new System.Drawing.Point(161, 148);
            this.btnViewApplication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewApplication.Name = "btnViewApplication";
            this.btnViewApplication.Size = new System.Drawing.Size(19, 20);
            this.btnViewApplication.TabIndex = 39;
            this.btnViewApplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewApplication.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Applications";
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Location = new System.Drawing.Point(44, 148);
            this.btnAddApplication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(112, 20);
            this.btnAddApplication.TabIndex = 35;
            this.btnAddApplication.Text = "Select Application";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            // 
            // lsbApplications
            // 
            this.lsbApplications.FormattingEnabled = true;
            this.lsbApplications.Items.AddRange(new object[] {
            "This is where",
            "Applications",
            "will go"});
            this.lsbApplications.Location = new System.Drawing.Point(19, 41);
            this.lsbApplications.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbApplications.Name = "lsbApplications";
            this.lsbApplications.Size = new System.Drawing.Size(188, 95);
            this.lsbApplications.TabIndex = 31;
            // 
            // pnlApplicationView
            // 
            this.pnlApplicationView.Controls.Add(this.lblRiskCategory);
            this.pnlApplicationView.Controls.Add(this.label18);
            this.pnlApplicationView.Controls.Add(this.lblSupervisor);
            this.pnlApplicationView.Controls.Add(this.label17);
            this.pnlApplicationView.Controls.Add(this.lblStudyProgram);
            this.pnlApplicationView.Controls.Add(this.label15);
            this.pnlApplicationView.Controls.Add(this.lblCollectingData);
            this.pnlApplicationView.Controls.Add(this.label14);
            this.pnlApplicationView.Controls.Add(this.lblStatus);
            this.pnlApplicationView.Controls.Add(this.label12);
            this.pnlApplicationView.Controls.Add(this.lblDateCompleted);
            this.pnlApplicationView.Controls.Add(this.label16);
            this.pnlApplicationView.Controls.Add(this.label11);
            this.pnlApplicationView.Controls.Add(this.lblApplicationType);
            this.pnlApplicationView.Controls.Add(this.label13);
            this.pnlApplicationView.Controls.Add(this.lblAdminFullName);
            this.pnlApplicationView.Controls.Add(this.label10);
            this.pnlApplicationView.Controls.Add(this.panel7);
            this.pnlApplicationView.Location = new System.Drawing.Point(566, 20);
            this.pnlApplicationView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlApplicationView.Name = "pnlApplicationView";
            this.pnlApplicationView.Size = new System.Drawing.Size(225, 327);
            this.pnlApplicationView.TabIndex = 32;
            // 
            // lblRiskCategory
            // 
            this.lblRiskCategory.AutoSize = true;
            this.lblRiskCategory.Location = new System.Drawing.Point(112, 246);
            this.lblRiskCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRiskCategory.Name = "lblRiskCategory";
            this.lblRiskCategory.Size = new System.Drawing.Size(15, 15);
            this.lblRiskCategory.TabIndex = 59;
            this.lblRiskCategory.Text = "\"\"";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 246);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 15);
            this.label18.TabIndex = 58;
            this.label18.Text = "Risk Category:";
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Location = new System.Drawing.Point(112, 146);
            this.lblSupervisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(15, 15);
            this.lblSupervisor.TabIndex = 57;
            this.lblSupervisor.Text = "\"\"";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 146);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 56;
            this.label17.Text = "Supervisor:";
            // 
            // lblStudyProgram
            // 
            this.lblStudyProgram.AutoSize = true;
            this.lblStudyProgram.Location = new System.Drawing.Point(112, 180);
            this.lblStudyProgram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudyProgram.Name = "lblStudyProgram";
            this.lblStudyProgram.Size = new System.Drawing.Size(15, 15);
            this.lblStudyProgram.TabIndex = 55;
            this.lblStudyProgram.Text = "\"\"";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 180);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 15);
            this.label15.TabIndex = 54;
            this.label15.Text = "Study Program:";
            // 
            // lblCollectingData
            // 
            this.lblCollectingData.AutoSize = true;
            this.lblCollectingData.Location = new System.Drawing.Point(112, 213);
            this.lblCollectingData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCollectingData.Name = "lblCollectingData";
            this.lblCollectingData.Size = new System.Drawing.Size(15, 15);
            this.lblCollectingData.TabIndex = 53;
            this.lblCollectingData.Text = "\"\"";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 213);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 15);
            this.label14.TabIndex = 52;
            this.label14.Text = "Collecting Data:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(112, 80);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 15);
            this.lblStatus.TabIndex = 51;
            this.lblStatus.Text = "\"\"";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 50;
            this.label12.Text = "Status:";
            // 
            // lblDateCompleted
            // 
            this.lblDateCompleted.AutoSize = true;
            this.lblDateCompleted.Location = new System.Drawing.Point(112, 280);
            this.lblDateCompleted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateCompleted.Name = "lblDateCompleted";
            this.lblDateCompleted.Size = new System.Drawing.Size(15, 15);
            this.lblDateCompleted.TabIndex = 49;
            this.lblDateCompleted.Text = "\"\"";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 280);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 15);
            this.label16.TabIndex = 48;
            this.label16.Text = "Date Completed:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 113);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Application Type:";
            // 
            // lblApplicationType
            // 
            this.lblApplicationType.AutoSize = true;
            this.lblApplicationType.Location = new System.Drawing.Point(112, 113);
            this.lblApplicationType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicationType.Name = "lblApplicationType";
            this.lblApplicationType.Size = new System.Drawing.Size(15, 15);
            this.lblApplicationType.TabIndex = 47;
            this.lblApplicationType.Text = "\"\"";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 15);
            this.label13.TabIndex = 44;
            this.label13.Text = "Admin Full Name:";
            // 
            // lblAdminFullName
            // 
            this.lblAdminFullName.AutoSize = true;
            this.lblAdminFullName.Location = new System.Drawing.Point(112, 46);
            this.lblAdminFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminFullName.Name = "lblAdminFullName";
            this.lblAdminFullName.Size = new System.Drawing.Size(15, 15);
            this.lblAdminFullName.TabIndex = 45;
            this.lblAdminFullName.Text = "\"\"";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "Application Number: ";
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(566, 92);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 327);
            this.panel7.TabIndex = 31;
            // 
            // ManageApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 449);
            this.Controls.Add(this.pnlApplicationView);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlReviewerProfile);
            this.Controls.Add(this.panel3);
            this.Name = "ManageApplicationForm";
            this.Text = "ManageApplication";
            this.panel3.ResumeLayout(false);
            this.pnlReviewerProfile.ResumeLayout(false);
            this.pnlReviewerProfile.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlApplicationView.ResumeLayout(false);
            this.pnlApplicationView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlReviewerProfile;
        private System.Windows.Forms.ListBox lsbReviewers;
        private System.Windows.Forms.Button btnSelectReviewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnViewReviwerProfile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnViewApplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.ListBox lsbApplications;
        private System.Windows.Forms.Panel pnlApplicationView;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephoneNumber;
        private System.Windows.Forms.Label lblQualificationLevel;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblApplicationType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAdminFullName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDateCompleted;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCollectingData;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblStudyProgram;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSelectedReviewerTwo;
        private System.Windows.Forms.Label lblSelectedApplicationNumber;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblRiskCategory;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblSelectedReviewerOne;
        private System.Windows.Forms.Button btnRemoveReviewerTwo;
        private System.Windows.Forms.Button btnRemoveReviewerOne;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton radPending;
        private System.Windows.Forms.RadioButton radRejected;
        private System.Windows.Forms.RadioButton radGranted;
    }
}