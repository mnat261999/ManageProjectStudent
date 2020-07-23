using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Course")]
    public class CourseModel
    {
        private string _StrCourseID;
        private DateTime _DtStartYear;
        private DateTime _DtEndYear;

        [Key]
        [Column("CourseID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrCourseID { get => _StrCourseID; set => _StrCourseID = value; }

        [Column("StartYear", TypeName = "Date" , Order = 1)]
        public DateTime DtStartYear { get => _DtStartYear; set => _DtStartYear = value; }

        [Column("EndYear", TypeName = "Date", Order = 2)]
        public DateTime DtEndYear { get => _DtEndYear; set => _DtEndYear = value; }

        // Tao moi quan he
        public ICollection<ClassModel> ClassModels { get; set; }

        public CourseModel()
        {
            this.ClassModels = new HashSet<ClassModel>();
        }

    }
}
