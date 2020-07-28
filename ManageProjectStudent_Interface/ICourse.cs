using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface ICourse
    {
        BindingList<CourseModel> loadCourse();
        bool addNewCourse(CourseModel Course);
        bool updateCurrentCourse(CourseModel Course);
        bool deleteCurrentCourse(CourseModel Course);
        List<string> lstCourseID();
    }
}
