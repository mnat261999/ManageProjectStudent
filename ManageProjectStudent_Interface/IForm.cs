using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;


namespace ManageProjectStudent_Interface
{
    public interface IForm
    {
        BindingList<FormModel> loadForm();
    }
}
