namespace ManageProjectStudent_View
{
    partial class frmAddGroupForSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGroupForSubject));
            this.grpInformationGroup = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lkeSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lkeLecturer = new DevExpress.XtraEditors.LookUpEdit();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gcListGroup = new DevExpress.XtraGrid.GridControl();
            this.gvListCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Subject = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLecturer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Lecturer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnExitFormManageCourse = new System.Windows.Forms.Button();
            this.btnExitFormDecentralization = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationGroup)).BeginInit();
            this.grpInformationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeLecturer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Subject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Lecturer)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInformationGroup
            // 
            this.grpInformationGroup.Controls.Add(this.btnSave);
            this.grpInformationGroup.Controls.Add(this.label4);
            this.grpInformationGroup.Controls.Add(this.lkeSubject);
            this.grpInformationGroup.Controls.Add(this.txtName);
            this.grpInformationGroup.Controls.Add(this.lkeLecturer);
            this.grpInformationGroup.Controls.Add(this.txtID);
            this.grpInformationGroup.Controls.Add(this.label1);
            this.grpInformationGroup.Controls.Add(this.label3);
            this.grpInformationGroup.Controls.Add(this.label2);
            this.grpInformationGroup.Location = new System.Drawing.Point(180, 93);
            this.grpInformationGroup.Name = "grpInformationGroup";
            this.grpInformationGroup.Size = new System.Drawing.Size(728, 155);
            this.grpInformationGroup.TabIndex = 3;
            this.grpInformationGroup.Text = "Thêm nhóm môn học";
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
            this.btnSave.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnSave.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.AppearanceHovered.Options.UseBackColor = true;
            this.btnSave.AppearanceHovered.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(285, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 34);
            this.btnSave.TabIndex = 125;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giảng viên";
            // 
            // lkeSubject
            // 
            this.lkeSubject.Location = new System.Drawing.Point(190, 64);
            this.lkeSubject.Name = "lkeSubject";
            this.lkeSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeSubject.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colSubjectName", "Tên môn học"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colSubjectID", "Mã Môn học")});
            this.lkeSubject.Size = new System.Drawing.Size(131, 20);
            this.lkeSubject.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(469, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 21);
            this.txtName.TabIndex = 11;
            // 
            // lkeLecturer
            // 
            this.lkeLecturer.Location = new System.Drawing.Point(469, 64);
            this.lkeLecturer.Name = "lkeLecturer";
            this.lkeLecturer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeLecturer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLecturerName", "Tên giảng viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLecturerID", "Mã giảng viên")});
            this.lkeLecturer.Size = new System.Drawing.Size(131, 20);
            this.lkeLecturer.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(190, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(131, 21);
            this.txtID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Nhóm";
            // 
            // gcListGroup
            // 
            this.gcListGroup.Location = new System.Drawing.Point(180, 254);
            this.gcListGroup.MainView = this.gvListCourse;
            this.gcListGroup.Name = "gcListGroup";
            this.gcListGroup.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Subject,
            this.LookUpEdit_Lecturer});
            this.gcListGroup.Size = new System.Drawing.Size(728, 286);
            this.gcListGroup.TabIndex = 126;
            this.gcListGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListCourse});
            // 
            // gvListCourse
            // 
            this.gvListCourse.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListCourse.Appearance.EvenRow.Options.UseFont = true;
            this.gvListCourse.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListCourse.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvListCourse.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListCourse.Appearance.OddRow.Options.UseFont = true;
            this.gvListCourse.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListCourse.Appearance.ViewCaption.Options.UseFont = true;
            this.gvListCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroupID,
            this.colGroupName,
            this.colSubject,
            this.colLecturer});
            this.gvListCourse.GridControl = this.gcListGroup;
            this.gvListCourse.Name = "gvListCourse";
            this.gvListCourse.OptionsBehavior.Editable = false;
            this.gvListCourse.OptionsSelection.MultiSelect = true;
            this.gvListCourse.OptionsView.EnableAppearanceEvenRow = true;
            this.gvListCourse.OptionsView.EnableAppearanceOddRow = true;
            this.gvListCourse.OptionsView.ShowAutoFilterRow = true;
            this.gvListCourse.OptionsView.ShowGroupPanel = false;
            this.gvListCourse.OptionsView.ShowViewCaption = true;
            this.gvListCourse.ViewCaption = "Danh sách nhóm môn học";
            this.gvListCourse.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvListCourse_CustomDrawRowIndicator);
            this.gvListCourse.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvListCourse_SelectionChanged);
            this.gvListCourse.RowCountChanged += new System.EventHandler(this.gvListCourse_RowCountChanged);
            // 
            // colGroupID
            // 
            this.colGroupID.Caption = "Mã nhóm";
            this.colGroupID.FieldName = "StrGroupID";
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.Visible = true;
            this.colGroupID.VisibleIndex = 0;
            // 
            // colGroupName
            // 
            this.colGroupName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colGroupName.AppearanceCell.Options.UseFont = true;
            this.colGroupName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colGroupName.AppearanceHeader.Options.UseFont = true;
            this.colGroupName.Caption = "Tên nhóm";
            this.colGroupName.FieldName = "StrGroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 1;
            // 
            // colSubject
            // 
            this.colSubject.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colSubject.AppearanceCell.Options.UseFont = true;
            this.colSubject.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colSubject.AppearanceHeader.Options.UseFont = true;
            this.colSubject.Caption = "Môn học";
            this.colSubject.ColumnEdit = this.LookUpEdit_Subject;
            this.colSubject.FieldName = "StrSubjectID";
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 2;
            // 
            // LookUpEdit_Subject
            // 
            this.LookUpEdit_Subject.AutoHeight = false;
            this.LookUpEdit_Subject.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Subject.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colSubjectName", "Tên môn học"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colSubjectID", "Mã môn học")});
            this.LookUpEdit_Subject.DisplayMember = "StrSubjectName";
            this.LookUpEdit_Subject.Name = "LookUpEdit_Subject";
            this.LookUpEdit_Subject.ValueMember = "StrSubjectID";
            // 
            // colLecturer
            // 
            this.colLecturer.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLecturer.AppearanceCell.Options.UseFont = true;
            this.colLecturer.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLecturer.AppearanceHeader.Options.UseFont = true;
            this.colLecturer.Caption = "Giảng viên";
            this.colLecturer.ColumnEdit = this.LookUpEdit_Lecturer;
            this.colLecturer.FieldName = "StrStaffID";
            this.colLecturer.Name = "colLecturer";
            this.colLecturer.Visible = true;
            this.colLecturer.VisibleIndex = 3;
            // 
            // LookUpEdit_Lecturer
            // 
            this.LookUpEdit_Lecturer.AutoHeight = false;
            this.LookUpEdit_Lecturer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Lecturer.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLecturerName", "Tên giảng viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLecturerID", "Mã giảng viên")});
            this.LookUpEdit_Lecturer.DisplayMember = "StrStaffName";
            this.LookUpEdit_Lecturer.Name = "LookUpEdit_Lecturer";
            this.LookUpEdit_Lecturer.ValueMember = "StrStaffID";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnUpdate);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 552);
            this.panelMenu.TabIndex = 127;
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
            this.btnUpdate.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdate.AppearanceHovered.Options.UseFont = true;
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(3, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 64);
            this.btnUpdate.TabIndex = 126;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa Nhóm";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnDelete.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.AppearanceHovered.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(3, 452);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 64);
            this.btnDelete.TabIndex = 125;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa Nhóm";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnAdd.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.Options.UseFont = true;
            this.btnAdd.AppearanceHovered.Options.UseForeColor = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(3, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 64);
            this.btnAdd.TabIndex = 124;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm Nhóm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelTitleBar.Controls.Add(this.btnReLoad);
            this.panelTitleBar.Controls.Add(this.btnExitFormManageCourse);
            this.panelTitleBar.Controls.Add(this.btnExitFormDecentralization);
            this.panelTitleBar.Controls.Add(this.groupControl1);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(174, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(746, 87);
            this.panelTitleBar.TabIndex = 128;
            // 
            // btnReLoad
            // 
            this.btnReLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReLoad.FlatAppearance.BorderSize = 0;
            this.btnReLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReLoad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.ForeColor = System.Drawing.Color.White;
            this.btnReLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.Image")));
            this.btnReLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReLoad.Location = new System.Drawing.Point(0, 0);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(70, 87);
            this.btnReLoad.TabIndex = 12;
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnExitFormManageCourse
            // 
            this.btnExitFormManageCourse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitFormManageCourse.FlatAppearance.BorderSize = 0;
            this.btnExitFormManageCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormManageCourse.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormManageCourse.ForeColor = System.Drawing.Color.White;
            this.btnExitFormManageCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormManageCourse.Image")));
            this.btnExitFormManageCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitFormManageCourse.Location = new System.Drawing.Point(676, 0);
            this.btnExitFormManageCourse.Name = "btnExitFormManageCourse";
            this.btnExitFormManageCourse.Size = new System.Drawing.Size(70, 87);
            this.btnExitFormManageCourse.TabIndex = 11;
            this.btnExitFormManageCourse.UseVisualStyleBackColor = true;
            this.btnExitFormManageCourse.Click += new System.EventHandler(this.btnExitFormManageCourse_Click);
            // 
            // btnExitFormDecentralization
            // 
            this.btnExitFormDecentralization.FlatAppearance.BorderSize = 0;
            this.btnExitFormDecentralization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormDecentralization.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormDecentralization.ForeColor = System.Drawing.Color.White;
            this.btnExitFormDecentralization.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormDecentralization.Image")));
            this.btnExitFormDecentralization.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitFormDecentralization.Location = new System.Drawing.Point(940, 0);
            this.btnExitFormDecentralization.Name = "btnExitFormDecentralization";
            this.btnExitFormDecentralization.Size = new System.Drawing.Size(70, 87);
            this.btnExitFormDecentralization.TabIndex = 6;
            this.btnExitFormDecentralization.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton7);
            this.groupControl1.Controls.Add(this.checkedListBox1);
            this.groupControl1.Controls.Add(this.simpleButton5);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Location = new System.Drawing.Point(17, 93);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(881, 266);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Information";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(171, 216);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(98, 23);
            this.simpleButton7.TabIndex = 4;
            this.simpleButton7.Text = "Delete";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(442, 71);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(258, 180);
            this.checkedListBox1.TabIndex = 23;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(299, 210);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(98, 23);
            this.simpleButton5.TabIndex = 3;
            this.simpleButton5.Text = "Update";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = " The Subject";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(26, 210);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(130, 23);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Add";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(146, 123);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(194, 20);
            this.textEdit3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Year End";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(146, 82);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(193, 20);
            this.textEdit2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Year Start";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(146, 43);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(194, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Course ID";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(287, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý nhóm môn học";
            // 
            // frmAddGroupForSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 552);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.gcListGroup);
            this.Controls.Add(this.grpInformationGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddGroupForSubject";
            this.Text = "frmAddGroupForSubject";
            this.Load += new System.EventHandler(this.frmAddGroupForSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationGroup)).EndInit();
            this.grpInformationGroup.ResumeLayout(false);
            this.grpInformationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeLecturer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Subject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Lecturer)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpInformationGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraEditors.LookUpEdit lkeSubject;
        private DevExpress.XtraEditors.LookUpEdit lkeLecturer;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gcListGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListCourse;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupID;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnExitFormManageCourse;
        private System.Windows.Forms.Button btnExitFormDecentralization;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colLecturer;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Subject;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Lecturer;
    }
}