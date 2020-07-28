using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;


namespace ManageProjectStudent_Interface
{
    public interface ILanguage
    {
        BindingList<LanguageModel> loadLanguage();
        LanguageModel getLanguageSelected(string StrLanguageID);
        bool addNewLanguage(LanguageModel Language);
        bool updateCurrentLanguagef(LanguageModel Language);
        bool deleteCurrentLanguage(LanguageModel Language);

    }
}
