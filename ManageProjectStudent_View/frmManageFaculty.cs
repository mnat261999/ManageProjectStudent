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
    public partial class frmManageFaculty : Form
    {
        public frmManageFaculty()
        {
            InitializeComponent();
        }
        #region Anh Thu
        #region Properties
        private bool indicatorIcon = true;
        private int _IStatusForm = 0;
        private FacultyModel _FacultyModelNow = null;
        private IFaculty _Faculty = Config.Container.Resolve<IFaculty>();
        private BindingList<FacultyModel> _lstFaculty = new BindingList<FacultyModel>();

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
                    grpInformationFaculty.Enabled = false;
                    if(_FacultyModelNow != null)
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
                    txtFacultyID.Text = "";
                    txtFacultyName.Text = "";
                    dteStartYear.EditValue = null;

                    grpInformationFaculty.Enabled = true;

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    break;
                case 2:
                    grpInformationFaculty.Enabled = true;
                    break;
            }    
        }

        private void _loadData()
        {
            if(_FacultyModelNow == null)
            {
                txtFacultyID.Text = "";
                txtFacultyName.Text = "";
                dteStartYear.EditValue = null;
            }
            else
            {
                txtFacultyID.Text = _FacultyModelNow.StrFacultyID;
                txtFacultyName.Text = _FacultyModelNow.StrFacultyName;
                dteStartYear.EditValue = _FacultyModelNow.DtFoundedYear.Date;
            }
        }

        private void _getData()
        {
            if(_FacultyModelNow == null)
            {
                _FacultyModelNow = new FacultyModel();
            }
            _FacultyModelNow.StrFacultyID = txtFacultyID.Text;
            _FacultyModelNow.StrFacultyName = txtFacultyName.Text;
            _FacultyModelNow.DtFoundedYear = (DateTime)dteStartYear.EditValue;
        }

        private void _lstLoadListFaculty()
        {
            _lstFaculty = _Faculty.loadFaculty();
            gcListFaculty.DataSource = _lstFaculty;
        }
        #endregion
        #region Event
        //load
        private void frmManageFaculty_Load(object sender, EventArgs e)
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

            dteStartYear.EditValue = DateTime.Now.Date;

            _lstFaculty = _Faculty.loadFaculty();
            gcListFaculty.DataSource = _lstFaculty;
            _setStatusForm();
        }

        //selection changed
        private void gvFacultyList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvFacultyList.SelectedRowsCount > 0)
                _FacultyModelNow = (FacultyModel)gvFacultyList.GetRow(gvFacultyList.FocusedRowHandle);
            else
                _FacultyModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        //click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _FacultyModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            txtFacultyID.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtFacultyID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_FacultyModelNow != null)
            {
                if (_Faculty.deleteCurrentFaculty(_FacultyModelNow))
                {
                    _lstLoadListFaculty();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstFaculty.Count == 0)
                    {
                        _FacultyModelNow = null;
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
            _lstFaculty = _Faculty.loadFaculty();
            gcListFaculty.DataSource = _lstFaculty;
        }

        private void btnExitFormManageCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmHome = new frmHome();
            frmHome.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFacultyID.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Mã khoa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtFacultyName.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Tên khoa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteStartYear.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày thành lập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _Faculty.addNewFaculty(_FacultyModelNow);
                }
                else
                {
                    bresult = _Faculty.updateCurrentFaculty(_FacultyModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListFaculty();
                    _IStatusForm = 0;
                    _setStatusForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //keypress
        private void txtFacultyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Faculty._checkCharacterNumberFaculty(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Không được nhập ký tự số, chỉ được nhập chữ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //stt
        private void gvFacultyList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gvFacultyList_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }
        #endregion

        #endregion

    }
}
