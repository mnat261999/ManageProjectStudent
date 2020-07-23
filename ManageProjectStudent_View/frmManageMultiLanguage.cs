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
    public partial class frmManageMultiLanguage : Form
    {
        public frmManageMultiLanguage()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private int _IStatusForm = 0;
        private LanguageModel _LanguageModelNow = null;
        private ILanguage _Lan = Config.Container.Resolve<ILanguage>();
        private BindingList<LanguageModel> _lstLan = new BindingList<LanguageModel>();

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
                    grpInformationLan.Enabled = false;
                    txtID.ReadOnly = true;
                    if (_LanguageModelNow != null)
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
                    txtID.Text = string.Empty;
                    txtName.Text = string.Empty;
                    radDefault.Checked = false;
                    radNoneDefault.Checked = false;
                    radAvailable.Checked = false;
                    radUnavailable.Checked = false;

                    grpInformationLan.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2: // Update
                    grpInformationLan.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if (_LanguageModelNow == null)
            {
                txtID.Text = string.Empty;
                txtName.Text = string.Empty;
                radDefault.Checked = false;
                radNoneDefault.Checked = false;
                radAvailable.Checked = false;
                radUnavailable.Checked = false;
            }
            else
            {
                txtID.Text = _LanguageModelNow.StrLanguageID;
                txtName.Text = _LanguageModelNow.StrLanguageName;
                if (_LanguageModelNow.BDefault == true)
                {
                    radDefault.Checked = true;
                    radNoneDefault.Checked = false;
                }
                else
                {
                    radDefault.Checked = false;
                    radNoneDefault.Checked = true;
                }
                if (_LanguageModelNow.BStatus == true)
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


        #endregion

    }
}
