using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IProject
    {
        BindingList<ProjectModel> loadProject();
        //string getByIDAutoLecturer();
        bool addNewProject(ProjectModel project);
        bool updateCurrentProject(ProjectModel project);
        bool deleteCurrentProject(ProjectModel project);
        List<string> lstProjectID();

        //front-end
        bool _checkCharacterNumberProject(char _C);
        bool _checkCharacterCharProject(char _C);
    }
}
