using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageProjectStudent_Interface;

namespace ManageProjectStudent_ViewModel
{
    public class AddGroupForSubjectViewModel : IAddGroupForSubject
    {
        // Thong
        public void txtIDGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!GarenaViewModel._checkCharacterChar(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự số, chỉ được nhập chữ.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void txtGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!GarenaViewModel._checkCharacterChar(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự số, chỉ được nhập chữ.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Thong
    }
}
