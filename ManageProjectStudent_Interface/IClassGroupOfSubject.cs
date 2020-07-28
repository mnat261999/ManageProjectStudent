using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;


namespace ManageProjectStudent_Interface
{
    public interface IClassGroupOfSubject
    {
        BindingList<ClassGroupOfSubject> loadClassGroupOfSubject();
        List<string> lstClassGroupOfSubjectID();
        bool addNewClassGroupOfSubject(ClassGroupOfSubject classGroupOfSubject);
        bool updateCurrentClassGroupOfSubject(ClassGroupOfSubject classGroupOfSubject);
        bool deleteCurrentClassGroupOfSubject(ClassGroupOfSubject classGroupOfSubject);
    }
}
