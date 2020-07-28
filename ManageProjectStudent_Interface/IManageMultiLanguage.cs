using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProjectStudent_Interface
{
   public interface IManageMultiLanguage
    {
        // Thong
        void txtIDLanguage_KeyPress(object sender, KeyPressEventArgs e);
        void txtLanguageName_KeyPress(object sender, KeyPressEventArgs e);
        void txtKeyword_KeyPress(object sender, KeyPressEventArgs e);
        // Thong
    }
}
