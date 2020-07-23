using ManageProjectStudent_Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Interface;

namespace ManageProjectStudent_ViewModel
{
    public class StudentViewModel : INotifyPropertyChanged, IStudent
    {
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();
        public  BindingList<StudentModel> loadStudent()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.StudentModels.AsEnumerable()
                              select  new StudentModel
                              { 
                                  StrStudentID = x.StrStudentID,
                                  StrStudentName = x.StrStudentName,
                                  StrAddress = x.StrAddress,
                                  StrEmail = x.StrEmail,
                                  StrPhone = x.StrPhone,
                                  StrSex = x.StrSex,
                                  DtBirthDay = x.DtBirthDay,
                                  BStatus = x.BStatus,
                                  StrCardID = x.StrCardID,
                                  DtStartYear = x.DtStartYear,
                                  StrFacultyID = x.StrFacultyID,
                                  StrClassID = x.StrClassID
                              }).ToList();
                return new BindingList<StudentModel>(Result);
            }
        }
        public List<string> loadTask(StudentModel student)
        {
            var projectResult = _Context.ResultProjectModels.SingleOrDefault
                   (x => x.StrStudentID == student.StrStudentID);
            var project = _Context.ProjectModels.SingleOrDefault(x => x.StrProjectID == projectResult.StrProjectID);
            var projectTask = _Context.ProjectTaskModels.SingleOrDefault(x => x.StrProjectID == project.StrProjectID);
            var Result = _Context.ProjectTaskModels.Select(x => projectTask.StrProjectID).ToList();
            return Result;
        }
    
        public StudentModel getStudentSelected(string StrStudentID)
        {
            var Student = _Context.StudentModels.SingleOrDefault
                   (x => x.StrStudentID == StrStudentID);
            return Student;
        }
        public string getByIDMaxStudent()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var query = _Context.StudentModels.OrderByDescending(c => c.StrStudentID).Select(c=>c.StrStudentID);
                var Result = query.First();
                return Result;
            }
        }
    
        public bool addNewStudent(StudentModel student)
        {
            try
            {
                _Context.StudentModels.Add(student);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }
        public List<string> lstStudentID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.StudentModels.Select(c => c.StrStudentID).ToList();
                return Result;
            }
        }
        public bool checkCardID(string CardID)
        {
            var Result = _Context.StudentModels.SingleOrDefault(c => c.StrCardID == CardID);
            if (Result != null)
            {
                return true;
            }
            return false;
        }
        public bool checkStudentID(string StudentID)
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.StudentModels.SingleOrDefault(c => c.StrStudentID == StudentID);
                if (Result != null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool updateCurrentStudent(StudentModel student)
        {
            try
            {
                var StudentToUpdate = _Context.StudentModels.SingleOrDefault
                 (x => x.StrStudentID == student.StrStudentID);
                if (StudentToUpdate != null)
                {
                    StudentToUpdate.StrStudentName = student.StrStudentName;
                    StudentToUpdate.StrAddress = student.StrAddress;
                    StudentToUpdate.StrEmail = student.StrEmail;
                    StudentToUpdate.DtBirthDay = student.DtBirthDay;
                    StudentToUpdate.DtStartYear = student.DtStartYear;
                    StudentToUpdate.StrCardID = student.StrCardID;
                    StudentToUpdate.StrFacultyID = student.StrFacultyID;
                    StudentToUpdate.StrClassID = student.StrClassID;
                    StudentToUpdate.BStatus = student.BStatus;
                    StudentToUpdate.StrPhone = student.StrPhone;
                    StudentToUpdate.StrSex = student.StrSex;

                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCurrentStudent(StudentModel student)
        {
            try
            {
                var StudentToDelete = _Context.StudentModels.SingleOrDefault
                    (x => x.StrStudentID == student.StrStudentID);
                _Context.StudentModels.Remove(StudentToDelete);

                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool _checkCharacterNumberStudent(char _C)
        {
            return GarenaViewModel._checkCharacterNumber(_C);
        }

        public bool _checkCharacterCharStudent(char _C)
        {
            return GarenaViewModel._checkCharacterChar(_C);
        }
    }
}
