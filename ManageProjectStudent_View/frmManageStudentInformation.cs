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
    public partial class frmManageStudentInformation : Form
    {
        #region Properties
        private bool indicatorIcon = true;
        private IStudent _Student = Config.Container.Resolve<IStudent>();
        private int _IStatusForm = 0;
        private StudentModel _StudentModelNow = null;
        private BindingList<StudentModel> _lstStudent = new BindingList<StudentModel>();
        private BindingList<FacultyModel> _lstFaculty = new BindingList<FacultyModel>();
        private BindingList<ClassModel> _lstClass = new BindingList<ClassModel>();
        private IClass _Class = Config.Container.Resolve<IClass>();
        private IFaculty _Faculty = Config.Container.Resolve<IFaculty>();

        private StaffModel StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel Decentralize = null;
        #endregion
        public frmManageStudentInformation()
        {
            InitializeComponent();
        }
        #region Method
        private string getMaxID()
        {
            string _STR_MAX = GarenaViewModel.returnMaxCode(_Student.lstStudentID());
            if (_STR_MAX == "1")
                return "SV" + _STR_MAX;
            return _STR_MAX;
        }
        private void _setStatusForm()
        {
            switch (_IStatusForm)
            {
                case 0: // View
                    txtID.ReadOnly = true;
                    grpInformationStudent.Enabled = false;
                    dteBirthday.Enabled = true;
                    if (_StudentModelNow != null)
                    {
                        if(Decentralize.BView == true)
                        {
                            if(Decentralize.BAdd == true)
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
                    txtID.Text = getMaxID();
                    txtFullName.Text = string.Empty;
                    dteBirthday.EditValue = null;
                    dteStartYear.EditValue = null;
                    txtPhoneNumber.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtIDCard.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                    radNam.Checked = false;
                    radNu.Checked = false;
                    radAvailable.Checked = false;
                    radUnavailable.Checked = false;
                    lkeClass.EditValue = null;
                    lkeFaculty.EditValue = null;

                    grpInformationStudent.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2:
                    grpInformationStudent.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
        }
        private void _loadData()
        {
            if (_StudentModelNow == null)
            {
                txtID.Text = string.Empty;
                txtFullName.Text = string.Empty;
                dteBirthday.EditValue = null;
                dteStartYear.EditValue = null;
                txtPhoneNumber.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtIDCard.Text = string.Empty;
                txtAddress.Text = string.Empty;
                radNam.Checked = false;
                radNu.Checked = false;
                radAvailable.Checked = false;
                radUnavailable.Checked = false;
                lkeClass.EditValue = null;
                lkeFaculty.EditValue = null;
            }
            else
            {
                txtID.Text = _StudentModelNow.StrStudentID;
                txtFullName.Text = _StudentModelNow.StrStudentName;
                dteBirthday.EditValue = _StudentModelNow.DtBirthDay.Date;
                dteStartYear.EditValue = _StudentModelNow.DtStartYear.Date;
                txtPhoneNumber.Text = _StudentModelNow.StrPhone;
                txtEmail.Text = _StudentModelNow.StrEmail;
                txtIDCard.Text = _StudentModelNow.StrCardID;
                txtAddress.Text = _StudentModelNow.StrAddress;
                if (_StudentModelNow.StrSex == "Nam")
                {
                    radNam.Checked = true;
                    radNu.Checked = false;
                }
                else
                {
                    radNam.Checked = false;
                    radNu.Checked = true;
                }
                if (_StudentModelNow.BStatus == true)
                {
                    radAvailable.Checked = true;
                    radUnavailable.Checked = false;
                }
                else
                {

                    radAvailable.Checked = false;
                    radUnavailable.Checked = true;
                }
                lkeClass.EditValue = _StudentModelNow.StrClassID;
                lkeFaculty.EditValue = _StudentModelNow.StrFacultyID;
            }
        }
        private void _getData()
        {
            if (_StudentModelNow == null)
            {
                _StudentModelNow = new StudentModel();
            }
            _StudentModelNow.StrStudentID = txtID.Text;
            _StudentModelNow.StrStudentName = txtFullName.Text;
            _StudentModelNow.DtBirthDay = (DateTime)dteBirthday.EditValue;
            _StudentModelNow.DtStartYear = (DateTime)dteStartYear.EditValue;
            _StudentModelNow.StrPhone = txtPhoneNumber.Text;
            _StudentModelNow.StrEmail = txtEmail.Text;
            _StudentModelNow.StrCardID = txtIDCard.Text;
            _StudentModelNow.StrAddress = txtAddress.Text;
            if (radNam.Checked)
            {
                _StudentModelNow.StrSex = radNam.Text;
            }
            else if (radNu.Checked)
            {
                _StudentModelNow.StrSex = radNu.Text;
            }

            if (radAvailable.Checked)
            {
                _StudentModelNow.BStatus = true;
            }
            else
            {
                _StudentModelNow.BStatus = false;
            }
            _StudentModelNow.StrClassID = lkeClass.GetColumnValue("StrClassID").ToString();
            _StudentModelNow.StrFacultyID = lkeFaculty.GetColumnValue("StrFacultyID").ToString();
        }
        private void _lstLoadListStudent()
        {
            _lstStudent = _Student.loadStudent();
            gcListStudent.DataSource = _lstStudent;
        }
        #endregion
        #region Event
        //load
        private void frmManageStudentInformation_Load(object sender, EventArgs e)
        {
            StaffModel = frmHome.staffModel;
            if(frmHome.lstDecent != null)
            {
                foreach(DecentralizeModel decen in frmHome.lstDecent)
                {
                    if(StaffModel.StrStaffTypeID == decen.StrStaffTypeID && this.Name == decen.StrFormID)
                    {
                        Decentralize = _Decen.getDecentralizeStaffIdForm(decen.StrStaffTypeID,decen.StrFormID);
                    }    
                }    
            }    
        
             dteBirthday.EditValue = DateTime.Now.Date;
            dteStartYear.EditValue = DateTime.Now.Date;

            _lstClass = _Class.loadClass();
            lkeClass.Properties.ValueMember = "StrClassID";
            lkeClass.Properties.DisplayMember = "StrClassName";
            lkeClass.Properties.DataSource = _lstClass;
            lkeClass.Properties.Columns["colClassID"].FieldName = "StrClassID";
            lkeClass.Properties.Columns["colClassName"].FieldName = "StrClassName";

            _lstFaculty = _Faculty.loadFaculty();
            lkeFaculty.Properties.ValueMember = "StrFacultyID";
            lkeFaculty.Properties.DisplayMember = "StrFacultyName";
            lkeFaculty.Properties.DataSource = _lstFaculty;
            lkeFaculty.Properties.Columns["colFacultyID"].FieldName = "StrFacultyID";
            lkeFaculty.Properties.Columns["colFacultyName"].FieldName = "StrFacultyName";

            ///*GridView*/
            _lstStudent = _Student.loadStudent();

            LookUpEdit_Class.DataSource = _lstClass;
            LookUpEdit_Class.Columns["colClassID"].FieldName = "StrClassID";
            LookUpEdit_Class.Columns["colClassName"].FieldName = "StrClassName";

            LookUpEdit_Faculty.DataSource = _lstFaculty;
            LookUpEdit_Faculty.Columns["colFacultyID"].FieldName = "StrFacultyID";
            LookUpEdit_Faculty.Columns["colFacultyName"].FieldName = "StrFacultyName";

            gcListStudent.DataSource = _lstStudent;
            _setStatusForm();

        }

        //selection changed
        private void gvStudentList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvStudentList.SelectedRowsCount > 0)
                _StudentModelNow = (StudentModel)gvStudentList.GetRow(gvStudentList.FocusedRowHandle);
            else
                _StudentModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        //click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _StudentModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
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
            if (_StudentModelNow != null)
            {
                if (_Student.deleteCurrentStudent(_StudentModelNow))
                {
                    _lstLoadListStudent();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstStudent.Count == 0)
                    {
                        _StudentModelNow = null;
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
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập tên Sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteBirthday.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteStartYear.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày bắt đầu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPhoneNumber.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtEmail.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Email", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtIDCard.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Chứng minh nhân dân", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAddress.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Địa chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radNam.Checked) && !(radNu.Checked))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radAvailable.Checked) && !(radUnavailable.Checked))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Trạng thái", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeClass.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Lớp học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeFaculty.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Khoa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                if(GarenaViewModel.checkPhoneNumber(_StudentModelNow.StrPhone)== false)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Số Điện Thoại Phải 10 Số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(GarenaViewModel.checkIDCard(_StudentModelNow.StrCardID) == true)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("CMND Phải Trên 8 Số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                else
                {
                    _getData();
                    bool bresult = false;
                    if (_IStatusForm == 1)
                    {
                        bresult = _Student.addNewStudent(_StudentModelNow);
                    }
                    else
                    {
                        bresult = _Student.updateCurrentStudent(_StudentModelNow);
                    }

                    if (!bresult)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _lstLoadListStudent();
                        _IStatusForm = 0;
                        _setStatusForm();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvStudentList.RowCount > 0)
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = "";
                    dialog.Filter = @"Micrsoft Excel|*.xlsx";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gvStudentList.ColumnPanelRowHeight = 40;
                        gvStudentList.OptionsPrint.AutoWidth = AutoSize;
                        gvStudentList.OptionsPrint.ShowPrintExportProgress = true;
                        gvStudentList.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = "Sheet1";

                        ExportSettings.DefaultExportType = ExportType.Default;
                        gvStudentList.ExportToXlsx(dialog.FileName, options);
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error" + ex, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                var _DLG_OpenExcel = new OpenFileDialog();
                _DLG_OpenExcel.Title = @"Import File Excel";
                if (_DLG_OpenExcel.ShowDialog() == DialogResult.OK)
                {
                    string _STR_FileName = Path.GetFileName(_DLG_OpenExcel.FileName);
                    // Open file excel
                    var package = new ExcelPackage(new FileInfo(_DLG_OpenExcel.FileName));
                    //Take out the first sheet
                    ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
                    BindingList<StudentModel> _lstStudent_Import = new BindingList<StudentModel>();
                    //Browse sequentially from the second to the last row of the Excel file, because Excel starts from 1 and not 0
                    for (int i = workSheet.Dimension.Start.Row + 1; i < workSheet.Dimension.End.Row; ++i)
                    {
                        try
                        {

                            int j = 1; //  j as row.
                            string StrStudentID = "";
                            string StrStudentName = "";
                            DateTime DtBirthDay = new DateTime();
                            string StrCardID = "";
                            string StrEmail = "";
                            string _StrAddress = "";
                            DateTime _DtStartYear = new DateTime();
                            bool _BStatus;

                        }
                        catch
                        {

                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            _IStatusForm = 0;
            _setStatusForm();
            _lstStudent = _Student.loadStudent();
            gcListStudent.DataSource = _lstStudent;
        }

        private void btnExitFormManageStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmHome frmHome = new frmHome(IStatus, StaffModel);
            //frmHome.ShowDialog();
            this.Close();
        }

        //key press

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Student._checkCharacterNumberStudent(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Không được nhập ký tự số, chỉ được nhập chữ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Student._checkCharacterCharStudent(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Không được nhập ký tự chữ, chỉ được nhập số.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Student._checkCharacterCharStudent(e.KeyChar))
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

        //stt

        private void gvStudentList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gvStudentList_RowCountChanged(object sender, EventArgs e)
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
       
