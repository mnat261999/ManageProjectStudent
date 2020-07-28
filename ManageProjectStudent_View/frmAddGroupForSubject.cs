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
    public partial class frmAddGroupForSubject : Form
    {
        public frmAddGroupForSubject()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private IClassGroupOfSubject _Group = Config.Container.Resolve<IClassGroupOfSubject>();
        private IStaff _Staff = Config.Container.Resolve<IStaff>();
        private ISubject _Subject = Config.Container.Resolve<ISubject>();

        private int _IStatusForm = 0;
        private ClassGroupOfSubject _GroupModelNow = null;
        private BindingList<ClassGroupOfSubject> _lstGroup = new BindingList<ClassGroupOfSubject>();
        private BindingList<StaffModel> _lstLecturer = new BindingList<StaffModel>();
        private BindingList<SubjectModel> _lstSubject = new BindingList<SubjectModel>();

        private StaffModel StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel Decentralize = null;
        #endregion
        #region Method
        private string getMaxID()
        {
            string _STR_MAX = GarenaViewModel.returnMaxCode(_Staff.lstStaffID());
            if (_STR_MAX == "1")
                return "NL" + _STR_MAX;
            return _STR_MAX;
        }

        private void _setStatusForm()
        {
            //txtID.ReadOnly = true;
            switch (_IStatusForm)
            {
                case 0: // View
                    grpInformationGroup.Enabled = false;
                    txtID.ReadOnly = true;
                    if (_GroupModelNow != null)
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
                    txtID.Text = getMaxID();
                    txtName.Text = string.Empty;
                    lkeSubject.EditValue = null;
                    lkeLecturer.EditValue = null;
                    
                    grpInformationGroup.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2: // Update
                    grpInformationGroup.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if(_GroupModelNow == null)
            {
                txtID.Text = getMaxID();
                txtName.Text = string.Empty;
                lkeSubject.EditValue = null;
                lkeLecturer.EditValue = null;
            }  
            else
            {
                txtID.Text =_GroupModelNow.StrGroupID ;
                txtName.Text = _GroupModelNow.StrGroupName;
                lkeSubject.EditValue =_GroupModelNow.StrSubjectID ;
                lkeLecturer.EditValue =_GroupModelNow.StrStaffID ;
            }    
        }

        private void _getData()
        {
            if(_GroupModelNow == null)
            {
                _GroupModelNow = new ClassGroupOfSubject();
            }
            _GroupModelNow.StrStaffID = txtID.Text;
            _GroupModelNow.StrGroupName = txtName.Text;
            _GroupModelNow.StrSubjectID = lkeSubject.GetColumnValue("StrSubjectID").ToString();
        }

        private void _lstLoadListGroup()
        {
            _lstGroup = _Group.loadClassGroupOfSubject();
            gcListGroup.DataSource = _lstGroup;
        }
        #endregion

        #region Event

        private void frmAddGroupForSubject_Load(object sender, EventArgs e)
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
            lkeSubject.Properties.Columns["colLecturerName"].FieldName = "StrStaffName";

            ///*GridView*/
            _lstGroup = _Group.loadClassGroupOfSubject();

            LookUpEdit_Subject.DataSource = _lstSubject;
            LookUpEdit_Subject.Columns["colSubjectID"].FieldName = "StrSubjectID";
            LookUpEdit_Subject.Columns["colSubjectName"].FieldName = "StrSubjectName";

            LookUpEdit_Lecturer.DataSource = _lstLecturer;
            LookUpEdit_Lecturer.Columns["colLecturerID"].FieldName = "StrStaffID";
            LookUpEdit_Lecturer.Columns["colLecturerName"].FieldName = "StrStaffName";

            gcListGroup.DataSource = _lstGroup;
            _setStatusForm();
        }

        private void gvListCourse_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvListCourse.SelectedRowsCount > 0)
                _GroupModelNow = (ClassGroupOfSubject)gvListCourse.GetRow(gvListCourse.FocusedRowHandle);
            else
                _GroupModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _GroupModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            txtName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_GroupModelNow != null)
            {
                if (_Group.deleteCurrentClassGroupOfSubject(_GroupModelNow))
                {
                    _lstLoadListGroup();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstLecturer.Count == 0)
                    {
                        _GroupModelNow = null;
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
            if (txtName.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập tên Nhóm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeSubject.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeLecturer.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Giảng viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _Group.addNewClassGroupOfSubject(_GroupModelNow);
                }
                else
                {
                    bresult = _Group.updateCurrentClassGroupOfSubject(_GroupModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListGroup();
                    _IStatusForm = 0;
                    _setStatusForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExitFormManageCourse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            _IStatusForm = 0;
            _setStatusForm();
            _lstGroup = _Group.loadClassGroupOfSubject();
            gcListGroup.DataSource = _lstGroup;
        }

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
