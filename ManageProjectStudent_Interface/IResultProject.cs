using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IResultProject
    {
        BindingList<ResultProjectModel> loadResultProject();
        bool addNewResultProject(ResultProjectModel ResultProject);
        bool updateCurrentResultProject(ResultProjectModel ResultProject);
        bool deleteCurrentResultProject(ResultProjectModel ResultProject);
    }
}
