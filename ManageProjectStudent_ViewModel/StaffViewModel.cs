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
    public class StaffViewModel : INotifyPropertyChanged, IStaff
    {
        #region by Phuoc
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<StaffModel> loadStaff()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.StaffModels.AsEnumerable()
                              select new StaffModel
                              {
                                  StrStaffID = x.StrStaffID,
                                  StrStaffName = x.StrStaffName,
                                  StrEmail = x.StrEmail,
                                  StrAddress = x.StrAddress,
                                  StrPhone = x.StrPhone,
                                  StrSex = x.StrSex,
                                  BStatus = x.BStatus,
                                  DtBirthDay = x.DtBirthDay,
                                  StrFacultyID = x.StrFacultyID,
                                  StrStaffTypeID = x.StrStaffTypeID,
                                  StrCardID = x.StrCardID
                              }).ToList();
                return new BindingList<StaffModel>(Result);
            }
        }

        private string _getByIDMaxLecturer()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.StaffModels.OrderByDescending(c => c.StrStaffID).Select(c => c.StrStaffID);
                var Result = query.First();
                return Result;
            }
        }
        public StaffModel getStaffSelected(string StrStaffID)
        {
            var Staff = _Context.StaffModels.SingleOrDefault
                   (x => x.StrStaffID == StrStaffID);
            return Staff;
        }
        public string getByIDAutoLecturer()
        {
            string _StrIDMax = _getByIDMaxLecturer();

            return _StrIDMax;
        }
        public List<string> lstStaffID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.StaffModels.Select(c => c.StrStaffID).ToList();
                return Result;
            }
        }

        public bool checkStaffID(string StaffID)
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.StaffModels.SingleOrDefault(c => c.StrStaffID == StaffID);
                if (Result != null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool checkCardID(string CardID)
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.StaffModels.SingleOrDefault(c => c.StrCardID == CardID);
                if (Result != null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool addNewStaff(StaffModel staff)
        {
            try
            {
                _Context.StaffModels.Add(staff);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
         
        }

        public bool updateCurrentStaff(StaffModel staff)
        {
            try
            {
                var StaffToUpdate = _Context.StaffModels.SingleOrDefault
                    (x => x.StrStaffID == staff.StrStaffID);
                if (StaffToUpdate != null)
                {
                    StaffToUpdate.StrStaffName = staff.StrStaffName;
                    StaffToUpdate.StrAddress = staff.StrAddress;
                    StaffToUpdate.StrEmail = staff.StrEmail;
                    StaffToUpdate.StrPhone = staff.StrPhone;
                    StaffToUpdate.DtBirthDay = staff.DtBirthDay;
                    StaffToUpdate.StrCardID = staff.StrCardID;
                    StaffToUpdate.StrFacultyID = staff.StrFacultyID;
                    StaffToUpdate.StrStaffTypeID = staff.StrStaffTypeID;
                    StaffToUpdate.BStatus = staff.BStatus;
                    StaffToUpdate.StrSex = staff.StrSex;

                    return (_Context.SaveChanges() != 0);
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCurrentStaff(StaffModel staff)
        {
            try
            {
                var staffToDelete = _Context.StaffModels.SingleOrDefault
                      (x => x.StrStaffID == staff.StrStaffID);
                _Context.StaffModels.Remove(staffToDelete);

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

        public bool _checkCharacterNumberStaff(char _C)
        {
            return GarenaViewModel._checkCharacterNumber(_C);
        }

        public bool _checkCharacterCharStaff(char _C)
        {
            return GarenaViewModel._checkCharacterChar(_C);
        }
        #endregion
    }
}
