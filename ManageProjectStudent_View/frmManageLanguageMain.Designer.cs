namespace ManageProjectStudent_View
{
    partial class frmManageLanguageMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLanguageMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExitFormManageLanguage = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnChangeLanguage = new System.Windows.Forms.Button();
            this.btnManageLanguage = new System.Windows.Forms.Button();
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
            this.panelMenu.Controls.Add(this.btnExitFormManageLanguage);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnChangeLanguage);
            this.panelMenu.Controls.Add(this.btnManageLanguage);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 639);
            this.panelMenu.TabIndex = 3;
            // 
            // btnExitFormManageLanguage
            // 
            this.btnExitFormManageLanguage.FlatAppearance.BorderSize = 0;
            this.btnExitFormManageLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormManageLanguage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormManageLanguage.ForeColor = System.Drawing.Color.White;
            this.btnExitFormManageLanguage.Image = global::ManageProjectStudent_View.Properties.Resources.return_30px;
            this.btnExitFormManageLanguage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitFormManageLanguage.Location = new System.Drawing.Point(0, 205);
            this.btnExitFormManageLanguage.Name = "btnExitFormManageLanguage";
            this.btnExitFormManageLanguage.Size = new System.Drawing.Size(171, 50);
            this.btnExitFormManageLanguage.TabIndex = 6;
            this.btnExitFormManageLanguage.Text = "Trở về";
            this.btnExitFormManageLanguage.UseVisualStyleBackColor = true;
            this.btnExitFormManageLanguage.Click += new System.EventHandler(this.btnExitFormManageLanguage_Click);
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
            // btnChangeLanguage
            // 
            this.btnChangeLanguage.FlatAppearance.BorderSize = 0;
            this.btnChangeLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeLanguage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeLanguage.ForeColor = System.Drawing.Color.White;
            this.btnChangeLanguage.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeLanguage.Image")));
            this.btnChangeLanguage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeLanguage.Location = new System.Drawing.Point(0, 149);
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.Size = new System.Drawing.Size(174, 50);
            this.btnChangeLanguage.TabIndex = 4;
            this.btnChangeLanguage.Text = "Thay đổi ngôn ngữ";
            this.btnChangeLanguage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeLanguage.UseVisualStyleBackColor = true;
            this.btnChangeLanguage.Click += new System.EventHandler(this.btnChangeLanguage_Click);
            // 
            // btnManageLanguage
            // 
            this.btnManageLanguage.FlatAppearance.BorderSize = 0;
            this.btnManageLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageLanguage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLanguage.ForeColor = System.Drawing.Color.White;
            this.btnManageLanguage.Image = ((System.Drawing.Image)(resources.GetObject("btnManageLanguage.Image")));
            this.btnManageLanguage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageLanguage.Location = new System.Drawing.Point(0, 93);
            this.btnManageLanguage.Name = "btnManageLanguage";
            this.btnManageLanguage.Size = new System.Drawing.Size(174, 50);
            this.btnManageLanguage.TabIndex = 2;
            this.btnManageLanguage.Text = "Quản lý ngôn ngữ";
            this.btnManageLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageLanguage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageLanguage.UseVisualStyleBackColor = true;
            this.btnManageLanguage.Click += new System.EventHandler(this.btnManageLanguage_Click);
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
            this.panelTitleBar.TabIndex = 4;
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
            this.lblTitle.Location = new System.Drawing.Point(371, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Đa Ngôn Ngữ";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(174, 87);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(999, 552);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // frmManageLanguageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 639);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageLanguageMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageLanguageMain";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnExitFormManageLanguage;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnChangeLanguage;
        private System.Windows.Forms.Button btnManageLanguage;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}