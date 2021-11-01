
namespace FEAManager
{
    partial class ManageRevierwerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRevierwerForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtReviewerNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbQulificationLevel = new System.Windows.Forms.ComboBox();
            this.mtxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.npiReviewers = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.number = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fEAManager_DBDataSet = new FEAManager.FEAManager_DBDataSet();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new FEAManager.FEAManager_DBDataSetTableAdapters.AdminTableAdapter();
            this.reviewerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewerTableAdapter = new FEAManager.FEAManager_DBDataSetTableAdapters.ReviewerTableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npiReviewers)).BeginInit();
            this.npiReviewers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fEAManager_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnCreate);
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Location = new System.Drawing.Point(15, 450);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 95);
            this.panel3.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 3;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(450, 22);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 50);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(650, 22);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(850, 22);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 16;
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
            this.btnCreate.Location = new System.Drawing.Point(250, 22);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 50);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Cre&ate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.Location = new System.Drawing.Point(50, 22);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 50);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 43;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 235);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtFName.Location = new System.Drawing.Point(17, 38);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(132, 23);
            this.txtFName.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtLName.Location = new System.Drawing.Point(169, 38);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(132, 23);
            this.txtLName.TabIndex = 5;
            // 
            // txtReviewerNumber
            // 
            this.txtReviewerNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtReviewerNumber.Location = new System.Drawing.Point(19, 39);
            this.txtReviewerNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtReviewerNumber.Name = "txtReviewerNumber";
            this.txtReviewerNumber.Size = new System.Drawing.Size(132, 23);
            this.txtReviewerNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "First Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.panel1.Location = new System.Drawing.Point(15, 359);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 80);
            this.panel1.TabIndex = 3;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(321, 39);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(132, 23);
            this.dtpDOB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Date Of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Reviewer Number";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtReviewerNumber);
            this.panel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.panel4.Location = new System.Drawing.Point(459, 265);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 80);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbbQulificationLevel);
            this.panel2.Controls.Add(this.mtxtEmail);
            this.panel2.Controls.Add(this.mtxtTelephone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.panel2.Location = new System.Drawing.Point(595, 363);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 80);
            this.panel2.TabIndex = 7;
            // 
            // cbbQulificationLevel
            // 
            this.cbbQulificationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQulificationLevel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.cbbQulificationLevel.FormattingEnabled = true;
            this.cbbQulificationLevel.Items.AddRange(new object[] {
            "Honours",
            "Coursework Masters",
            "Full Research Masters",
            "PHD"});
            this.cbbQulificationLevel.Location = new System.Drawing.Point(321, 38);
            this.cbbQulificationLevel.Name = "cbbQulificationLevel";
            this.cbbQulificationLevel.Size = new System.Drawing.Size(132, 23);
            this.cbbQulificationLevel.TabIndex = 40;
            // 
            // mtxtEmail
            // 
            this.mtxtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.mtxtEmail.Location = new System.Drawing.Point(169, 38);
            this.mtxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.Size = new System.Drawing.Size(132, 23);
            this.mtxtEmail.TabIndex = 9;
            // 
            // mtxtTelephone
            // 
            this.mtxtTelephone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.mtxtTelephone.Location = new System.Drawing.Point(17, 38);
            this.mtxtTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTelephone.Mask = "(999) 000-0000";
            this.mtxtTelephone.Name = "mtxtTelephone";
            this.mtxtTelephone.Size = new System.Drawing.Size(132, 23);
            this.mtxtTelephone.TabIndex = 8;
            this.mtxtTelephone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Qulification Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Cellphone Number";
            // 
            // npiReviewers
            // 
            this.npiReviewers.AddNewItem = null;
            this.npiReviewers.CountItem = this.bindingNavigatorCountItem;
            this.npiReviewers.DeleteItem = null;
            this.npiReviewers.Dock = System.Windows.Forms.DockStyle.None;
            this.npiReviewers.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.npiReviewers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.number,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.npiReviewers.Location = new System.Drawing.Point(32, 254);
            this.npiReviewers.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.npiReviewers.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.npiReviewers.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.npiReviewers.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.npiReviewers.Name = "npiReviewers";
            this.npiReviewers.PositionItem = this.number;
            this.npiReviewers.Size = new System.Drawing.Size(224, 27);
            this.npiReviewers.TabIndex = 0;
            this.npiReviewers.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // number
            // 
            this.number.AccessibleName = "Position";
            this.number.AutoSize = false;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(65, 27);
            this.number.Text = "0";
            this.number.ToolTipText = "Current position";
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // fEAManager_DBDataSet
            // 
            this.fEAManager_DBDataSet.DataSetName = "FEAManager_DBDataSet";
            this.fEAManager_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.fEAManager_DBDataSet;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // reviewerBindingSource
            // 
            this.reviewerBindingSource.DataMember = "Reviewer";
            this.reviewerBindingSource.DataSource = this.fEAManager_DBDataSet;
            // 
            // reviewerTableAdapter
            // 
            this.reviewerTableAdapter.ClearBeforeFill = true;
            // 
            // ManageRevierwerForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.npiReviewers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageRevierwerForm";
            this.Text = "ManageReviewers";
            this.Load += new System.EventHandler(this.ManageRevierwerForm_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npiReviewers)).EndInit();
            this.npiReviewers.ResumeLayout(false);
            this.npiReviewers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fEAManager_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
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
        private System.Windows.Forms.BindingNavigator npiReviewers;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox number;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbbQulificationLevel;
        private FEAManager_DBDataSet fEAManager_DBDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private FEAManager_DBDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.BindingSource reviewerBindingSource;
        private FEAManager_DBDataSetTableAdapters.ReviewerTableAdapter reviewerTableAdapter;
    }
}