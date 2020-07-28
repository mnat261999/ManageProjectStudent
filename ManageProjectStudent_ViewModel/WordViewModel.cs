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
    public class WordViewModel : INotifyPropertyChanged, IWord
    {
        #region by Phuoc
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<WordModel> loadWord()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.WordModels.AsEnumerable()
                              select new WordModel
                              {
                                  StrWordId = x.StrWordId,
                                  StrWordName = x.StrWordName,
                                  StrModule = x.StrModule,
                              }).ToList();
                return new BindingList<WordModel>(Result);
            }
        }
        public WordModel getWordSelected(string StrWordID)
        {
            var Word = _Context.WordModels.SingleOrDefault
                   (x => x.StrWordId == StrWordID);
            return Word;
        }
        public bool addNewWord(WordModel Word)
        {
            try
            {
                _Context.WordModels.Add(Word);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public bool updateCurrentWordf(WordModel Word)
        {
            try
            {
                var WordToUpdate = _Context.WordModels.SingleOrDefault
                 (x => x.StrWordId == Word.StrWordId);
                if (WordToUpdate != null)
                {
                    WordToUpdate.StrWordName = Word.StrWordName;
                    WordToUpdate.StrModule = Word.StrModule;

                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCurrentWord(WordModel Word)
        {
            try
            {
                var WordToDelete = _Context.WordModels.SingleOrDefault
                                      (x => x.StrWordId == Word.StrWordId);
                _Context.WordModels.Remove(WordToDelete);
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
