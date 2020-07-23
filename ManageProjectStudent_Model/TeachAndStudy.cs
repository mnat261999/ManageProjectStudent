using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("TeachAndStudy")]
    public class TeachAndStudy
    {
        private string _StrStaffID;
        private string _StrStudentID;
        private string _StrSubjectID;
        private string _StrSemester;
        private DateTime _DtSchoolYear;

        [Key]
        [Column("StaffID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrStaffID { get => _StrStaffID; set => _StrStaffID = value; }
        [Key]
        [Column("StudentID", TypeName = "varchar", Order = 1)]
        [StringLength(10)]
        public string StrStudentID { get => _StrStudentID; set => _StrStudentID = value; }

        [Key]
        [Column("SubjectID", TypeName = "varchar", Order = 3)]
        [StringLength(10)]
        public string StrSubjectID { get => _StrSubjectID; set => _StrSubjectID = value; }

        [Column("Semester", TypeName = "nvarchar", Order = 4)]
        [StringLength(100)]
        public string StrSemester { get => _StrSemester; set => _StrSemester = value; }

        [Column("SchoolYear", TypeName = "Date", Order = 5)]
        public DateTime DtSchoolYear { get => _DtSchoolYear; set => _DtSchoolYear = value; }

        //Khai bao khoa ngoai
        public virtual StaffModel StaffModel { get; set; }
        public virtual SubjectModel SubjectModel { get; set; }
        public virtual StudentModel StudentModel { get; set; }


    }
}
