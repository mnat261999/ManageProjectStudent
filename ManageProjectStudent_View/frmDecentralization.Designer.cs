namespace ManageProjectStudent_View
{
    partial class frmDecentralization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDecentralization));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.LookUpEdit_Lecturer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Function = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFunction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvListFunction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcListFunction = new DevExpress.XtraGrid.GridControl();
            this.LookUpEdit_Subject = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lkeStaffType = new DevExpress.XtraEditors.LookUpEdit();
            this.grpNguoiSungDung = new DevExpress.XtraEditors.GroupControl();
            this.btnExitFormManageLecturer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.chkFull_Add = new DevExpress.XtraEditors.CheckEdit();
            this.chkFull_Delete = new DevExpress.XtraEditors.CheckEdit();
            this.chkFull_Edit = new DevExpress.XtraEditors.CheckEdit();
            this.chkFull_View = new DevExpress.XtraEditors.CheckEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Lecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Function)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Subject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeStaffType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNguoiSungDung)).BeginInit();
            this.grpNguoiSungDung.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Add.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Delete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_View.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
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
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(572, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 43);
            this.btnSave.TabIndex = 126;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            this.repositoryItemCheckEdit4.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colView
            // 
            this.colView.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colView.AppearanceCell.Options.UseFont = true;
            this.colView.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colView.AppearanceHeader.Options.UseFont = true;
            this.colView.Caption = "Xem";
            this.colView.ColumnEdit = this.repositoryItemCheckEdit4;
            this.colView.FieldName = "BView";
            this.colView.Name = "colView";
            this.colView.Visible = true;
            this.colView.VisibleIndex = 4;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            this.repositoryItemCheckEdit3.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colEdit
            // 
            this.colEdit.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEdit.AppearanceCell.Options.UseFont = true;
            this.colEdit.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEdit.AppearanceHeader.Options.UseFont = true;
            this.colEdit.Caption = "Sửa";
            this.colEdit.ColumnEdit = this.repositoryItemCheckEdit3;
            this.colEdit.FieldName = "BEdit";
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colDelete
            // 
            this.colDelete.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDelete.AppearanceCell.Options.UseFont = true;
            this.colDelete.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDelete.AppearanceHeader.Options.UseFont = true;
            this.colDelete.Caption = "Xóa";
            this.colDelete.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colDelete.FieldName = "BDelete";
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 2;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colAdd
            // 
            this.colAdd.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAdd.AppearanceCell.Options.UseFont = true;
            this.colAdd.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAdd.AppearanceHeader.Options.UseFont = true;
            this.colAdd.Caption = "Thêm";
            this.colAdd.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colAdd.FieldName = "BAdd";
            this.colAdd.Name = "colAdd";
            this.colAdd.Visible = true;
            this.colAdd.VisibleIndex = 1;
            // 
            // LookUpEdit_Function
            // 
            this.LookUpEdit_Function.AutoHeight = false;
            this.LookUpEdit_Function.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Function.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFormName", "Chức năng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFormID", "Mã Form", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LookUpEdit_Function.DisplayMember = "StrFormName";
            this.LookUpEdit_Function.Name = "LookUpEdit_Function";
            this.LookUpEdit_Function.NullText = "Chức năng";
            this.LookUpEdit_Function.ValueMember = "StrFormID";
            // 
            // colFunction
            // 
            this.colFunction.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFunction.AppearanceCell.Options.UseFont = true;
            this.colFunction.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFunction.AppearanceHeader.Options.UseFont = true;
            this.colFunction.Caption = "Chức năng";
            this.colFunction.ColumnEdit = this.LookUpEdit_Function;
            this.colFunction.FieldName = "StrFormID";
            this.colFunction.Name = "colFunction";
            this.colFunction.Visible = true;
            this.colFunction.VisibleIndex = 0;
            this.colFunction.Width = 83;
            // 
            // gvListFunction
            // 
            this.gvListFunction.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListFunction.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvListFunction.Appearance.EvenRow.Options.UseFont = true;
            this.gvListFunction.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListFunction.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvListFunction.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListFunction.Appearance.OddRow.Options.UseBackColor = true;
            this.gvListFunction.Appearance.OddRow.Options.UseFont = true;
            this.gvListFunction.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListFunction.Appearance.Row.Options.UseFont = true;
            this.gvListFunction.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListFunction.Appearance.SelectedRow.Options.UseFont = true;
            this.gvListFunction.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListFunction.Appearance.ViewCaption.Options.UseFont = true;
            this.gvListFunction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFunction,
            this.colAdd,
            this.colDelete,
            this.colEdit,
            this.colView});
            this.gvListFunction.GridControl = this.gcListFunction;
            this.gvListFunction.Name = "gvListFunction";
            this.gvListFunction.OptionsFind.AllowFindPanel = false;
            this.gvListFunction.OptionsSelection.MultiSelect = true;
            this.gvListFunction.OptionsView.EnableAppearanceEvenRow = true;
            this.gvListFunction.OptionsView.EnableAppearanceOddRow = true;
            this.gvListFunction.OptionsView.ShowGroupPanel = false;
            this.gvListFunction.OptionsView.ShowViewCaption = true;
            this.gvListFunction.ViewCaption = "Danh sách chức năng";
            // 
            // gcListFunction
            // 
            this.gcListFunction.Location = new System.Drawing.Point(464, 124);
            this.gcListFunction.MainView = this.gvListFunction;
            this.gcListFunction.Name = "gcListFunction";
            this.gcListFunction.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Lecturer,
            this.LookUpEdit_Subject,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4,
            this.LookUpEdit_Function});
            this.gcListFunction.Size = new System.Drawing.Size(701, 306);
            this.gcListFunction.TabIndex = 125;
            this.gcListFunction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListFunction});
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
            // lkeStaffType
            // 
            this.lkeStaffType.Location = new System.Drawing.Point(5, 26);
            this.lkeStaffType.Name = "lkeStaffType";
            this.lkeStaffType.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeStaffType.Properties.Appearance.Options.UseFont = true;
            this.lkeStaffType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeStaffType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colStaffTypeName", "Loại nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colStaffTypeID", "Mã loại nhân viên", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkeStaffType.Properties.NullText = "Loại nhân viên";
            this.lkeStaffType.Size = new System.Drawing.Size(251, 24);
            this.lkeStaffType.TabIndex = 0;
            this.lkeStaffType.EditValueChanged += new System.EventHandler(this.lkeStaffType_EditValueChanged);
            // 
            // grpNguoiSungDung
            // 
            this.grpNguoiSungDung.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpNguoiSungDung.Appearance.Options.UseFont = true;
            this.grpNguoiSungDung.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpNguoiSungDung.AppearanceCaption.Options.UseFont = true;
            this.grpNguoiSungDung.Controls.Add(this.lkeStaffType);
            this.grpNguoiSungDung.Location = new System.Drawing.Point(196, 124);
            this.grpNguoiSungDung.Margin = new System.Windows.Forms.Padding(4);
            this.grpNguoiSungDung.Name = "grpNguoiSungDung";
            this.grpNguoiSungDung.Size = new System.Drawing.Size(261, 306);
            this.grpNguoiSungDung.TabIndex = 124;
            this.grpNguoiSungDung.Text = "Người Sử Dụng";
            // 
            // btnExitFormManageLecturer
            // 
            this.btnExitFormManageLecturer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitFormManageLecturer.FlatAppearance.BorderSize = 0;
            this.btnExitFormManageLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormManageLecturer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormManageLecturer.ForeColor = System.Drawing.Color.White;
            this.btnExitFormManageLecturer.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormManageLecturer.Image")));
            this.btnExitFormManageLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitFormManageLecturer.Location = new System.Drawing.Point(941, 0);
            this.btnExitFormManageLecturer.Name = "btnExitFormManageLecturer";
            this.btnExitFormManageLecturer.Size = new System.Drawing.Size(70, 87);
            this.btnExitFormManageLecturer.TabIndex = 7;
            this.btnExitFormManageLecturer.UseVisualStyleBackColor = true;
            this.btnExitFormManageLecturer.Click += new System.EventHandler(this.btnExitFormManageLecturer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(419, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Phân Quyền";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelTitleBar.Controls.Add(this.btnExitFormManageLecturer);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(174, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1011, 87);
            this.panelTitleBar.TabIndex = 123;
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
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 549);
            this.panelMenu.TabIndex = 122;
            // 
            // chkFull_Add
            // 
            this.chkFull_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFull_Add.Location = new System.Drawing.Point(732, 154);
            this.chkFull_Add.Name = "chkFull_Add";
            this.chkFull_Add.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkFull_Add.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkFull_Add.Properties.Appearance.Options.UseBackColor = true;
            this.chkFull_Add.Properties.Appearance.Options.UseFont = true;
            this.chkFull_Add.Properties.Caption = "";
            this.chkFull_Add.Size = new System.Drawing.Size(21, 20);
            this.chkFull_Add.TabIndex = 127;
            this.chkFull_Add.Visible = false;
            // 
            // chkFull_Delete
            // 
            this.chkFull_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFull_Delete.Location = new System.Drawing.Point(862, 154);
            this.chkFull_Delete.Name = "chkFull_Delete";
            this.chkFull_Delete.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkFull_Delete.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkFull_Delete.Properties.Appearance.Options.UseBackColor = true;
            this.chkFull_Delete.Properties.Appearance.Options.UseFont = true;
            this.chkFull_Delete.Properties.Caption = "";
            this.chkFull_Delete.Size = new System.Drawing.Size(24, 20);
            this.chkFull_Delete.TabIndex = 128;
            this.chkFull_Delete.Visible = false;
            // 
            // chkFull_Edit
            // 
            this.chkFull_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFull_Edit.Location = new System.Drawing.Point(997, 154);
            this.chkFull_Edit.Name = "chkFull_Edit";
            this.chkFull_Edit.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkFull_Edit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkFull_Edit.Properties.Appearance.Options.UseBackColor = true;
            this.chkFull_Edit.Properties.Appearance.Options.UseFont = true;
            this.chkFull_Edit.Properties.Caption = "";
            this.chkFull_Edit.Size = new System.Drawing.Size(24, 20);
            this.chkFull_Edit.TabIndex = 129;
            this.chkFull_Edit.Visible = false;
            // 
            // chkFull_View
            // 
            this.chkFull_View.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFull_View.Location = new System.Drawing.Point(1132, 154);
            this.chkFull_View.Name = "chkFull_View";
            this.chkFull_View.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkFull_View.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkFull_View.Properties.Appearance.Options.UseBackColor = true;
            this.chkFull_View.Properties.Appearance.Options.UseFont = true;
            this.chkFull_View.Properties.Caption = "";
            this.chkFull_View.Size = new System.Drawing.Size(24, 20);
            this.chkFull_View.TabIndex = 130;
            this.chkFull_View.Visible = false;
            // 
            // frmDecentralization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 549);
            this.Controls.Add(this.chkFull_View);
            this.Controls.Add(this.chkFull_Edit);
            this.Controls.Add(this.chkFull_Delete);
            this.Controls.Add(this.chkFull_Add);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gcListFunction);
            this.Controls.Add(this.grpNguoiSungDung);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDecentralization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDecentralization";
            this.Load += new System.EventHandler(this.frmDecentralization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Lecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Function)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Subject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeStaffType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNguoiSungDung)).EndInit();
            this.grpNguoiSungDung.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Add.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Delete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_View.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Lecturer;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn colView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Function;
        private DevExpress.XtraGrid.Columns.GridColumn colFunction;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListFunction;
        private DevExpress.XtraGrid.GridControl gcListFunction;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Subject;
        private DevExpress.XtraEditors.LookUpEdit lkeStaffType;
        private DevExpress.XtraEditors.GroupControl grpNguoiSungDung;
        private System.Windows.Forms.Button btnExitFormManageLecturer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private DevExpress.XtraEditors.CheckEdit chkFull_Add;
        private DevExpress.XtraEditors.CheckEdit chkFull_Delete;
        private DevExpress.XtraEditors.CheckEdit chkFull_Edit;
        private DevExpress.XtraEditors.CheckEdit chkFull_View;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}