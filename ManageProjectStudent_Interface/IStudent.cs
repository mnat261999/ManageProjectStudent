using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IStudent
    {
        BindingList<StudentModel> loadStudent();
        string getByIDMaxStudent();
        bool addNewStudent(StudentModel student);
        bool updateCurrentStudent(StudentModel student);
        bool deleteCurrentStudent(StudentModel student);
        List<string> lstStudentID();
        StudentModel getStudentSelected(string StrStudentID);
        bool checkCardID(string CardID);
        bool checkStudentID(string StudentID);
        bool _checkCharacterNumberStudent(char _C);
        bool _checkCharacterCharStudent(char _C);
    }
}
