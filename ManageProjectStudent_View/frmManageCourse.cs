using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraRichEdit.Fields;
using ManageProjectStudent_Interface;
using ManageProjectStudent_Model;
using ManageProjectStudent_ViewModel;
using Unity;

namespace ManageProjectStudent_View
{
    public partial class frmManageCourse : Form
    {
        public frmManageCourse()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private ICourse _Course = Config.Container.Resolve<ICourse>();
        private int _IStatusForm = 0;
        private CourseModel _CourseModelNow = null;
        private BindingList<CourseModel> _lstCourse = new BindingList<CourseModel>();

        private StaffModel StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel Decentralize = null;
        #endregion
        #region Method
        private void _setStatusForm()
        {
            switch (_IStatusForm)
            {
                case 0:
                    grpCourse.Enabled = false;
                    if(_CourseModelNow != null)
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
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }    
                    break;
                case 1:
                    txtID.Text = "";
                    dteStartYear.EditValue = null;
                    dteEndYear.EditValue = null;

                    grpCourse.Enabled = true;

                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    break;
                case 2:
                    grpCourse.Enabled = true;
                    break;
            }    
        }

        private void _loadData()
        {
            if (_CourseModelNow == null)
            {
                txtID.Text = string.Empty;
                dteStartYear.EditValue = null;
                dteEndYear.EditValue = null;
            }
            else
            {
                txtID.Text = _CourseModelNow.StrCourseID;
                dteStartYear.EditValue = _CourseModelNow.DtStartYear.Date;
                dteEndYear.EditValue = _CourseModelNow.DtEndYear.Date;
            }    
        }

        private void _getData()
        {
            if(_CourseModelNow == null)
            {
                _CourseModelNow = new CourseModel();
            }
            _CourseModelNow.StrCourseID = txtID.Text;
            _CourseModelNow.DtStartYear = (DateTime)dteStartYear.EditValue;
            _CourseModelNow.DtEndYear = (DateTime)dteEndYear.EditValue;
        }

        private void _lstLoadListCourse()
        {
            _lstCourse = _Course.loadCourse();
            gcListCourse.DataSource = _lstCourse;
        }
        #endregion

        #region Event
        //load
        private void frmManageCourse_Load(object sender, EventArgs e)
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

            dteStartYear.EditValue = DateTime.Now.Date;
            dteEndYear.EditValue = DateTime.Now.Date;

            ///*GridView*/
            _lstCourse = _Course.loadCourse();
            gcListCourse.DataSource = _lstCourse;
            _setStatusForm();
        }

        //selection changed
        private void gvListCourse_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvListCourse.SelectedRowsCount > 0)
                _CourseModelNow = (CourseModel)gvListCourse.GetRow(gvListCourse.FocusedRowHandle);
            else
                _CourseModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        //click
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập mã Khóa học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteStartYear.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày bắt đầu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteEndYear.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn ngày kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _Course.addNewCourse(_CourseModelNow);
                }
                else
                {
                    bresult = _Course.updateCurrentCourse(_CourseModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListCourse();
                    _IStatusForm = 0;
                    _setStatusForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _CourseModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            txtID.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_CourseModelNow != null)
            {
                if (_Course.deleteCurrentCourse(_CourseModelNow))
                {
                    _lstLoadListCourse();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (_lstCourse.Count == 0)
                    {
                        _CourseModelNow = null;
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

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            _IStatusForm = 0;
            _setStatusForm();
            _lstCourse = _Course.loadCourse();
            gcListCourse.DataSource = _lstCourse;
        }

        private void btnExitFormManageCourse_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }
        //stt

        private void gvListCourse_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gvListCourse_RowCountChanged(object sender, EventArgs e)
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
