using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IFaculty
    {
        BindingList<FacultyModel> loadFaculty();
        //string getByIDAutoFaculty();
        bool addNewFaculty(FacultyModel faculty);
        bool updateCurrentFaculty(FacultyModel faculty);
        bool deleteCurrentFaculty(FacultyModel faculty);
        List<string> lstFacultyID();

        //front-end
        bool _checkCharacterNumberFaculty(char _C);
        bool _checkCharacterCharFaculty(char _C);
    }
}
