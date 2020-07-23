using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProjectStudent_Interface
{
    public interface IAddGroupForSubject
    {
        // Thong
        void txtIDGroup_KeyPress(object sender, KeyPressEventArgs e);
        void txtGroupName_KeyPress(object sender, KeyPressEventArgs e);
        // Thong
    }
}
