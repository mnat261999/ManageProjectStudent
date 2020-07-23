using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("SubjectAssignment")]
    public class SubjectAssignmentModel
    {
        private string _StrTrainingProgramID;
        private string _StrFacultyID;
        private string _StrSubjectID;
        private string _StrSemester;
        private DateTime _DtSchoolYear;
        private int _ICredits;
        private int _ITheoreticalLesson;
        private int _IPracticalLesson;

        [Key]
        [Column("TrainingProgramID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrTrainingProgramID { get => _StrTrainingProgramID; set => _StrTrainingProgramID = value; }

        [Key]
        [Column("FacultyID", TypeName = "varchar", Order = 1)]
        [StringLength(10)]
        public string StrFacultyID { get => _StrFacultyID; set => _StrFacultyID = value; }

        [Key]
        [Column("SubjectID", TypeName = "varchar", Order = 2)]
        [StringLength(10)]
        public string StrSubjectID { get => _StrSubjectID; set => _StrSubjectID = value; }

        [Column("Semester", TypeName = "nvarchar", Order = 3)]
        public string StrSemester { get => _StrSemester; set => _StrSemester = value; }

        [Column("SchoolYear", TypeName = "Date", Order = 4)]
        public DateTime DtSchoolYear { get => _DtSchoolYear; set => _DtSchoolYear = value; }

        [Column("Credits", TypeName = "int", Order = 5)]
        public int ICredits { get => _ICredits; set => _ICredits = value; }

        [Column("TheoreticalLesson", TypeName = "int", Order = 6)]
        public int ITheoreticalLesson { get => _ITheoreticalLesson; set => _ITheoreticalLesson = value; }

        [Column("PracticalLesson", TypeName = "int", Order = 7)]
        public int IPracticalLesson { get => _IPracticalLesson; set => _IPracticalLesson = value; }

        // khai bao khoa ngoai
        public virtual SubjectModel SubjectModel { get; set; }
        public virtual FacultyModel FacultyModel { get; set; }
        public virtual TrainingProgramModel TrainingProgramModel { get; set; }
    }
}
