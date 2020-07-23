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
    public class StaffTypeViewModel : INotifyPropertyChanged , IStaffType
    {
        #region by Phuoc
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<StaffTypeModel> loadStaffType()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.StaffTypeModels.AsEnumerable()
                              select new StaffTypeModel
                              {
                                  StrStaffTypeID = x.StrStaffTypeID,
                                  StrStaffTypeName = x.StrStaffTypeName 
                              }).ToList();
                return new BindingList<StaffTypeModel>(Result);
            }
        }

        private string _getByIDMaxStaffType()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.StaffTypeModels.OrderByDescending(c => c.StrStaffTypeID).Select(c => c.StrStaffTypeID);
                var Result = query.First();
                return Result;
            }
        }
        public string getStaffTypeName(string StaffTypeID)
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.StaffTypeModels.Where(x => x.StrStaffTypeID == StaffTypeID).Select(x => x.StrStaffTypeName).SingleOrDefault();
                return Result;
            }
        }

        public string getByIDAutoStaffType()
        {
            string _StrIDMax = _getByIDMaxStaffType();

            return _StrIDMax;
        }
        public List<string> lstStaffTypeID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.StaffTypeModels.Select(c => c.StrStaffTypeID).ToList();
                return Result;
            }
        }

        //public bool addNewStaffType(StaffTypeModel staffType)
        //{
        //    try
        //    {
                
        //        _Context.StaffTypeModels.Add(staffType);
        //        DecentralizeModel staff = new DecentralizeModel();
        //        foreach (FormModel x in _Context.FormModels )
        //        {
        //            staff.StrStaffTypeID = staffType.StrStaffTypeID;
        //            staff.BView = true;
        //            staff.BAdd = false;
        //            staff.BDelete = false;
        //            staff.BDelete = false;
        //            staff.BFullFuncion = false;
        //            staff.BAccess = false;
        //            staff.StrFormID = x.StrFormID;
        //            _Context.DecentralizeModels.Add(staff);
        //        }
                
        //        return (_Context.SaveChanges() != 0);
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}

        public bool addStaffTypeNew(StaffTypeModel staffType)
        {
            try
            {
                _Context.StaffTypeModels.Add(staffType);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }

        }
        public bool updateCurrentStaffType(StaffTypeModel staffType)
        {
            try
            {
                var StaffTypeToUpdate = _Context.StaffTypeModels.SingleOrDefault
                    (x => x.StrStaffTypeID == staffType.StrStaffTypeID);
                if (StaffTypeToUpdate != null)
                {
                    StaffTypeToUpdate.StrStaffTypeName = staffType.StrStaffTypeName;
                    return (_Context.SaveChanges() != 0);
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCurrentStaffType(StaffTypeModel staffType)
        {
            try
            {
                var StaffTypeToDelete = _Context.StaffTypeModels.SingleOrDefault
                      (x => x.StrStaffTypeID == staffType.StrStaffTypeID);
                _Context.StaffTypeModels.Remove(StaffTypeToDelete);

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
