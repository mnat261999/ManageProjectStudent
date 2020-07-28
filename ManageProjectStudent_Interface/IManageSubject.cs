using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProjectStudent_Interface
{
   public interface IManageSubject
    {
        void txtIDCourse_KeyPress(object sender, KeyPressEventArgs e);
        void txtNameCourse_KeyPress(object sender, KeyPressEventArgs e);
    }
}
