using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProjectStudent_Interface
{
    public interface ISubmitProject
    {
        // Thong
        void txtName_KeyPress(object sender, KeyPressEventArgs e);
        void txtAuthor_KeyPress(object sender, KeyPressEventArgs e);
        //Thong
    }
}
