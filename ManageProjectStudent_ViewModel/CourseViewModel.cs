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
    public class CourseViewModel : INotifyPropertyChanged, ICourse
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<CourseModel> loadCourse()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var result = (from x in _Context.CourseModels.AsEnumerable()
                              select new CourseModel
                              {
                                  StrCourseID = x.StrCourseID,
                                  DtStartYear = x.DtStartYear,
                                  DtEndYear = x.DtEndYear
                              }).ToList();
                return new BindingList<CourseModel>(result);
            }
        }

        public string getByIDMaxCourse()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.CourseModels.OrderByDescending(c => c.StrCourseID).Select(c => c.StrCourseID);
                var Result = query.First();
                return Result;
            }
        }
        public List<string> lstCourseID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.CourseModels.Select(c => c.StrCourseID).ToList();
                return Result;
            }
        }

        public bool addNewCourse(CourseModel Course)
        {
            try
            {
                _Context.CourseModels.Add(Course);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public bool updateCurrentCourse(CourseModel Course)
        {
            try
            {
                var CourseToUpdate = _Context.CourseModels.SingleOrDefault
                 (x => x.StrCourseID == Course.StrCourseID);
                if (CourseToUpdate != null)
                {
                    CourseToUpdate.DtStartYear = Course.DtStartYear;
                    CourseToUpdate.DtEndYear = Course.DtEndYear;
                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCurrentCourse(CourseModel Course)
        {
            try
            {
                var CourseToDelete = _Context.CourseModels.SingleOrDefault
                    (x => x.StrCourseID == Course.StrCourseID);
                _Context.CourseModels.Remove(CourseToDelete);
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
}
