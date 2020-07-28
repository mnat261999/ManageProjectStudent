using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IStaff
    {
        BindingList<StaffModel> loadStaff();
        string getByIDAutoLecturer();
        bool addNewStaff(StaffModel staff);
        bool updateCurrentStaff(StaffModel staff);
        bool deleteCurrentStaff(StaffModel staff);
        List<string> lstStaffID();
        bool checkCardID(string CardID);
        bool checkStaffID(string StaffID);
        StaffModel getStaffSelected(string StrStaffID);

        // Front-end
        bool _checkCharacterNumberStaff(char _C);
        bool _checkCharacterCharStaff(char _C);
        // Front-end
    }
}
