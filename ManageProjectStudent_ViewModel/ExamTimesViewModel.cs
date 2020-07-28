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
    public class ExamTimesViewModel : INotifyPropertyChanged, IExamTimes
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<ExamTimesModel> loadExamTimes()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.ExamTimesModels.AsEnumerable()
                              select new ExamTimesModel
                              {
                                  StrExamTimesID = x.StrExamTimesID,
                                  ITimes = x.ITimes,
                                  DtExamTime = x.DtExamTime
                              }).ToList();
                return new BindingList<ExamTimesModel>(Result);
            }
        }
        public string getByIDMaxExamTimes()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.ExamTimesModels.OrderByDescending(c => c.StrExamTimesID).Select(c => c.StrExamTimesID);
                var Result = query.First();
                return Result;
            }
        }

        public List<string> lstExamTimesID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.ExamTimesModels.Select(c => c.StrExamTimesID).ToList();
                return Result;
            }
        }
        public bool addNewExamTimes(ExamTimesModel examTimes)
        {
            try
            {
                _Context.ExamTimesModels.Add(examTimes);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }
        public bool updateCurrentExamTimes(ExamTimesModel examTimes)
        {
            try
            {
                var ExamTimesToUpdate = _Context.ExamTimesModels.SingleOrDefault
                   (x => x.StrExamTimesID == examTimes.StrExamTimesID);
                if (ExamTimesToUpdate != null)
                {
                    ExamTimesToUpdate.StrExamTimesID = examTimes.StrExamTimesID;
                    ExamTimesToUpdate.ITimes = examTimes.ITimes;
                    ExamTimesToUpdate.DtExamTime = examTimes.DtExamTime;
                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteCurrentExamTimes(ExamTimesModel examTimes)
        {
            var ExamTimesToDelete = _Context.ExamTimesModels.SingleOrDefault
                    (x => x.StrExamTimesID == examTimes.StrExamTimesID);
            try
            {
                _Context.ExamTimesModels.Remove(ExamTimesToDelete);
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
