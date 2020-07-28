using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IExamResult
    {
        BindingList<ExamResultModel> loadExamResult();
        string getByIDMaxExamResult();
        List<string> lstExamResultID();
        bool addNewExamResult(ExamResultModel examResult);
        bool updateCurrentExamResult(ExamResultModel examResult);
        bool deleteCurrentExamResult(ExamResultModel examResult);
    }
}
