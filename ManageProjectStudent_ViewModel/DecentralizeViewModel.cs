using ManageProjectStudent_Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Data.Entity;
using ManageProjectStudent_Interface;



namespace ManageProjectStudent_ViewModel
{
    public class DecentralizeViewModel : INotifyPropertyChanged ,IDecentralize
    {
        #region by Phuoc
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<DecentralizeModel> loadDecentralize()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.DecentralizeModels.AsEnumerable()
                              select new DecentralizeModel
                              {
                                 StrFormID = x.StrFormID,
                                 StrStaffTypeID = x.StrStaffTypeID,
                                 BFullFuncion = x.BFullFuncion,
                                 BAdd = x.BAdd,
                                 BEdit = x.BEdit,
                                 BDelete = x.BDelete,
                                 BAccess = x.BAccess
                              }).ToList();
                return new BindingList<DecentralizeModel>(Result);
            }
        }
        public DecentralizeModel getDecentralizeStaffSelected(string StrStaffType)
        {
            var Staff = _Context.DecentralizeModels.SingleOrDefault
                   (x => x.StrStaffTypeID == StrStaffType);
            return Staff;
        }

        public DecentralizeModel getDecentralizeStaffIdForm(string StrStaffType, string StrFormID)
        {
            var query = _Context.DecentralizeModels.Where(x => x.StrStaffTypeID == StrStaffType).Where(x => x.StrFormID == StrFormID);
            var Result = query.SingleOrDefault();
            return Result;
        }

        public BindingList<DecentralizeModel> getListDecentralizeStaff(string StrStaffType)
        {
            var Staff = _Context.DecentralizeModels.Where
                   (x => x.StrStaffTypeID == StrStaffType).ToList();
            return new BindingList<DecentralizeModel>(Staff);
        }
        public List<string> getListDecentralizeStaffID(string StrStaffType)
        {
            var Staff = _Context.DecentralizeModels.Where
                   (x => x.StrStaffTypeID == StrStaffType).Select(x=> x.StrStaffTypeID).ToList();
            return Staff;
        }
        public bool addNewStaffType(StaffTypeModel staffType)
        {
            try
            {

                _Context.StaffTypeModels.Add(staffType);
                DecentralizeModel staff = new DecentralizeModel();
                foreach (FormModel x in _Context.FormModels)
                {
                    staff.StrStaffTypeID = staffType.StrStaffTypeID;
                    staff.BView = true;
                    staff.BAdd = false;
                    staff.BDelete = false;
                    staff.BDelete = false;
                    staff.BFullFuncion = false;
                    staff.BAccess = false;
                    staff.StrFormID = x.StrFormID;
                    _Context.DecentralizeModels.Add(staff);
                }

                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }

        }
        public bool addNewDecentralize(DecentralizeModel Decentralize)
        {
            try
            {
                _Context.DecentralizeModels.Add(Decentralize);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }      

        public bool updateCurrentDecentralizes(DecentralizeModel Decentralize)
        {
            try
            {
                var DecentralizeToUpdate = _Context.DecentralizeModels.Where
                 (x => x.StrStaffTypeID == Decentralize.StrStaffTypeID).Where
                 (x => x.StrFormID == Decentralize.StrFormID).SingleOrDefault();

                if (DecentralizeToUpdate != null)
                {
                    DecentralizeToUpdate.StrFormID = Decentralize.StrFormID;
                    DecentralizeToUpdate.BFullFuncion = Decentralize.BFullFuncion;
                    DecentralizeToUpdate.BAdd = Decentralize.BAdd;
                    DecentralizeToUpdate.BEdit = Decentralize.BEdit;
                    DecentralizeToUpdate.BDelete = Decentralize.BDelete;
                    DecentralizeToUpdate.BAccess = Decentralize.BAccess;
                    DecentralizeToUpdate.BView = Decentralize.BView;

                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }


        public bool deleteCurrentDecentralize(DecentralizeModel Decentralize)
        {
            try
            {
                var DecentralizeToDelete = _Context.DecentralizeModels.SingleOrDefault
                                      (x => x.StrStaffTypeID == Decentralize.StrStaffTypeID);
                _Context.DecentralizeModels.Remove(DecentralizeToDelete);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
