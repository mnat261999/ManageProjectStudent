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
    public class ProjectViewModel : INotifyPropertyChanged , IProject
    {
        #region by Phuoc
        public readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();
        public BindingList<ProjectModel> loadProject()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var result = (from x in _Context.ProjectModels.AsEnumerable()
                              select new ProjectModel
                              {
                                  StrProjectID = x.StrProjectID,
                                  StrProjectName = x.StrProjectName,
                                  DtStartDay = x.DtStartDay,
                                  DtEndDay = x.DtEndDay,
                                  StrStaffID = x.StrStaffID,
                                  StrSubjectID = x.StrSubjectID
                              }).ToList();
                return new BindingList<ProjectModel>(result);
            }
        }

        public string getByIDMaxProject()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.ProjectModels.OrderByDescending(c => c.StrProjectID).Select(c => c.StrProjectID);
                var Result = query.First();
                return Result;
            }
        }
        public List<string> lstProjectID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.ProjectModels.Select(c => c.StrProjectID).ToList();
                return Result;
            }
        }
        public bool addNewProject(ProjectModel project)
        {
            try
            {
                _Context.ProjectModels.Add(project);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public bool updateCurrentProject(ProjectModel project)
        {
            try
            {
                var ProjectToUpdate = _Context.ProjectModels.SingleOrDefault
                    (x => x.StrProjectID == project.StrProjectID);
                if (ProjectToUpdate != null)
                {
                    ProjectToUpdate.StrProjectID = project.StrProjectID;
                    ProjectToUpdate.StrProjectName = project.StrProjectName;
                    ProjectToUpdate.DtStartDay = project.DtStartDay;
                    ProjectToUpdate.DtEndDay = project.DtEndDay;
                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCurrentProject(ProjectModel project)
        {
            try
            {
                var ProjectToDelete = _Context.ProjectModels.SingleOrDefault
                   (x => x.StrProjectID == project.StrProjectID);
                _Context.ProjectModels.Remove(ProjectToDelete);
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

        public bool _checkCharacterNumberProject(char _C)
        {
            return GarenaViewModel._checkCharacterNumber(_C);
        }

        public bool _checkCharacterCharProject(char _C)
        {
            return GarenaViewModel._checkCharacterChar(_C);
        }
        #endregion
    }
}
