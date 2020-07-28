using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProjectStudent_Interface
{
    public interface IManageClass
    {
        void txtClassName_KeyPress(object sender, KeyPressEventArgs e);
        void txtIDClass_KeyPress(object sender, KeyPressEventArgs e);
    }
}
