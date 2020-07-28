using ManageProjectStudent_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Interface
{
    public interface IStaffType
    {
        BindingList<StaffTypeModel> loadStaffType();
        //string getByIDAutoLecturer();
        //bool addNewStaffType(StaffTypeModel staffType);
        bool updateCurrentStaffType(StaffTypeModel staffType);
        bool deleteCurrentStaffType(StaffTypeModel staffType);
        List<string> lstStaffTypeID();
        string getStaffTypeName(string StaffTypeID);
        bool addStaffTypeNew(StaffTypeModel staffType);
    }
}
