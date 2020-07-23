using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageProjectStudent_Interface;
using Unity;
using ManageProjectStudent_Model;
using ManageProjectStudent_ViewModel;
using DevExpress.XtraEditors.Filtering.Templates;
using System.Security.AccessControl;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;

namespace ManageProjectStudent_View
{
    public partial class frmManageSubject : Form
    {
        public frmManageSubject()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private ISubject _Subject = Config.Container.Resolve<ISubject>();
        private int _IStatusForm = 0;
        private SubjectModel _SubjectModelNow = null;
        private BindingList<SubjectModel> _lstSubject = new BindingList<SubjectModel>();
        private BindingList<FacultyModel> _lstFaculty = new BindingList<FacultyModel>();
        private IFaculty _Faculty = Config.Container.Resolve<IFaculty>();

        private StaffModel StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel Decentralize = null;
        #endregion
        #region Method
        private void _setStatusForm()
        {
            switch (_IStatusForm)
            {
                case 0: // View
                    grpInformationSubject.Enabled = false;
                    if (_SubjectModelNow != null)
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
                    txtID.Text = "";
                    txtName.Text = "";
                    lkeFaculty.EditValue = null;
                    dteStartTime.EditValue = null;
                    dteEndTime.EditValue = null;

                    grpInformationSubject.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2:
                    grpInformationSubject.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if (_SubjectModelNow == null)
            {
                txtID.Text = "";
                txtName.Text = "";
                lkeFaculty.EditValue = null;
                dteStartTime.EditValue = null;
                dteEndTime.EditValue = null;
            }
            else
            {
                txtID.Text = _SubjectModelNow.StrSubjectID;
                txtName.Text = _SubjectModelNow.StrSubjectName;
                lkeFaculty.EditValue = _SubjectModelNow.StrFacultyID;
                dteStartTime.EditValue = _SubjectModelNow.DtStartDay.Date;
                dteEndTime.EditValue = _SubjectModelNow.DtEndDay.Date;
            }
        }

        private void _getData()
        {
            if (_SubjectModelNow == null)
            {
                _SubjectModelNow = new SubjectModel();
            }
            _SubjectModelNow.StrSubjectID = txtID.Text;
            _SubjectModelNow.StrSubjectName = txtName.Text;
            _SubjectModelNow.StrFacultyID = lkeFaculty.GetColumnValue("StrFacultyID").ToString();
            _SubjectModelNow.DtStartDay = (DateTime)dteStartTime.EditValue;
            _SubjectModelNow.DtEndDay = (DateTime)dteEndTime.EditValue;

        }

        private void _lstLoadListSubject()
        {
            _lstSubject = _Subject.loadSubject();
            gcListSubject.DataSource = _lstSubject;
        }
        #endregion
        #region Event

        private void frmManageSubject_Load(object sender, EventArgs e)
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

            dteStartTime.EditValue = DateTime.Now.Date;
            dteEndTime.EditValue = DateTime.Now.Date;

            _lstFaculty = _Faculty.loadFaculty();
            lkeFaculty.Properties.ValueMember = "StrFacultyID";
            lkeFaculty.Properties.DisplayMember = "StrFacultyName";
            lkeFaculty.Properties.DataSource = _lstFaculty;
            lkeFaculty.Properties.Columns["colFacultyID"].FieldName = "StrFacultyID";
            lkeFaculty.Properties.Columns["colFacultyName"].FieldName = "StrFacultyName";

            ///*GridView*/
            _lstSubject = _Subject.loadSubject();

            LookUpEdit_Faculty.DataSource = _lstFaculty;
            LookUpEdit_Faculty.Columns["colFacultyID"].FieldName = "StrFacultyID";
            LookUpEdit_Faculty.Columns["colFacultyName"].FieldName = "StrFacultyName";

            gcListSubject.DataSource = _lstSubject;
            _setStatusForm();
        }

        private void gvListSubject_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvListSubject.SelectedRowsCount > 0)
                _SubjectModelNow = (SubjectModel)gvListSubject.GetRow(gvListSubject.FocusedRowHandle);
            else
                _SubjectModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            _SubjectModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            txtName.Focus();
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtName.Focus();
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (_SubjectModelNow != null)
            {
                if (_Subject.deleteCurrentSubject(_SubjectModelNow))
                {
                    _lstLoadListSubject();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstSubject.Count == 0)
                    {
                        _SubjectModelNow = null;
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
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập tên Môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeFaculty.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Khoa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteStartTime.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày bắt đầu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteEndTime.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _Subject.addNewSubject(_SubjectModelNow);
                }
                else
                {
                    bresult = _Subject.updateCurrentSubjectf(_SubjectModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListSubject();
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
            _lstSubject = _Subject.loadSubject();
            gcListSubject.DataSource = _lstSubject;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageSubjectMain frmManageSubjectMain = new frmManageSubjectMain();
            frmManageSubjectMain.ShowDialog();
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Subject._checkCharacterNumberSubject(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Không được nhập ký tự số, chỉ được nhập chữ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void gvListSubject_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gvListSubject_RowCountChanged(object sender, EventArgs e)
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
