namespace ManageProjectStudent_View
{
    partial class frmAddStudentSubject
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gcPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvChooseStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Frm = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Them = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit_Sua = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit_Xoa = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit_Xem = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit_Full = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChooseStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Frm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Full)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.comboBox1);
            this.groupControl1.Location = new System.Drawing.Point(124, 82);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(256, 345);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chọn môn để thêm";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnLuu.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuu.AppearanceHovered.Options.UseFont = true;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLuu.Location = new System.Drawing.Point(67, 84);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 28);
            this.btnLuu.TabIndex = 94;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Thêm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // gcPhanQuyen
            // 
            this.gcPhanQuyen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            gridLevelNode1.RelationName = "Level1";
            this.gcPhanQuyen.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcPhanQuyen.Location = new System.Drawing.Point(387, 82);
            this.gcPhanQuyen.MainView = this.gvChooseStudent;
            this.gcPhanQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.gcPhanQuyen.Name = "gcPhanQuyen";
            this.gcPhanQuyen.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit_Them,
            this.repositoryItemCheckEdit_Sua,
            this.repositoryItemCheckEdit_Xoa,
            this.repositoryItemCheckEdit_Xem,
            this.repositoryItemLookUpEdit_Frm,
            this.repositoryItemCheckEdit_Full});
            this.gcPhanQuyen.Size = new System.Drawing.Size(512, 345);
            this.gcPhanQuyen.TabIndex = 17;
            this.gcPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChooseStudent});
            // 
            // gvChooseStudent
            // 
            this.gvChooseStudent.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvChooseStudent.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvChooseStudent.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvChooseStudent.Appearance.EvenRow.Options.UseFont = true;
            this.gvChooseStudent.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvChooseStudent.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvChooseStudent.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvChooseStudent.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvChooseStudent.Appearance.OddRow.Options.UseBackColor = true;
            this.gvChooseStudent.Appearance.OddRow.Options.UseFont = true;
            this.gvChooseStudent.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvChooseStudent.Appearance.Row.Options.UseFont = true;
            this.gvChooseStudent.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvChooseStudent.Appearance.TopNewRow.Options.UseFont = true;
            this.gvChooseStudent.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvChooseStudent.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvChooseStudent.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvChooseStudent.Appearance.ViewCaption.Options.UseFont = true;
            this.gvChooseStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChucNang,
            this.gridColumn1,
            this.colThem});
            this.gvChooseStudent.GridControl = this.gcPhanQuyen;
            this.gvChooseStudent.Name = "gvChooseStudent";
            this.gvChooseStudent.NewItemRowText = "Thêm Mới";
            this.gvChooseStudent.OptionsSelection.MultiSelect = true;
            this.gvChooseStudent.OptionsView.EnableAppearanceEvenRow = true;
            this.gvChooseStudent.OptionsView.EnableAppearanceOddRow = true;
            this.gvChooseStudent.OptionsView.ShowGroupPanel = false;
            this.gvChooseStudent.OptionsView.ShowViewCaption = true;
            this.gvChooseStudent.ViewCaption = "Chọn sinh viên";
            // 
            // colChucNang
            // 
            this.colChucNang.AppearanceCell.Options.UseTextOptions = true;
            this.colChucNang.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colChucNang.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colChucNang.Caption = "MSSV";
            this.colChucNang.ColumnEdit = this.repositoryItemLookUpEdit_Frm;
            this.colChucNang.FieldName = "strMaFrm";
            this.colChucNang.Name = "colChucNang";
            this.colChucNang.OptionsColumn.AllowEdit = false;
            this.colChucNang.Visible = true;
            this.colChucNang.VisibleIndex = 0;
            this.colChucNang.Width = 227;
            // 
            // repositoryItemLookUpEdit_Frm
            // 
            this.repositoryItemLookUpEdit_Frm.AutoHeight = false;
            this.repositoryItemLookUpEdit_Frm.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Frm.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colMaFrm", "Mã Form"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenFrm", "Chức Năng")});
            this.repositoryItemLookUpEdit_Frm.DisplayMember = "strTenFrm";
            this.repositoryItemLookUpEdit_Frm.Name = "repositoryItemLookUpEdit_Frm";
            this.repositoryItemLookUpEdit_Frm.NullText = "Chức Năng";
            this.repositoryItemLookUpEdit_Frm.ValueMember = "strMaFrm";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên sinh viên";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // colThem
            // 
            this.colThem.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.colThem.AppearanceCell.Options.UseBackColor = true;
            this.colThem.AppearanceHeader.BackColor = System.Drawing.Color.Transparent;
            this.colThem.AppearanceHeader.Options.UseBackColor = true;
            this.colThem.Caption = "Thêm";
            this.colThem.ColumnEdit = this.repositoryItemCheckEdit_Them;
            this.colThem.FieldName = "bThem";
            this.colThem.Name = "colThem";
            this.colThem.Visible = true;
            this.colThem.VisibleIndex = 2;
            this.colThem.Width = 131;
            // 
            // repositoryItemCheckEdit_Them
            // 
            this.repositoryItemCheckEdit_Them.AutoHeight = false;
            this.repositoryItemCheckEdit_Them.Name = "repositoryItemCheckEdit_Them";
            this.repositoryItemCheckEdit_Them.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // repositoryItemCheckEdit_Sua
            // 
            this.repositoryItemCheckEdit_Sua.AutoHeight = false;
            this.repositoryItemCheckEdit_Sua.Name = "repositoryItemCheckEdit_Sua";
            this.repositoryItemCheckEdit_Sua.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // repositoryItemCheckEdit_Xoa
            // 
            this.repositoryItemCheckEdit_Xoa.AutoHeight = false;
            this.repositoryItemCheckEdit_Xoa.Name = "repositoryItemCheckEdit_Xoa";
            this.repositoryItemCheckEdit_Xoa.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // repositoryItemCheckEdit_Xem
            // 
            this.repositoryItemCheckEdit_Xem.AutoHeight = false;
            this.repositoryItemCheckEdit_Xem.Name = "repositoryItemCheckEdit_Xem";
            this.repositoryItemCheckEdit_Xem.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // repositoryItemCheckEdit_Full
            // 
            this.repositoryItemCheckEdit_Full.AutoHeight = false;
            this.repositoryItemCheckEdit_Full.Name = "repositoryItemCheckEdit_Full";
            // 
            // frmAddStudentSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 552);
            this.Controls.Add(this.gcPhanQuyen);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddStudentSubject";
            this.Text = "frmAddStudentSubject";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChooseStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Frm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Full)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.GridControl gcPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChooseStudent;
        private DevExpress.XtraGrid.Columns.GridColumn colChucNang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Frm;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colThem;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Them;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Sua;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Xoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Xem;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Full;
    }
}