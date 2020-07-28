using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IWord
    {
        BindingList<WordModel> loadWord();
        WordModel getWordSelected(string StrWordID);
        bool addNewWord(WordModel Word);
        bool updateCurrentWordf(WordModel Word);
        bool deleteCurrentWord(WordModel Word);

    }
}
