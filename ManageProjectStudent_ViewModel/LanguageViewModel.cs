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
    public class LanguageViewModel : INotifyPropertyChanged, ILanguage
    {
        #region by Phuoc
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<LanguageModel> loadLanguage()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.LanguageModels.AsEnumerable()
                              select new LanguageModel
                              {
                                  StrLanguageID = x.StrLanguageID,
                                  StrLanguageName = x.StrLanguageName,
                                  BDefault = x.BDefault,
                                  BStatus = x.BStatus
                              }).ToList();
                return new BindingList<LanguageModel>(Result);
            }
        }
        public LanguageModel getLanguageSelected(string StrLanguageID)
        {
            var Language = _Context.LanguageModels.SingleOrDefault
                   (x => x.StrLanguageID == StrLanguageID);
            return Language;
        }
        public bool addNewLanguage(LanguageModel Language)
        {
            try
            {
                _Context.LanguageModels.Add(Language);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public bool updateCurrentLanguagef(LanguageModel Language)
        {
            try
            {
                var LanguageToUpdate = _Context.LanguageModels.SingleOrDefault
                 (x => x.StrLanguageID == Language.StrLanguageID);
                if (LanguageToUpdate != null)
                {
                    LanguageToUpdate.StrLanguageName = Language.StrLanguageName;
                    LanguageToUpdate.BDefault = Language.BDefault;
                    LanguageToUpdate.BStatus = Language.BStatus;

                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCurrentLanguage(LanguageModel Language)
        {
            try
            {
                var LanguageToDelete = _Context.LanguageModels.SingleOrDefault
                                      (x => x.StrLanguageID == Language.StrLanguageID);
                _Context.LanguageModels.Remove(LanguageToDelete);
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
