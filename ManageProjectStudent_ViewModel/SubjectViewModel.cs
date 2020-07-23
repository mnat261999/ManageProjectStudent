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
    public class SubjectViewModel : INotifyPropertyChanged, ISubject
    {
        #region by Phuoc
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<SubjectModel> loadSubject()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.SubjectModels.AsEnumerable()
                              select new SubjectModel
                              {
                                  StrSubjectID = x.StrSubjectID,
                                  StrSubjectName = x.StrSubjectName,
                                  StrFacultyID = x.StrFacultyID,
                                  DtStartDay = x.DtStartDay,
                                  DtEndDay = x.DtEndDay
                              }).ToList();
                return new BindingList<SubjectModel>(Result);
            }
        }
        public string getByIDMaxSubject()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.SubjectModels.OrderByDescending(c => c.StrSubjectID).Select(c => c.StrSubjectID);
                var Result = query.First();
                return Result;
            }
        }

        public List<string> lstSubjectID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.SubjectModels.Select(c => c.StrSubjectID).ToList();
                return Result;
            }
        }
        public bool addNewSubject(SubjectModel Subject)
        {
            try
            {
                _Context.SubjectModels.Add(Subject);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public bool updateCurrentSubjectf(SubjectModel Subject)
        {
            try
            {
                var SubjectToUpdate = _Context.SubjectModels.SingleOrDefault
                 (x => x.StrSubjectID == Subject.StrSubjectID);
                if (SubjectToUpdate != null)
                {
                    SubjectToUpdate.StrSubjectName = Subject.StrSubjectName;
                    SubjectToUpdate.StrFacultyID = Subject.StrFacultyID;
                    SubjectToUpdate.DtStartDay = Subject.DtStartDay;
                    SubjectToUpdate.DtEndDay = Subject.DtEndDay;

                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCurrentSubject(SubjectModel Subject)
        {
            try
            {
                var SubjectToDelete = _Context.SubjectModels.SingleOrDefault
                                      (x => x.StrSubjectID == Subject.StrSubjectID);
                _Context.SubjectModels.Remove(SubjectToDelete);
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

        public bool _checkCharacterNumberSubject(char _C)
        {
            return GarenaViewModel._checkCharacterNumber(_C);
        }
        #endregion
    }
}
