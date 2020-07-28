namespace ManageProjectStudent_View
{
    partial class frmManageMultiLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageMultiLanguage));
            this.grpInformationLan = new DevExpress.XtraEditors.GroupControl();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radUnavailable = new System.Windows.Forms.RadioButton();
            this.radAvailable = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radNoneDefault = new System.Windows.Forms.RadioButton();
            this.radDefault = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gcListStudent = new DevExpress.XtraGrid.GridControl();
            this.gvStudentList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLanguageID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLanguageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDefault = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Class = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnExitFormManageLecturer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationLan)).BeginInit();
            this.grpInformationLan.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformationLan
            // 
            this.grpInformationLan.Controls.Add(this.txtName);
            this.grpInformationLan.Controls.Add(this.btnSave);
            this.grpInformationLan.Controls.Add(this.panel2);
            this.grpInformationLan.Controls.Add(this.label4);
            this.grpInformationLan.Controls.Add(this.panel1);
            this.grpInformationLan.Controls.Add(this.label1);
            this.grpInformationLan.Controls.Add(this.txtID);
            this.grpInformationLan.Controls.Add(this.label3);
            this.grpInformationLan.Controls.Add(this.label2);
            this.grpInformationLan.Location = new System.Drawing.Point(223, 109);
            this.grpInformationLan.Name = "grpInformationLan";
            this.grpInformationLan.Size = new System.Drawing.Size(676, 178);
            this.grpInformationLan.TabIndex = 5;
            this.grpInformationLan.Text = "Thông Tin";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 21);
            this.txtName.TabIndex = 122;
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
            this.btnSave.Location = new System.Drawing.Point(278, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.TabIndex = 121;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radUnavailable);
            this.panel2.Controls.Add(this.radAvailable);
            this.panel2.Location = new System.Drawing.Point(474, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 31);
            this.panel2.TabIndex = 104;
            // 
            // radUnavailable
            // 
            this.radUnavailable.AutoSize = true;
            this.radUnavailable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUnavailable.Location = new System.Drawing.Point(84, 10);
            this.radUnavailable.Name = "radUnavailable";
            this.radUnavailable.Size = new System.Drawing.Size(68, 21);
            this.radUnavailable.TabIndex = 1;
            this.radUnavailable.TabStop = true;
            this.radUnavailable.Text = "Không";
            this.radUnavailable.UseVisualStyleBackColor = true;
            // 
            // radAvailable
            // 
            this.radAvailable.AutoSize = true;
            this.radAvailable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAvailable.Location = new System.Drawing.Point(3, 10);
            this.radAvailable.Name = "radAvailable";
            this.radAvailable.Size = new System.Drawing.Size(82, 21);
            this.radAvailable.TabIndex = 0;
            this.radAvailable.TabStop = true;
            this.radAvailable.Text = "Sử dụng";
            this.radAvailable.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 103;
            this.label4.Text = "Trạng thái";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radNoneDefault);
            this.panel1.Controls.Add(this.radDefault);
            this.panel1.Location = new System.Drawing.Point(474, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 31);
            this.panel1.TabIndex = 102;
            // 
            // radNoneDefault
            // 
            this.radNoneDefault.AutoSize = true;
            this.radNoneDefault.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNoneDefault.Location = new System.Drawing.Point(84, 6);
            this.radNoneDefault.Name = "radNoneDefault";
            this.radNoneDefault.Size = new System.Drawing.Size(68, 21);
            this.radNoneDefault.TabIndex = 1;
            this.radNoneDefault.TabStop = true;
            this.radNoneDefault.Text = "Không";
            this.radNoneDefault.UseVisualStyleBackColor = true;
            // 
            // radDefault
            // 
            this.radDefault.AutoSize = true;
            this.radDefault.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDefault.Location = new System.Drawing.Point(3, 6);
            this.radDefault.Name = "radDefault";
            this.radDefault.Size = new System.Drawing.Size(45, 21);
            this.radDefault.TabIndex = 0;
            this.radDefault.TabStop = true;
            this.radDefault.Text = "Có";
            this.radDefault.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 101;
            this.label1.Text = "Mặc định";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(174, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(174, 21);
            this.txtID.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Ngôn Ngữ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Ngôn Ngữ";
            // 
            // gcListStudent
            // 
            this.gcListStudent.Location = new System.Drawing.Point(223, 293);
            this.gcListStudent.MainView = this.gvStudentList;
            this.gcListStudent.Name = "gcListStudent";
            this.gcListStudent.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Class});
            this.gcListStudent.Size = new System.Drawing.Size(676, 240);
            this.gcListStudent.TabIndex = 45;
            this.gcListStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudentList});
            // 
            // gvStudentList
            // 
            this.gvStudentList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvStudentList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvStudentList.Appearance.EvenRow.Options.UseFont = true;
            this.gvStudentList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvStudentList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvStudentList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvStudentList.Appearance.OddRow.Options.UseFont = true;
            this.gvStudentList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.Row.Options.UseFont = true;
            this.gvStudentList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvStudentList.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.AppearancePrint.Row.Options.UseFont = true;
            this.gvStudentList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLanguageID,
            this.colLanguageName,
            this.colDefault,
            this.colStatus});
            this.gvStudentList.DetailHeight = 377;
            this.gvStudentList.GridControl = this.gcListStudent;
            this.gvStudentList.Name = "gvStudentList";
            this.gvStudentList.OptionsBehavior.Editable = false;
            this.gvStudentList.OptionsSelection.MultiSelect = true;
            this.gvStudentList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvStudentList.OptionsView.EnableAppearanceOddRow = true;
            this.gvStudentList.OptionsView.ShowAutoFilterRow = true;
            this.gvStudentList.OptionsView.ShowGroupPanel = false;
            this.gvStudentList.OptionsView.ShowViewCaption = true;
            this.gvStudentList.ViewCaption = "Danh sách ngôn ngữ";
            // 
            // colLanguageID
            // 
            this.colLanguageID.Caption = "Mã ngôn ngữ";
            this.colLanguageID.FieldName = "StrLanguageID";
            this.colLanguageID.Name = "colLanguageID";
            this.colLanguageID.Visible = true;
            this.colLanguageID.VisibleIndex = 0;
            // 
            // colLanguageName
            // 
            this.colLanguageName.Caption = "Tên ngôn ngữ";
            this.colLanguageName.FieldName = "StrLanguageName";
            this.colLanguageName.Name = "colLanguageName";
            this.colLanguageName.Visible = true;
            this.colLanguageName.VisibleIndex = 1;
            // 
            // colDefault
            // 
            this.colDefault.Caption = "Mặc định";
            this.colDefault.FieldName = "BDefault";
            this.colDefault.Name = "colDefault";
            this.colDefault.Visible = true;
            this.colDefault.VisibleIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Trạng thái";
            this.colStatus.FieldName = "BStatus";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // LookUpEdit_Class
            // 
            this.LookUpEdit_Class.AutoHeight = false;
            this.LookUpEdit_Class.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Class.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colClassName", "Tên lớp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colClassID", "Mã Lớp", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LookUpEdit_Class.DisplayMember = "StrClassName";
            this.LookUpEdit_Class.Name = "LookUpEdit_Class";
            this.LookUpEdit_Class.ValueMember = "StrClassID";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnUpdate);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 552);
            this.panelMenu.TabIndex = 46;
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
            this.btnUpdate.Location = new System.Drawing.Point(0, 384);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 54);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa Ngôn Ngữ";
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
            this.btnDelete.Location = new System.Drawing.Point(0, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 54);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa Ngôn Ngữ";
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
            this.btnAdd.Location = new System.Drawing.Point(0, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 54);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm Ngôn Ngữ";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelTitleBar.Controls.Add(this.btnReLoad);
            this.panelTitleBar.Controls.Add(this.btnExitFormManageLecturer);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(174, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(764, 87);
            this.panelTitleBar.TabIndex = 47;
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
            this.btnReLoad.TabIndex = 7;
            this.btnReLoad.UseVisualStyleBackColor = true;
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
            this.btnExitFormManageLecturer.Location = new System.Drawing.Point(694, 0);
            this.btnExitFormManageLecturer.Name = "btnExitFormManageLecturer";
            this.btnExitFormManageLecturer.Size = new System.Drawing.Size(70, 87);
            this.btnExitFormManageLecturer.TabIndex = 6;
            this.btnExitFormManageLecturer.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(290, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý ngôn ngữ";
            // 
            // frmManageMultiLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 552);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.gcListStudent);
            this.Controls.Add(this.grpInformationLan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageMultiLanguage";
            this.Text = "frmManageMultiLanguage";
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationLan)).EndInit();
            this.grpInformationLan.ResumeLayout(false);
            this.grpInformationLan.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl grpInformationLan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radDefault;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcListStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudentList;
        private DevExpress.XtraGrid.Columns.GridColumn colLanguageID;
        private DevExpress.XtraGrid.Columns.GridColumn colLanguageName;
        private DevExpress.XtraGrid.Columns.GridColumn colDefault;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Class;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radUnavailable;
        private System.Windows.Forms.RadioButton radAvailable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radNoneDefault;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnExitFormManageLecturer;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.TextBox txtName;
    }
}