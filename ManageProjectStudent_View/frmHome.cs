
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageProjectStudent_Model;
using ManageProjectStudent_Interface;
using Unity;
using DevExpress.XtraGrid.Views.Layout;

namespace ManageProjectStudent_View
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            random = new Random();
        }
        #region Properties
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private IStudent _Student = Config.Container.Resolve<IStudent>();
        private IStaffType _StaffType = Config.Container.Resolve<IStaffType>();
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        BindingList<StaffTypeModel> lstStaffType = new BindingList<StaffTypeModel>();
        public static StudentModel studentModel = null;
        public static StaffModel staffModel = null;
        private DecentralizeModel Decen = null;
        public static BindingList<DecentralizeModel> lstDecent = null;
        List<DecentralizeModel> _lstdecentralizeModels = new List<DecentralizeModel>();
        bool BStatusLogin = false;
        int ICheck;
        #endregion
        #region Method
        private void setStatusLogin(bool bStatus, StudentModel student, StaffModel staff)
        {
            BStatusLogin = bStatus;
            studentModel = student;
            staffModel = staff;
            if (bStatus)
            {
                if (student != null)
                {
                    ICheck = 1;
                    lblDisplayName.Text = student.StrStudentName;
                    lblType.Text = "Sinh viên";
                }
                else
                {
                    lblDisplayName.Text = staff.StrStaffName;
                    if (lstStaffType == null)
                        lstStaffType = new BindingList<StaffTypeModel>();

                    lstStaffType = _StaffType.loadStaffType();

                    foreach (StaffTypeModel staffType in lstStaffType)
                    {
                        if (staff.StrStaffTypeID == staffType.StrStaffTypeID)
                        {
                            lblType.Text = staffType.StrStaffTypeName;
                            //lstDecent = _Decen.loadDecentralize();
                            break;
                        }
                    }
                    lstDecent = _Decen.getListDecentralizeStaff(staff.StrStaffTypeID);
                }
                btnLogin.Text = "Đăng xuất";
            }
            else
            {
                btnLogin.Text = "Đăng nhập";
                lblDisplayName.Text = "Họ tên";
                lblType.Text = "Chức danh";
            }    
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenuHome.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(10, 25, 77);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        #endregion
        #region Event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (!BStatusLogin)
            {
                frmLogin frm = new frmLogin();
                frm.login = setStatusLogin;
                frm.ShowDialog();
            }
            else
            {
                setStatusLogin(false, null, null);
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuHome.Size.Width == 56)
            {
                panelMenuHome.Size = new Size(250, 60);
                panUser.Visible = true;
                btnMenu.Text = "Menu";
            }
            else
            {
                panelMenuHome.Size = new Size(56, 60);
                panUser.Visible = false;
                btnMenu.Text = "";
            }
        }


        private void itemDecentralization_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmDecentralization frm = new frmDecentralization();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void itemManageStudent_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageStudentInformation frm = new frmManageStudentInformation();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void itemManageLecturer_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageLecturerInformation frm = new frmManageLecturerInformation();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void itemManageFaculty_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageFaculty frm = new frmManageFaculty();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void itemManageProject_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                frmManageProjectStudentMain frm = new frmManageProjectStudentMain();
                frm.ShowDialog();
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageProjectMain frm = new frmManageProjectMain();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void itemManagSubject_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageSubjectMain frm = new frmManageSubjectMain();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
        }

        private void itemManageClass_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageClass frm = new frmManageClass();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void itemManagStaffType_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmStaffType frm = new frmStaffType();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        #endregion

    }
}
