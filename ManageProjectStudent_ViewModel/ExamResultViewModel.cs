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
    public class ExamResultViewModel : INotifyPropertyChanged, IExamResult
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<ExamResultModel> loadExamResult()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.ExamResultModels.AsEnumerable()
                              select new ExamResultModel
                              {
                                  StrExamTimesID = x.StrExamTimesID,
                                  StrStudentID = x.StrStudentID,
                                  StrSubjectID = x.StrSubjectID,
                                  DGrade = x.DGrade
                              }).ToList();
                return new BindingList<ExamResultModel>(Result);
            }
        }
        public string getByIDMaxExamResult()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.ExamResultModels.OrderByDescending(c => c.StrExamTimesID).Select(c => c.StrExamTimesID);
                var Result = query.First();
                return Result;
            }
        }

        public List<string> lstExamResultID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.ExamResultModels.Select(c => c.StrExamTimesID).ToList();
                return Result;
            }
        }
        public bool addNewExamResult(ExamResultModel examResult)
        {
            try
            {
                _Context.ExamResultModels.Add(examResult);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }
        public bool updateCurrentExamResult(ExamResultModel examResult)
        {
            try
            {
                var ExamResultToUpdate = _Context.ExamResultModels.SingleOrDefault
                   (x => x.StrExamTimesID == examResult.StrExamTimesID);
                if (ExamResultToUpdate != null)
                {
                    ExamResultToUpdate.StrStudentID = examResult.StrStudentID;
                    ExamResultToUpdate.StrSubjectID = examResult.StrSubjectID;
                    ExamResultToUpdate.DGrade = examResult.DGrade;
                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteCurrentExamResult(ExamResultModel examResult)
        {
            var ExamResultToDelete = _Context.ExamResultModels.SingleOrDefault
                    (x => x.StrExamTimesID == examResult.StrExamTimesID);
            try
            {
                _Context.ExamResultModels.Remove(ExamResultToDelete);
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
