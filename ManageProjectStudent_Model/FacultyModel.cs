using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Faculty")]
    public class FacultyModel
    {
        private string _StrFacultyID;
        private string _StrFacultyName;
        private DateTime _DtFoundedYear;

        [Key]
        [Column("FacultyID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrFacultyID { get => _StrFacultyID; set => _StrFacultyID = value; }

        [Column("FacultyName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrFacultyName { get => _StrFacultyName; set => _StrFacultyName = value; }

        [Column("FoundedYear", TypeName = "Date", Order = 2)]
        public DateTime DtFoundedYear { get => _DtFoundedYear; set => _DtFoundedYear = value; }

        // Tao moi quan he
        public ICollection<StaffModel> StaffModels { get; set; }
        public ICollection<SubjectAssignmentModel> SubjectAssignmentModels { get; set; }
        public ICollection<ClassModel> ClassModels { get; set; }
        public ICollection<StudentModel> StudentModels { get; set; }

        public FacultyModel()
        {
            this.StaffModels = new HashSet<StaffModel>();
            this.SubjectAssignmentModels = new HashSet<SubjectAssignmentModel>();
            this.ClassModels = new HashSet<ClassModel>();
            this.StudentModels = new HashSet<StudentModel>();
        }

    }
}
