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
    public class ClassViewModel : INotifyPropertyChanged, IClass
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<ClassModel> loadClass()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.ClassModels.AsEnumerable()
                              select new ClassModel
                              {
                                  StrClassID = x.StrClassID,
                                  StrClassName = x.StrClassName,
                                  StrFacultyID = x.StrFacultyID,
                                  StrCourseID = x.StrCourseID
                              }).ToList();
                return new BindingList<ClassModel>(Result);
            }
        }
        public string getByIDMaxClass()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.ClassModels.OrderByDescending(c => c.StrClassID).Select(c => c.StrClassID);
                var Result = query.First();
                return Result;
            }
        }
        public List<string> lstClassID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.ClassModels.Select(c => c.StrClassID).ToList();
                return Result;
            }
        }
        public BindingList<ClassModel> getListClass(string StrFaculty)
        {
            var Class = _Context.ClassModels.Where
                   (x => x.StrFacultyID == StrFaculty).ToList();
            return new BindingList<ClassModel>(Class);
        }
        public bool addNewClass(ClassModel classModel)
        {
            try
            {
                _Context.ClassModels.Add(classModel);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }
        public bool updateCurrentClass(ClassModel classModel)
        {
            try
            {
                var ClassToUpdate = _Context.ClassModels.SingleOrDefault
                   (x => x.StrClassID == classModel.StrClassID);
                if (ClassToUpdate != null)
                {
                    ClassToUpdate.StrClassName = classModel.StrClassName;
                    ClassToUpdate.StrFacultyID = classModel.StrFacultyID;
                    ClassToUpdate.StrCourseID = classModel.StrCourseID;

                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteCurrentClass(ClassModel classModel)
        {
            var ClassToDelete = _Context.ClassModels.SingleOrDefault
                    (x => x.StrClassID == classModel.StrClassID);
            try
            {
                _Context.ClassModels.Remove(ClassToDelete);
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

        public bool _checkCharacterNumberClass(char _C)
        {
            return GarenaViewModel._checkCharacterNumber(_C);
        }
        public bool _checkCharacterCharClass(char _C)
        {
            return GarenaViewModel._checkCharacterChar(_C);
        }
    }
    #endregion
}
