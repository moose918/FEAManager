
namespace FEAManager
{
    partial class FullScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullScreenForm));
            this.ptbRishkCategoryTable = new System.Windows.Forms.PictureBox();
            this.ptbApplicantForm = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRishkCategoryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbApplicantForm)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbRishkCategoryTable
            // 
            this.ptbRishkCategoryTable.Image = ((System.Drawing.Image)(resources.GetObject("ptbRishkCategoryTable.Image")));
            this.ptbRishkCategoryTable.Location = new System.Drawing.Point(60, 21);
            this.ptbRishkCategoryTable.Name = "ptbRishkCategoryTable";
            this.ptbRishkCategoryTable.Size = new System.Drawing.Size(751, 655);
            this.ptbRishkCategoryTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRishkCategoryTable.TabIndex = 0;
            this.ptbRishkCategoryTable.TabStop = false;
            // 
            // ptbApplicantForm
            // 
            this.ptbApplicantForm.Image = ((System.Drawing.Image)(resources.GetObject("ptbApplicantForm.Image")));
            this.ptbApplicantForm.Location = new System.Drawing.Point(179, 20);
            this.ptbApplicantForm.Name = "ptbApplicantForm";
            this.ptbApplicantForm.Size = new System.Drawing.Size(548, 655);
            this.ptbApplicantForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbApplicantForm.TabIndex = 1;
            this.ptbApplicantForm.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(354, 693);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 47);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FullScreenForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(870, 753);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ptbApplicantForm);
            this.Controls.Add(this.ptbRishkCategoryTable);
            this.Name = "FullScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FullScreen";
            ((System.ComponentModel.ISupportInitialize)(this.ptbRishkCategoryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbApplicantForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbRishkCategoryTable;
        private System.Windows.Forms.PictureBox ptbApplicantForm;
        private System.Windows.Forms.Button btnBack;
    }
}