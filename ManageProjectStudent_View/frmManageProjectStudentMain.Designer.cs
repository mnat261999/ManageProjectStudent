namespace ManageProjectStudent_View
{
    partial class frmManageProjectStudentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageProjectStudentMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExitFormProjectStudent = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnViewDeadlineStudent = new System.Windows.Forms.Button();
            this.btnSubmitProject = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnExitFormProjectStudent);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnViewDeadlineStudent);
            this.panelMenu.Controls.Add(this.btnSubmitProject);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 639);
            this.panelMenu.TabIndex = 2;
            // 
            // btnExitFormProjectStudent
            // 
            this.btnExitFormProjectStudent.FlatAppearance.BorderSize = 0;
            this.btnExitFormProjectStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormProjectStudent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormProjectStudent.ForeColor = System.Drawing.Color.White;
            this.btnExitFormProjectStudent.Image = global::ManageProjectStudent_View.Properties.Resources.return_30px;
            this.btnExitFormProjectStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitFormProjectStudent.Location = new System.Drawing.Point(0, 205);
            this.btnExitFormProjectStudent.Name = "btnExitFormProjectStudent";
            this.btnExitFormProjectStudent.Size = new System.Drawing.Size(171, 50);
            this.btnExitFormProjectStudent.TabIndex = 6;
            this.btnExitFormProjectStudent.Text = "Trở về";
            this.btnExitFormProjectStudent.UseVisualStyleBackColor = true;
            this.btnExitFormProjectStudent.Click += new System.EventHandler(this.btnExitFormProjectStudent_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(174, 87);
            this.panelLogo.TabIndex = 5;
            // 
            // btnViewDeadlineStudent
            // 
            this.btnViewDeadlineStudent.FlatAppearance.BorderSize = 0;
            this.btnViewDeadlineStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDeadlineStudent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDeadlineStudent.ForeColor = System.Drawing.Color.White;
            this.btnViewDeadlineStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDeadlineStudent.Image")));
            this.btnViewDeadlineStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDeadlineStudent.Location = new System.Drawing.Point(0, 149);
            this.btnViewDeadlineStudent.Name = "btnViewDeadlineStudent";
            this.btnViewDeadlineStudent.Size = new System.Drawing.Size(174, 50);
            this.btnViewDeadlineStudent.TabIndex = 4;
            this.btnViewDeadlineStudent.Text = "Xem hạn nộp";
            this.btnViewDeadlineStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewDeadlineStudent.UseVisualStyleBackColor = true;
            this.btnViewDeadlineStudent.Click += new System.EventHandler(this.btnViewDeadlineStudent_Click);
            // 
            // btnSubmitProject
            // 
            this.btnSubmitProject.FlatAppearance.BorderSize = 0;
            this.btnSubmitProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitProject.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitProject.ForeColor = System.Drawing.Color.White;
            this.btnSubmitProject.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmitProject.Image")));
            this.btnSubmitProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitProject.Location = new System.Drawing.Point(0, 93);
            this.btnSubmitProject.Name = "btnSubmitProject";
            this.btnSubmitProject.Size = new System.Drawing.Size(174, 50);
            this.btnSubmitProject.TabIndex = 2;
            this.btnSubmitProject.Text = "Nộp đồ án";
            this.btnSubmitProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmitProject.UseVisualStyleBackColor = true;
            this.btnSubmitProject.Click += new System.EventHandler(this.btnSubmitProject_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(174, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(999, 87);
            this.panelTitleBar.TabIndex = 3;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 87);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(355, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Đồ Án Cho Sinh Viên";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(174, 87);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(999, 552);
            this.panelDesktopPane.TabIndex = 4;
            // 
            // frmManageProjectStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 639);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageProjectStudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageProjectStudentMain";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnExitFormProjectStudent;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnViewDeadlineStudent;
        private System.Windows.Forms.Button btnSubmitProject;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}