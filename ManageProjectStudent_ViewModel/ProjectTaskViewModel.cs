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
    public class ProjectTaskViewModel : INotifyPropertyChanged, IProjectTask
    {
        #region by Phuoc
        public readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<ProjectTaskModel> loadProjectTask()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.ProjectTaskModels.AsEnumerable()
                              select new ProjectTaskModel
                              {
                                  StrProjectID = x.StrProjectID,
                                  StrTaskID = x.StrTaskID,
                                  StrTaskName = x.StrTaskName,
                                  DtStartDay = x.DtStartDay,
                                  DtEndDay = x.DtEndDay,
                                  StrFileName = x.StrFileName,
                                  StrLinkFile = x.StrLinkFile
                              }).ToList();
                return new BindingList<ProjectTaskModel>(Result);
            }
        }

        public string getByIDMaxProjectTask()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.ProjectTaskModels.OrderByDescending(c => c.StrTaskID).Select(c => c.StrTaskID);
                var Result = query.First();
                return Result;
            }
        }
        public BindingList<ProjectTaskModel> getListProjectTaskForStudent(string StrStudentID)
        {
            var query = _Context.ResultProjectModels.Where(x => x.StrStudentID == StrStudentID).Select(x => x.StrProjectID).ToList();
            BindingList<ProjectTaskModel> Result = new BindingList<ProjectTaskModel>();
            foreach (string ProjectID in query)
            {
                var query1 = _Context.ProjectTaskModels.Where(x => x.StrProjectID == ProjectID).ToList();
                foreach (ProjectTaskModel x in query1)
                {
                    Result.Add(x);
                }
            }
            return Result;
        }

        public BindingList<ProjectTaskModel> getListProjectTaskForStaff(string StrStaffID)
        {
            var query = _Context.ProjectModels.Where(x => x.StrStaffID == StrStaffID).Select(x => x.StrProjectID).ToList();
            BindingList<ProjectTaskModel> Result = new BindingList<ProjectTaskModel>();
            foreach (string ProjectID in query)
            {
                var query1 = _Context.ProjectTaskModels.Where(x => x.StrProjectID == ProjectID).ToList();
                foreach (ProjectTaskModel x in query1)
                {
                    Result.Add(x);
                }
            }
            return Result;
        }

        public List<string> lstProjectTaskID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.ProjectTaskModels.Select(c => c.StrTaskID).ToList();
                return Result;
            }
        }
        public bool addLinkFile(ProjectTaskModel projectTask)
        {
             try
            {
                var ProjectTaskToUpdate = _Context.ProjectTaskModels.SingleOrDefault
                    (x => x.StrTaskID == projectTask.StrTaskID);
                if (ProjectTaskToUpdate != null)
                {
                    ProjectTaskToUpdate.StrFileName = projectTask.StrFileName;
                    ProjectTaskToUpdate.StrLinkFile = projectTask.StrLinkFile;               
                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool addNewProjectTask(ProjectTaskModel projectTask)
        {
            try
            {
                _Context.ProjectTaskModels.Add(projectTask);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public bool updateCurrentProjectTask(ProjectTaskModel projectTask)
        {
            try
            {
                var ProjectTaskToUpdate = _Context.ProjectTaskModels.SingleOrDefault
                    (x => x.StrTaskID == projectTask.StrTaskID);
                if (ProjectTaskToUpdate != null)
                {
                    ProjectTaskToUpdate.StrProjectID = projectTask.StrProjectID;
                    ProjectTaskToUpdate.StrTaskName = projectTask.StrTaskName;
                    ProjectTaskToUpdate.DtStartDay = projectTask.DtStartDay;
                    ProjectTaskToUpdate.DtEndDay = projectTask.DtEndDay;
                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCurrentProjectTask(ProjectTaskModel projectTask)
        {
            try
            {
                var ProjectTaskToDelete = _Context.ProjectTaskModels.SingleOrDefault
                   (x => x.StrTaskID == projectTask.StrTaskID);
                _Context.ProjectTaskModels.Remove(ProjectTaskToDelete);
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
