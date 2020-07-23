using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IExamTimes
    {
        BindingList<ExamTimesModel> loadExamTimes();
        string getByIDMaxExamTimes();
        List<string> lstExamTimesID();
        bool addNewExamTimes(ExamTimesModel examTimes);
        bool updateCurrentExamTimes(ExamTimesModel examTimes);
        bool deleteCurrentExamTimes(ExamTimesModel examTimes);
    }
}
