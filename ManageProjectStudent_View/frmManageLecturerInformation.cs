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
    public partial class frmManageLecturerInformation : Form
    {
        public frmManageLecturerInformation()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private IStaff _Staff = Config.Container.Resolve<IStaff>();
        private IFaculty _Faculty = Config.Container.Resolve<IFaculty>();

        private int _IStatusForm = 0;
        private StaffModel _LecturerModelNow = null;
        private BindingList<StaffModel> _lstLecturer = new BindingList<StaffModel>();
        private BindingList<FacultyModel> _lstFaculty = new BindingList<FacultyModel>();

        private StaffModel StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel Decentralize = null;
        #endregion
        #region Method
        private string getMaxID()
        {
            string _STR_MAX = GarenaViewModel.returnMaxCode(_Staff.lstStaffID());
            if (_STR_MAX == "1")
                return "NV" + _STR_MAX;
            return _STR_MAX;
        }

        private void _setStatusForm()
        {
            //txtID.ReadOnly = true;
            switch (_IStatusForm)
            {
                case 0: // View
                    grpInformationLecturer.Enabled = false;
                    txtID.ReadOnly = true;
                    //btnSave.Enabled = false;
                    dteBirthday.Enabled = true;
                    if (_LecturerModelNow != null)
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
                    //else
                    //{
                    //    btnUpdate.Enabled = true;
                    //    btnDelete.Enabled = true;
                    //}
                    break;
                case 1: // Add.
                    txtID.Text = getMaxID();
                    txtFullName.Text = string.Empty;
                    txtIDCard.Text = string.Empty;
                    dteBirthday.EditValue = null;
                    txtAddress.Text = string.Empty;
                    txtPhoneNumber.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    lkeFaculty.EditValue = null;
                    radNam.Checked = false;
                    radNu.Checked = false;
                    radAvailable.Checked = false;
                    radUnavailable.Checked = false;

                    grpInformationLecturer.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2: // Update
                    grpInformationLecturer.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if (_LecturerModelNow==null)
            {
                txtID.Text = string.Empty;
                txtFullName.Text = string.Empty;
                txtIDCard.Text = string.Empty;
                dteBirthday.EditValue = null;
                txtAddress.Text = string.Empty;
                txtPhoneNumber.Text = string.Empty;
                txtEmail.Text = string.Empty;
                lkeFaculty.EditValue = null;
                radNam.Checked = false;
                radNu.Checked = false;
                radAvailable.Checked = false;
                radUnavailable.Checked = false;
            }   
            else
            {
                txtID.Text = _LecturerModelNow.StrStaffID;
                txtFullName.Text = _LecturerModelNow.StrStaffName;
                txtIDCard.Text = _LecturerModelNow.StrCardID;
                dteBirthday.EditValue = _LecturerModelNow.DtBirthDay.Date;
                txtAddress.Text = _LecturerModelNow.StrAddress;
                txtPhoneNumber.Text = _LecturerModelNow.StrPhone;
                txtEmail.Text = _LecturerModelNow.StrEmail;
                lkeFaculty.EditValue = _LecturerModelNow.StrFacultyID;
                if (_LecturerModelNow.StrSex == "Nam")
                {
                    radNam.Checked = true;
                    radNu.Checked = false;
                }
                else
                {
                    radNam.Checked = false;
                    radNu.Checked = true;
                }
                if (_LecturerModelNow.BStatus == true)
                {
                    radAvailable.Checked = true;
                    radUnavailable.Checked = false;
                }
                else
                {

                    radAvailable.Checked = false;
                    radUnavailable.Checked = true;
                }
            }    
        }

        private void _getData()
        {
            if (_LecturerModelNow == null)
            {
                _LecturerModelNow = new StaffModel();
            }
            _LecturerModelNow.StrStaffID = txtID.Text;
            _LecturerModelNow.StrStaffName = txtFullName.Text;
            _LecturerModelNow.StrCardID = txtIDCard.Text;
            _LecturerModelNow.DtBirthDay = (DateTime)dteBirthday.EditValue;
            _LecturerModelNow.StrAddress = txtAddress.Text;
            _LecturerModelNow.StrPhone = txtPhoneNumber.Text;
            _LecturerModelNow.StrEmail = txtEmail.Text;
            _LecturerModelNow.StrFacultyID = lkeFaculty.GetColumnValue("StrFacultyID").ToString();
            if (radNam.Checked)
            {
                _LecturerModelNow.StrSex = radNam.Text;
            }
            else if (radNu.Checked)
            {
                _LecturerModelNow.StrSex = radNu.Text;
            }

            if (radAvailable.Checked)
            {
                _LecturerModelNow.BStatus = true;
            }
            else
            {
                _LecturerModelNow.BStatus = false;
            }
        }

        private void _lstLoadListLecturer()
        {
            _lstLecturer = _Staff.loadStaff();
            //if(_lstLecturer.Count>0)
            //{
            //    foreach(StaffModel lt in _lstLecturer)
            //    {
            //        if (lt.StrStaffID == "LT1")
            //        {
            //            _lstLecturer.Remove(lt);
            //            break;
            //        }
            //    }
            //}
            gcListLecturer.DataSource = _lstLecturer;
        }

        #endregion
        #region Event
        //load
        private void frmManageLecturerInformation_Load(object sender, EventArgs e)
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

            dteBirthday.EditValue = DateTime.Now.Date;

            _lstFaculty = _Faculty.loadFaculty();
            lkeFaculty.Properties.ValueMember = "StrFacultyID";
            lkeFaculty.Properties.DisplayMember = "StrFacultyName";
            lkeFaculty.Properties.DataSource = _lstFaculty;
            lkeFaculty.Properties.Columns["colFacultyID"].FieldName = "StrFacultyID";
            lkeFaculty.Properties.Columns["colFacultyName"].FieldName = "StrFacultyName";

            ///*GridView*/
            _lstLecturer = _Staff.loadStaff();

            LookUpEdit_Faculty.DataSource = _lstFaculty;
            LookUpEdit_Faculty.Columns["colFacultyID"].FieldName = "StrFacultyID";
            LookUpEdit_Faculty.Columns["colFacultyName"].FieldName = "StrFacultyName";

            gcListLecturer.DataSource = _lstLecturer;
            _setStatusForm();
        }

        //selection changed
        private void gvLecturerList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if(gvLecturerList.SelectedRowsCount>0)
                _LecturerModelNow = (StaffModel)gvLecturerList.GetRow(gvLecturerList.FocusedRowHandle);
            else
                _LecturerModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }
        //stt
        private void gvLecturerList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gvLecturerList_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }

        //click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _LecturerModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            //txtID.Text = StaffViewModel.GetByIDMaxLecturer();
            txtFullName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtFullName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_LecturerModelNow != null)
            {
                if (_Staff.deleteCurrentStaff(_LecturerModelNow))
                {
                    _lstLoadListLecturer();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstLecturer.Count == 0)
                    {
                        _LecturerModelNow = null;
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
            if (txtFullName.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập tên Giảng viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtIDCard.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Chứng minh nhân dân", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_Staff.checkStaffID(txtID.Text) == true)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Mã số nhân viên bị trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_Staff.checkCardID(txtID.Text) == true)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("CMND bị trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteBirthday.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAddress.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Địa chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPhoneNumber.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtEmail.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập Email";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeFaculty.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Khoa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radNam.Checked) && !(radNu.Checked))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radAvailable.Checked) && !(radUnavailable.Checked))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Trạng thái", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if(_IStatusForm == 1)
                {
                    bresult = _Staff.addNewStaff(_LecturerModelNow);
                }
                else
                {
                    bresult = _Staff.updateCurrentStaff(_LecturerModelNow);
                }

                if(!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListLecturer();
                    _IStatusForm = 0;
                    _setStatusForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }    
        }

        private void btnExitFormManageLecturer_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmHome frmHome = new frmHome();
            //frmHome.ShowDialog();
            this.Close();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            _IStatusForm = 0;
            _setStatusForm();
            _lstLecturer = _Staff.loadStaff();
            gcListLecturer.DataSource = _lstLecturer;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvLecturerList.RowCount > 0)
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = "";
                    dialog.Filter = @"Micrsoft Excel|*.xlsx";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gvLecturerList.ColumnPanelRowHeight = 40;
                        gvLecturerList.OptionsPrint.AutoWidth = AutoSize;
                        gvLecturerList.OptionsPrint.ShowPrintExportProgress = true;
                        gvLecturerList.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = "Sheet1";

                        ExportSettings.DefaultExportType = ExportType.Default;
                        gvLecturerList.ExportToXlsx(dialog.FileName, options);
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error" + ex, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //key press

        //private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (GarenaViewModel._checkCharacterNumber(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        ((TextBox)sender).Focus();
        //        string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
        //        MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Staff._checkCharacterNumberStaff(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Không được nhập ký tự số, chỉ được nhập chữ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Staff._checkCharacterCharStaff(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Không được nhập ký tự chữ, chỉ được nhập số.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Staff._checkCharacterCharStaff(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Không được nhập ký tự chữ, chỉ được nhập số.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //checked changed
        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radNam.Checked)
            {
                radNu.Checked = false;
            }
        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {
            if (radNu.Checked)
            {
                radNam.Checked = false;
            }
        }

        private void radAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (radAvailable.Checked)
            {
                radUnavailable.Checked = false;
            }
        }

        private void radUnavailable_CheckedChanged(object sender, EventArgs e)
        {
            if (radUnavailable.Checked)
            {
                radAvailable.Checked = false;
            }
        }
        #endregion
        //Thu

    }
}
