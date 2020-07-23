using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using ManageProjectStudent_Interface;
using Unity;
using ManageProjectStudent_Model;
using ManageProjectStudent_ViewModel;
using DevExpress.XtraEditors.Filtering.Templates;
using System.Security.AccessControl;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace ManageProjectStudent_View
{
    public partial class frmManageProjectTask : Form
    {
        public frmManageProjectTask()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private int _IStatusForm = 0;
        private ProjectTaskModel _TaskModelNow = null;
        private IProjectTask _Task = Config.Container.Resolve<IProjectTask>();
        private BindingList<ProjectTaskModel> _lstTask = new BindingList<ProjectTaskModel>();
        private IProject _Project = Config.Container.Resolve<IProject>();
        private BindingList<ProjectModel> _lstProject = new BindingList<ProjectModel>();

        private StaffModel StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel Decentralize = null;
        #endregion
        #region Mehthod
        private void _setStatusForm()
        {
            switch (_IStatusForm)
            {
                case 0:
                    grpInformationTask.Enabled = false;
                    if(_TaskModelNow != null)
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
                    lkeProjectID.EditValue = null;
                    txtTaskID.Text = "";
                    txtTaskName.Text = "";
                    dteStartDay.EditValue = null;
                    dteEndDay.EditValue = null;
                    txtFileName.Text = "";
                    txtLinkFile.Text = "";

                    grpInformationTask.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2 :
                    grpInformationTask.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if(_TaskModelNow == null)
            {
                lkeProjectID.EditValue = null;
                txtTaskID.Text = "";
                txtTaskName.Text = "";
                dteStartDay.EditValue = null;
                dteEndDay.EditValue = null;
                txtFileName.Text = "";
                txtLinkFile.Text = "";
            }
            else
            {
                lkeProjectID.EditValue = _TaskModelNow.StrProjectID;
                txtTaskID.Text = _TaskModelNow.StrTaskID;
                txtTaskName.Text = _TaskModelNow.StrTaskName;
                dteStartDay.EditValue = _TaskModelNow.DtStartDay.Date;
                dteEndDay.EditValue = _TaskModelNow.DtStartDay.Date;
                txtFileName.Text = _TaskModelNow.StrFileName;
                txtLinkFile.Text = _TaskModelNow.StrLinkFile;
            }
        }

        private void _getData()
        {
            if (_TaskModelNow == null)
            {
                _TaskModelNow = new ProjectTaskModel();
            }
            _TaskModelNow.StrProjectID = lkeProjectID.GetColumnValue("StrProjectID").ToString();
            _TaskModelNow.StrTaskID = txtTaskID.Text;
            _TaskModelNow.StrTaskName = txtTaskName.Text;
            _TaskModelNow.DtStartDay = (DateTime)dteStartDay.EditValue;
            _TaskModelNow.DtEndDay = (DateTime)dteEndDay.EditValue;
            _TaskModelNow.StrFileName = txtFileName.Text;
            _TaskModelNow.StrLinkFile = txtLinkFile.Text;
        }

        private void _lstLoadListTask()
        {
            //_lstTask = _Task.loadProjectTask();
            _lstTask = _Task.getListProjectTaskForStaff(frmHome.staffModel.StrStaffID);
            gcListTask.DataSource = _lstTask;
        }
        #endregion
        #region Event
        private void frmManageProjectTask_Load(object sender, EventArgs e)
        {
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

            _lstProject = _Project.loadProject();
            lkeProjectID.Properties.ValueMember = "StrProjectID";
            lkeProjectID.Properties.DisplayMember = "StrProjectID";
            lkeProjectID.Properties.DataSource = _lstProject;
            lkeProjectID.Properties.Columns["colProjectID"].FieldName = "StrProjectID";

            ///*GridView*/
            //_lstTask = _Task.loadProjectTask();
            _lstTask = _Task.getListProjectTaskForStaff(frmHome.staffModel.StrStaffID);

            LookUpEdit_Project.DataSource = _lstTask;
            LookUpEdit_Project.Columns["colProjectID"].FieldName = "StrProjectID";

            gcListTask.DataSource = _lstTask;
            _setStatusForm();
            
        }

        private void gvListTask_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            if (gvListTask.SelectedRowsCount > 0)
                _TaskModelNow = (ProjectTaskModel)gvListTask.GetRow(gvListTask.FocusedRowHandle);
            else
                _TaskModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _TaskModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            txtTaskID.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtTaskID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_TaskModelNow != null)
            {
                if (_Task.deleteCurrentProjectTask(_TaskModelNow))
                {
                    _lstLoadListTask();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstTask.Count == 0)
                    {
                        _TaskModelNow = null;
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
            if (lkeProjectID.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Mã đồ án", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTaskID.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Mã task", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTaskName.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Tên task", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteStartDay.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày bắt đầu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteEndDay.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _Task.addNewProjectTask(_TaskModelNow);
                }
                else
                {
                    bresult = _Task.addNewProjectTask(_TaskModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListTask();
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
            //_lstTask = _Task.loadProjectTask();
            _lstTask = _Task.getListProjectTaskForStaff(frmHome.staffModel.StrStaffID);
            gcListTask.DataSource = _lstTask;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageProjectStudentMain frm = new frmManageProjectStudentMain();
            frm.ShowDialog();
            this.Close();
        }

        private void gvListTask_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gvListTask_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvListTask.RowCount > 0)
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = "";
                    dialog.Filter = @"Micrsoft Excel|*.xlsx";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gvListTask.ColumnPanelRowHeight = 40;
                        gvListTask.OptionsPrint.AutoWidth = AutoSize;
                        gvListTask.OptionsPrint.ShowPrintExportProgress = true;
                        gvListTask.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = "Sheet1";

                        ExportSettings.DefaultExportType = ExportType.Default;
                        gvListTask.ExportToXlsx(dialog.FileName, options);
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error" + ex, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
