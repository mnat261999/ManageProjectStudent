using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IClass
    {
        BindingList<ClassModel> loadClass();
        // string getByIDAutoClass();
        bool addNewClass(ClassModel classModel);
        bool updateCurrentClass(ClassModel classModel);
        bool deleteCurrentClass(ClassModel classModel);
        List<string> lstClassID();

        //front-end
        bool _checkCharacterNumberClass(char _C);
        bool _checkCharacterCharClass(char _C);
    }
}
