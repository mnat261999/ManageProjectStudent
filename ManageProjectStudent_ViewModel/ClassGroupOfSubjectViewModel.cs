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
using System.Net.Sockets;
using ManageProjectStudent_Interface;

namespace ManageProjectStudent_ViewModel
{
    #region by Phuoc
    public class ClassGroupOfSubjectViewModel : INotifyPropertyChanged, IClassGroupOfSubject
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<ClassGroupOfSubject> loadClassGroupOfSubject()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.ClassGroupOfSubjects.AsEnumerable()
                              select new ClassGroupOfSubject
                              {
                                  StrGroupID = x.StrGroupID,
                                  StrGroupName = x.StrGroupName,
                                  StrStaffID = x.StrStaffID,
                                  StrSubjectID = x.StrSubjectID
                              }).ToList();
                return new BindingList<ClassGroupOfSubject>(Result);
            }
        }

        public string getByIDMaxClassGroupOfSubject()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.ClassGroupOfSubjects.OrderByDescending(c => c.StrGroupID).Select(c => c.StrGroupID);
                var Result = query.First();
                return Result;
            }
        }

        public List<string> lstClassGroupOfSubjectID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.ClassGroupOfSubjects.Select(c => c.StrGroupID).ToList();
                return Result;
            }
        }

        public bool addNewClassGroupOfSubject(ClassGroupOfSubject classGroupOfSubject)
        {
            try
            {
                _Context.ClassGroupOfSubjects.Add(classGroupOfSubject);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public bool updateCurrentClassGroupOfSubject(ClassGroupOfSubject classGroupOfSubject)
        {
            try
            {
                var ClassGroupOfSubjectToUpdate = _Context.ClassGroupOfSubjects.SingleOrDefault
                   (x => x.StrGroupID == classGroupOfSubject.StrGroupID);
                if (ClassGroupOfSubjectToUpdate != null)
                {
                    ClassGroupOfSubjectToUpdate.StrGroupName = classGroupOfSubject.StrGroupName;
                    ClassGroupOfSubjectToUpdate.StrStaffID = classGroupOfSubject.StrStaffID;
                    ClassGroupOfSubjectToUpdate.StrSubjectID = classGroupOfSubject.StrSubjectID;
                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCurrentClassGroupOfSubject(ClassGroupOfSubject classGroupOfSubject)
        {
            var ClassGroupOfSubjectToDelete = _Context.ClassGroupOfSubjects.SingleOrDefault
                    (x => x.StrGroupID == classGroupOfSubject.StrGroupID);
            try
            {
                _Context.ClassGroupOfSubjects.Remove(ClassGroupOfSubjectToDelete);
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

    }
    #endregion
}
