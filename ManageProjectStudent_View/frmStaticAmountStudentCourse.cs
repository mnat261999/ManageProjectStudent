using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProjectStudent_View
{
    public partial class frmStaticAmountStudentCourse : Form
    {
        public frmStaticAmountStudentCourse()
        {
            InitializeComponent();
        }

        private void frmStaticAmountStudentCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBManageProjectStudentDataSet.AmoutStudentofCourse' table. You can move, or remove it, as needed.
            this.amoutStudentofCourseTableAdapter.Fill(this.dBManageProjectStudentDataSet.AmoutStudentofCourse);

        }
    }
}
