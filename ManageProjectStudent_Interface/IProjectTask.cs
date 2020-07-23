using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IProjectTask
    {
        BindingList<ProjectTaskModel> loadProjectTask();
        string getByIDMaxProjectTask();
        List<string> lstProjectTaskID();
        bool addNewProjectTask(ProjectTaskModel ProjectTask);
        bool updateCurrentProjectTask(ProjectTaskModel ProjectTask);
        bool deleteCurrentProjectTask(ProjectTaskModel ProjectTask);
        bool addLinkFile(ProjectTaskModel projectTask);
        BindingList<ProjectTaskModel> getListProjectTaskForStudent(string StrStudentID);
        BindingList<ProjectTaskModel> getListProjectTaskForStaff(string StrStaffID);
    }
}