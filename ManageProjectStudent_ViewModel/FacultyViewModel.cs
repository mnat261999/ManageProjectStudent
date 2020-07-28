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
    public class FacultyViewModel : INotifyPropertyChanged, IFaculty
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<FacultyModel> loadFaculty()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var result = (from x in _Context.FacultyModels.AsEnumerable()
                              select new FacultyModel
                              {
                                  StrFacultyID = x.StrFacultyID,
                                  StrFacultyName = x.StrFacultyName,
                                  DtFoundedYear = x.DtFoundedYear
                              }).ToList();
                return new BindingList<FacultyModel>(result);
            }
        }

        public string getByIDMaxFaculty()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.FacultyModels.OrderByDescending(c => c.StrFacultyID).Select(c => c.StrFacultyID);
                var Result = query.First();
                return Result;
            }
        }
        public List<string> lstFacultyID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.FacultyModels.Select(c => c.StrFacultyID).ToList();
                return Result;
            }
        }

        public bool addNewFaculty(FacultyModel faculty)
        {
            try
            {
                _Context.FacultyModels.Add(faculty);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public bool updateCurrentFaculty(FacultyModel faculty)
        {
            try
            {
                var FacultyToUpdate = _Context.FacultyModels.SingleOrDefault
                 (x => x.StrFacultyID == faculty.StrFacultyID);
                if (FacultyToUpdate != null)
                {
                    FacultyToUpdate.StrFacultyName = faculty.StrFacultyName;
                    FacultyToUpdate.DtFoundedYear = faculty.DtFoundedYear;
                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false; 
            }
        }

        public bool deleteCurrentFaculty(FacultyModel faculty)
        {
            try
            {
                var FacultyToDelete = _Context.FacultyModels.SingleOrDefault
                    (x => x.StrFacultyID == faculty.StrFacultyID);
                _Context.FacultyModels.Remove(FacultyToDelete);
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

        #region Thu
        public bool _checkCharacterNumberFaculty(char _C)
        {
            return GarenaViewModel._checkCharacterNumber(_C);
        }

        public bool _checkCharacterCharFaculty(char _C)
        {
            return GarenaViewModel._checkCharacterChar(_C);
        }
        #endregion
    }
}
