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
    public class ResultProjectViewModel : INotifyPropertyChanged, IResultProject
    {
        #region by Phuoc
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<ResultProjectModel> loadResultProject()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.ResultProjectModels.AsEnumerable()
                              select new ResultProjectModel
                              {
                                  StrStudentID = x.StrStudentID,
                                  StrProjectID = x.StrProjectID,
                                  DGrade = x.DGrade
                              }).ToList();
                return new BindingList<ResultProjectModel>(Result);
            }
        }

        public bool addNewResultProject(ResultProjectModel ResultProject)
        {
            try
            {
                _Context.ResultProjectModels.Add(ResultProject);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }
        public bool updateCurrentResultProject(ResultProjectModel ResultProject)
        {
            try
            {
                var ResultProjectToUpdate = _Context.ResultProjectModels.SingleOrDefault
                   (x => x.StrProjectID == ResultProject.StrProjectID);
                if (ResultProjectToUpdate != null)
                {
                    ResultProjectToUpdate.StrStudentID = ResultProject.StrStudentID;
                    ResultProjectToUpdate.DGrade = ResultProject.DGrade;
                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteCurrentResultProject(ResultProjectModel ResultProject)
        {
            var ResultProjectToDelete = _Context.ResultProjectModels.SingleOrDefault
                    (x => x.StrProjectID == ResultProject.StrProjectID);
            try
            {
                _Context.ResultProjectModels.Remove(ResultProjectToDelete);
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
