using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using ManageProjectStudent_Interface;
using Unity;
using ManageProjectStudent_ViewModel;
using ManageProjectStudent_Model;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace ManageProjectStudent_View
{
    public partial class frmStaffType : Form
    {
        public frmStaffType()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private int _IStatusForm = 0;
        private IStaffType _StaffType = Config.Container.Resolve<IStaffType>();
        private BindingList<StaffTypeModel> _lstStaffType = new BindingList<StaffTypeModel>();
        private StaffTypeModel _StaffTypeModelNow = null;

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
                case 0: // View
                    grpInformationStaffType.Enabled = false;
                    if (_StaffTypeModelNow != null)
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
                case 1: // Add.
                    txtID.Text = string.Empty;
                    txtName.Text = string.Empty;

                    grpInformationStaffType.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2: // Update
                    grpInformationStaffType.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if(_StaffTypeModelNow!= null)
            {
                txtID.Text = string.Empty;
                txtName.Text = string.Empty;
            } 
            else
            {
                txtID.Text = _StaffTypeModelNow.StrStaffTypeID;
                txtName.Text = _StaffTypeModelNow.StrStaffTypeName;
            }    
        }

        private void _getData()
        {
            if (_StaffTypeModelNow == null)
            {
                _StaffTypeModelNow = new StaffTypeModel();
            }
            _StaffTypeModelNow.StrStaffTypeID = txtID.Text;
            _StaffTypeModelNow.StrStaffTypeName = txtName.Text;
        }

        private void _lstLoadListStaffType()
        {
            _lstStaffType = _StaffType.loadStaffType();
            gcListStaffType.DataSource = _lstStaffType;
        }
        #endregion

        private void frmStaffType_Load(object sender, EventArgs e)
        {
            StaffModel = frmHome.staffModel;
            if (frmHome.lstDecent != null)
            {
                foreach (DecentralizeModel decen in frmHome.lstDecent)
                {
                    if (StaffModel.StrStaffTypeID == decen.StrStaffTypeID && this.Name == decen.StrFormID)
                    {
                        Decentralize = _Decen.getDecentralizeStaffIdForm(decen.StrStaffTypeID, decen.StrFormID);
                        break;
                    }
                }
            }

            _lstStaffType = _StaffType.loadStaffType();
            gcListStaffType.DataSource = _lstStaffType;
            _setStatusForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _StaffTypeModelNow = null;
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
            if (_StaffTypeModelNow != null)
            {
                if (_StaffType.deleteCurrentStaffType(_StaffTypeModelNow))
                {
                    _lstLoadListStaffType();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstStaffType.Count == 0)
                    {
                        _StaffTypeModelNow = null;
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
            if (txtID.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Mã loại nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtName.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Tên loại nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _StaffType.addStaffTypeNew(_StaffTypeModelNow);
                }
                else
                {
                    bresult = _StaffType.updateCurrentStaffType(_StaffTypeModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool BAddecen = false;
                    if (_IStatusForm == 1)
                    {
                        BAddecen = _Decen.addNewStaffType(_StaffTypeModelNow);
                    }   
                    if(BAddecen == true)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Phân Quyền Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    

                    _lstLoadListStaffType();
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
            _lstStaffType = _StaffType.loadStaffType();
            gcListStaffType.DataSource = _lstStaffType;
        }

        private void btnExitFormManageLecturer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvStaffTypeList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            if (gvStaffTypeList.SelectedRowsCount > 0)
                _StaffTypeModelNow = (StaffTypeModel)gvStaffTypeList.GetRow(gvStaffTypeList.FocusedRowHandle);
            else
                _StaffTypeModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        private void gvStaffTypeList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gvStaffTypeList_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }
    }
}
