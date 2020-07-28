using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Export;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraPrinting;
using ManageProjectStudent_Interface;
using ManageProjectStudent_Model;
using ManageProjectStudent_ViewModel;
using Unity;

namespace ManageProjectStudent_View
{
    public partial class frmManageProject : Form
    {
        public frmManageProject()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private IProject _Project = Config.Container.Resolve<IProject>();
        private ISubject _Subject = Config.Container.Resolve<ISubject>();
        private IStaff _Staff = Config.Container.Resolve<IStaff>();

        private int _IStatusForm = 0;
        private ProjectModel _ProjectModelNow = null;
        private BindingList<ProjectModel> _lstProject = new BindingList<ProjectModel>();
        private BindingList<SubjectModel> _lstSubject = new BindingList<SubjectModel>();
        private BindingList<StaffModel> _lstLecturer = new BindingList<StaffModel>();

        private StaffModel StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel Decentralize = null;
        #endregion
        #region Method
        private void _setStatusForm()
        {
            //txtID.ReadOnly = true;
            switch (_IStatusForm)
            {
                case 0:
                    grpInformationProject.Enabled = false;
                    if (_ProjectModelNow != null)
                    {
                        if (Decentralize.BView == true)
                        {
                            if (Decentralize.BAdd == true)
                            {
                                btnAdd.Enabled = true;
                            }
                            else
                            {
                                btnAdd.Enabled = false;
                            }
                            if (Decentralize.BDelete == true)
                            {
                                btnDelete.Enabled = true;
                            }
                            else
                            {
                                btnDelete.Enabled = false;
                            }
                            if (Decentralize.BEdit == true)
                            {
                                btnUpdate.Enabled = true;
                            }
                            else
                            {
                                btnUpdate.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    break;
                case 1:
                    txtID.Text = string.Empty;
                    txtProjectName.Text = string.Empty;
                    lkeSubject.EditValue = null;
                    lkeLecturer.EditValue = null;
                    dteStartDay.EditValue = null;
                    dteEndDay.EditValue = null;

                    grpInformationProject.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2:
                    grpInformationProject.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if (_ProjectModelNow == null)
            {
                txtID.Text = string.Empty;
                txtProjectName.Text = string.Empty;
                lkeSubject.EditValue = null;
                lkeLecturer.EditValue = null;
                dteStartDay.EditValue = null;
                dteEndDay.EditValue = null;
            }
            else
            {
                txtID.Text = _ProjectModelNow.StrProjectID;
                txtProjectName.Text = _ProjectModelNow.StrProjectName;
                lkeSubject.EditValue = _ProjectModelNow.StrSubjectID;
                lkeLecturer.EditValue = _ProjectModelNow.StrStaffID;
                dteStartDay.EditValue = _ProjectModelNow.DtStartDay.Date;
                dteEndDay.EditValue = _ProjectModelNow.DtStartDay.Date;
            }
        }

        private void _getData()
        {
            if (_ProjectModelNow == null)
            {
                _ProjectModelNow = new ProjectModel();
            }
            _ProjectModelNow.StrProjectID = txtID.Text;
            _ProjectModelNow.StrProjectName = txtProjectName.Text;
            _ProjectModelNow.StrSubjectID = lkeSubject.GetColumnValue("StrSubjectID").ToString();
            _ProjectModelNow.StrStaffID = lkeLecturer.GetColumnValue("StrStaffID").ToString();
            _ProjectModelNow.DtStartDay = (DateTime)dteStartDay.EditValue;
            _ProjectModelNow.DtEndDay = (DateTime)dteEndDay.EditValue;

        }

        private void _lstLoadListProject()
        {
            _lstProject = _Project.loadProject();
            gcListProject.DataSource = _lstProject;
        }
        #endregion
        #region Event
        private void frmManageProject_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            StaffModel = frmHome.staffModel;
            if (frmHome.lstDecent != null)
            {
                foreach (DecentralizeModel decen in frmHome.lstDecent)
                {
                    if (StaffModel.StrStaffTypeID == decen.StrStaffTypeID && this.Name == decen.StrFormID)
                    {
                        Decentralize = _Decen.getDecentralizeStaffIdForm(decen.StrStaffTypeID, decen.StrFormID);
                    }
                }
            }

            dteStartDay.EditValue = DateTime.Now.Date;
            dteEndDay.EditValue = DateTime.Now.Date;

            _lstSubject = _Subject.loadSubject();
            lkeSubject.Properties.ValueMember = "StrSubjectID";
            lkeSubject.Properties.DisplayMember = "StrSubjectName";
            lkeSubject.Properties.DataSource = _lstSubject;
            lkeSubject.Properties.Columns["colSubjectID"].FieldName = "StrSubjectID";
            lkeSubject.Properties.Columns["colSubjectName"].FieldName = "StrSubjectName";

            _lstLecturer = _Staff.loadStaff();
            lkeLecturer.Properties.ValueMember = "StrStaffID";
            lkeLecturer.Properties.DisplayMember = "StrStaffName";
            lkeLecturer.Properties.DataSource = _lstLecturer;
            lkeLecturer.Properties.Columns["colLecturerID"].FieldName = "StrStaffID";
            lkeLecturer.Properties.Columns["colLecturerName"].FieldName = "StrStaffName";


            ///*GridView*/
            _lstProject = _Project.loadProject();

            LookUpEdit_Subject.DataSource = _lstSubject;
            LookUpEdit_Subject.Columns["colSubjectID"].FieldName = "StrSubjectID";
            LookUpEdit_Subject.Columns["colSubjectName"].FieldName = "StrSubjectName";

            LookUpEdit_Lecturer.DataSource = _lstLecturer;
            LookUpEdit_Lecturer.Columns["colLecturerID"].FieldName = "StrStaffID";
            LookUpEdit_Lecturer.Columns["colLecturerName"].FieldName = "StrStaffName";

            gcListProject.DataSource = _lstProject;
            _setStatusForm();
        }

        private void gvListProject_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvListProject.SelectedRowsCount > 0)
                _ProjectModelNow = (ProjectModel)gvListProject.GetRow(gvListProject.FocusedRowHandle);
            else
                _ProjectModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            _ProjectModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            txtProjectName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtProjectName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (_ProjectModelNow != null)
            {
                if (_Project.deleteCurrentProject(_ProjectModelNow))
                {
                    _lstLoadListProject();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstProject.Count == 0)
                    {
                        _ProjectModelNow = null;
                        _IStatusForm = 0;
                        _setStatusForm();
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProjectName.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập tên Project";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeSubject.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Môn học";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeLecturer.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Giảng viên";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteStartDay.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Ngày bắt đầu";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteEndDay.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Ngày kết thúc";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _Project.addNewProject(_ProjectModelNow);
                }
                else
                {
                    bresult = _Project.updateCurrentProject(_ProjectModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListProject();
                    _IStatusForm = 0;
                    _setStatusForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {

            _IStatusForm = 0;
            _setStatusForm();
            _lstProject = _Project.loadProject();
            gcListProject.DataSource = _lstProject;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Hide();
            frmManageProjectMain frmManageProjectMain = new frmManageProjectMain();
            frmManageProjectMain.ShowDialog();
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvListProject.RowCount > 0)
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = "";
                    dialog.Filter = @"Micrsoft Excel|*.xlsx";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gvListProject.ColumnPanelRowHeight = 40;
                        gvListProject.OptionsPrint.AutoWidth = AutoSize;
                        gvListProject.OptionsPrint.ShowPrintExportProgress = true;
                        gvListProject.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = "Sheet1";

                        ExportSettings.DefaultExportType = ExportType.Default;
                        gvListProject.ExportToXlsx(dialog.FileName, options);
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error" + ex, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Project._checkCharacterNumberProject(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Không được nhập ký tự số, chỉ được nhập chữ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvListProject_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    string sText = (e.RowHandle + 1).ToString();
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString(sText, e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = sText;
                }
                if (!indicatorIcon)
                    e.Info.ImageIndex = -1;

                if (e.RowHandle == GridControl.InvalidRowHandle)
                {
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString("STT", e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = "STT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gvListProject_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }
        #endregion
    }
}
