namespace ManageProjectStudent_View
{
    partial class frmSubmitProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubmitProject));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.LookUpEdit_Subject = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LookUpEdit_Lecturer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLinkFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvListLink = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTaskName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Task = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Project = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcListTask = new DevExpress.XtraGrid.GridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnChooseFolder = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChoosFile = new DevExpress.XtraEditors.SimpleButton();
            this.grpSubmit = new DevExpress.XtraEditors.GroupControl();
            this.lkeProject = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lkeTask = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Subject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Lecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Task)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListTask)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSubmit)).BeginInit();
            this.grpSubmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeTask.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(423, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nộp nhiệm vụ đồ án";
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
            this.panelTitleBar.TabIndex = 32;
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
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnUpdate.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdate.AppearanceHovered.Options.UseFont = true;
            this.btnUpdate.AppearanceHovered.Options.UseForeColor = true;
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(0, 546);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 42);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Nộp và Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnUpdate);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 617);
            this.panelMenu.TabIndex = 31;
            // 
            // LookUpEdit_Subject
            // 
            this.LookUpEdit_Subject.AutoHeight = false;
            this.LookUpEdit_Subject.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Subject.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colSubjectName", "Tên môn học"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colSubjectID", "Mã môn học", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LookUpEdit_Subject.DisplayMember = "StrSubjectName";
            this.LookUpEdit_Subject.Name = "LookUpEdit_Subject";
            this.LookUpEdit_Subject.ValueMember = "StrSubjectID";
            // 
            // LookUpEdit_Lecturer
            // 
            this.LookUpEdit_Lecturer.AutoHeight = false;
            this.LookUpEdit_Lecturer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Lecturer.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLecturerName", "Tên giảng viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLecturerID", "Mã Giảng viên", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LookUpEdit_Lecturer.DisplayMember = "StrStaffName";
            this.LookUpEdit_Lecturer.Name = "LookUpEdit_Lecturer";
            this.LookUpEdit_Lecturer.ValueMember = "StrStaffID";
            // 
            // colLinkFile
            // 
            this.colLinkFile.Caption = "Link File";
            this.colLinkFile.FieldName = "StrLinkFile";
            this.colLinkFile.Name = "colLinkFile";
            this.colLinkFile.Visible = true;
            this.colLinkFile.VisibleIndex = 3;
            this.colLinkFile.Width = 250;
            // 
            // gvListLink
            // 
            this.gvListLink.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListLink.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvListLink.Appearance.EvenRow.Options.UseFont = true;
            this.gvListLink.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListLink.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvListLink.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListLink.Appearance.OddRow.Options.UseBackColor = true;
            this.gvListLink.Appearance.OddRow.Options.UseFont = true;
            this.gvListLink.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListLink.Appearance.Row.Options.UseFont = true;
            this.gvListLink.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListLink.Appearance.SelectedRow.Options.UseFont = true;
            this.gvListLink.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListLink.Appearance.ViewCaption.Options.UseFont = true;
            this.gvListLink.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTaskName,
            this.colProjectName,
            this.colFileName,
            this.colLinkFile});
            this.gvListLink.GridControl = this.gcListTask;
            this.gvListLink.Name = "gvListLink";
            this.gvListLink.OptionsBehavior.Editable = false;
            this.gvListLink.OptionsSelection.MultiSelect = true;
            this.gvListLink.OptionsView.EnableAppearanceEvenRow = true;
            this.gvListLink.OptionsView.EnableAppearanceOddRow = true;
            this.gvListLink.OptionsView.ShowAutoFilterRow = true;
            this.gvListLink.OptionsView.ShowGroupPanel = false;
            this.gvListLink.OptionsView.ShowViewCaption = true;
            this.gvListLink.ViewCaption = "Danh sách link file";
            this.gvListLink.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvListLink_SelectionChanged);
            // 
            // colTaskName
            // 
            this.colTaskName.Caption = "Tên task";
            this.colTaskName.ColumnEdit = this.LookUpEdit_Task;
            this.colTaskName.FieldName = "StrTaskID";
            this.colTaskName.Name = "colTaskName";
            this.colTaskName.Visible = true;
            this.colTaskName.VisibleIndex = 0;
            // 
            // LookUpEdit_Task
            // 
            this.LookUpEdit_Task.AutoHeight = false;
            this.LookUpEdit_Task.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Task.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTaskName", "Tên task"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTaskID", "Mã task")});
            this.LookUpEdit_Task.DisplayMember = "StrTaskName";
            this.LookUpEdit_Task.Name = "LookUpEdit_Task";
            this.LookUpEdit_Task.ValueMember = "StrTaskID";
            // 
            // colProjectName
            // 
            this.colProjectName.Caption = "Tên đồ án";
            this.colProjectName.ColumnEdit = this.LookUpEdit_Project;
            this.colProjectName.FieldName = "StrProjectID";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 1;
            // 
            // LookUpEdit_Project
            // 
            this.LookUpEdit_Project.AutoHeight = false;
            this.LookUpEdit_Project.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Project.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colProjectName", "Tên đồ án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colProjectID", "Mã đồ án")});
            this.LookUpEdit_Project.DisplayMember = "StrProjectName";
            this.LookUpEdit_Project.Name = "LookUpEdit_Project";
            this.LookUpEdit_Project.ValueMember = "StrProjectID";
            // 
            // colFileName
            // 
            this.colFileName.Caption = "Tên File";
            this.colFileName.FieldName = "StrFileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 2;
            // 
            // gcListTask
            // 
            this.gcListTask.Location = new System.Drawing.Point(228, 427);
            this.gcListTask.MainView = this.gvListLink;
            this.gcListTask.Name = "gcListTask";
            this.gcListTask.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Lecturer,
            this.LookUpEdit_Subject,
            this.LookUpEdit_Project,
            this.LookUpEdit_Task});
            this.gcListTask.Size = new System.Drawing.Size(909, 183);
            this.gcListTask.TabIndex = 30;
            this.gcListTask.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListLink});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(55, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn biểu tượng để thêm file";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(628, 61);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(265, 25);
            this.txtFilePath.TabIndex = 112;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(531, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 17);
            this.labelControl3.TabIndex = 111;
            this.labelControl3.Text = "Nơi chứa file";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(628, 118);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(265, 25);
            this.txtFileName.TabIndex = 110;
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderPath.Location = new System.Drawing.Point(628, 174);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(265, 25);
            this.txtFolderPath.TabIndex = 109;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(567, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 17);
            this.labelControl2.TabIndex = 108;
            this.labelControl2.Text = "Tên file";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(544, 176);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 17);
            this.labelControl1.TabIndex = 107;
            this.labelControl1.Text = "Nơi lưu file";
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseFolder.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnChooseFolder.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChooseFolder.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnChooseFolder.Appearance.Options.UseBackColor = true;
            this.btnChooseFolder.Appearance.Options.UseFont = true;
            this.btnChooseFolder.Appearance.Options.UseForeColor = true;
            this.btnChooseFolder.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnChooseFolder.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChooseFolder.AppearanceHovered.Options.UseBackColor = true;
            this.btnChooseFolder.AppearanceHovered.Options.UseFont = true;
            this.btnChooseFolder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnChooseFolder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseFolder.ImageOptions.Image")));
            this.btnChooseFolder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnChooseFolder.Location = new System.Drawing.Point(265, 244);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(131, 36);
            this.btnChooseFolder.TabIndex = 106;
            this.btnChooseFolder.TabStop = false;
            this.btnChooseFolder.Text = "Chọn Folder";
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnSave.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.AppearanceHovered.Options.UseBackColor = true;
            this.btnSave.AppearanceHovered.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(459, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 36);
            this.btnSave.TabIndex = 104;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnChoosFile);
            this.panel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(24, 36);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 175);
            this.panel4.TabIndex = 27;
            // 
            // btnChoosFile
            // 
            this.btnChoosFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChoosFile.ImageOptions.Image")));
            this.btnChoosFile.Location = new System.Drawing.Point(102, 3);
            this.btnChoosFile.Name = "btnChoosFile";
            this.btnChoosFile.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnChoosFile.Size = new System.Drawing.Size(86, 104);
            this.btnChoosFile.TabIndex = 0;
            this.btnChoosFile.Click += new System.EventHandler(this.btnChoosFile_Click);
            // 
            // grpSubmit
            // 
            this.grpSubmit.Controls.Add(this.lkeProject);
            this.grpSubmit.Controls.Add(this.label2);
            this.grpSubmit.Controls.Add(this.lkeTask);
            this.grpSubmit.Controls.Add(this.label4);
            this.grpSubmit.Controls.Add(this.txtFilePath);
            this.grpSubmit.Controls.Add(this.labelControl3);
            this.grpSubmit.Controls.Add(this.txtFileName);
            this.grpSubmit.Controls.Add(this.txtFolderPath);
            this.grpSubmit.Controls.Add(this.labelControl2);
            this.grpSubmit.Controls.Add(this.labelControl1);
            this.grpSubmit.Controls.Add(this.btnChooseFolder);
            this.grpSubmit.Controls.Add(this.btnSave);
            this.grpSubmit.Controls.Add(this.panel4);
            this.grpSubmit.Location = new System.Drawing.Point(228, 105);
            this.grpSubmit.Name = "grpSubmit";
            this.grpSubmit.Size = new System.Drawing.Size(909, 301);
            this.grpSubmit.TabIndex = 29;
            this.grpSubmit.Text = "Nộp file";
            // 
            // lkeProject
            // 
            this.lkeProject.Enabled = false;
            this.lkeProject.Location = new System.Drawing.Point(383, 118);
            this.lkeProject.Name = "lkeProject";
            this.lkeProject.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeProject.Properties.Appearance.Options.UseFont = true;
            this.lkeProject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeProject.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colProjectName", "Tên đồ án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colProjectID", "Mã đồ án", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkeProject.Properties.NullText = "Đồ án";
            this.lkeProject.Size = new System.Drawing.Size(132, 24);
            this.lkeProject.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 113;
            this.label2.Text = "Đồ án";
            // 
            // lkeTask
            // 
            this.lkeTask.Enabled = false;
            this.lkeTask.Location = new System.Drawing.Point(383, 58);
            this.lkeTask.Name = "lkeTask";
            this.lkeTask.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeTask.Properties.Appearance.Options.UseFont = true;
            this.lkeTask.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeTask.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTaskName", "Tên task"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTaskID", "Mã task", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkeTask.Properties.NullText = "Task";
            this.lkeTask.Size = new System.Drawing.Size(132, 24);
            this.lkeTask.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 95;
            this.label4.Text = " Task";
            // 
            // frmSubmitProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 617);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.gcListTask);
            this.Controls.Add(this.grpSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubmitProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSubmitProject";
            this.Load += new System.EventHandler(this.frmSubmitProject_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Subject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Lecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Task)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListTask)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSubmit)).EndInit();
            this.grpSubmit.ResumeLayout(false);
            this.grpSubmit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeTask.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCloseChildForm;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Subject;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Lecturer;
        private DevExpress.XtraGrid.Columns.GridColumn colLinkFile;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListLink;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.GridControl gcListTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtFolderPath;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChooseFolder;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnChoosFile;
        private DevExpress.XtraEditors.GroupControl grpSubmit;
        private DevExpress.XtraEditors.LookUpEdit lkeTask;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lkeProject;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskName;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Project;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Task;
    }
}