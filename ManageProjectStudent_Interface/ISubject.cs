using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface ISubject
    {
        BindingList<SubjectModel> loadSubject();
        //string getByIDAutoSubject();
        bool addNewSubject(SubjectModel subject);
        bool updateCurrentSubjectf(SubjectModel subject);
        bool deleteCurrentSubject(SubjectModel subject);
        List<string> lstSubjectID();

        bool _checkCharacterNumberSubject(char _C);
    }
}
