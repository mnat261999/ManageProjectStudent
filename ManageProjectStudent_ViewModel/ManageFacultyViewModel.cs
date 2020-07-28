using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Interface;
using System.Windows.Forms;

namespace ManageProjectStudent_ViewModel
{
    public class ManageFacultyViewModel : IManageFaculty
    {
        #region Event
        public void txtIDFaculty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GarenaViewModel._checkCharacterNumber(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
