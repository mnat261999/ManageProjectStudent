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
    public class FormViewModel : INotifyPropertyChanged,IForm
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<FormModel> loadForm()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.FormModels.AsEnumerable()
                              select new FormModel
                              {
                                  StrFormID = x.StrFormID,
                                  StrFormName = x.StrFormName
                              }).ToList();
                return new BindingList<FormModel>(Result);
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
