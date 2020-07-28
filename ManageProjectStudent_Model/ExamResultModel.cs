using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("ExamResult")]
    public class ExamResultModel
    {
        private string _StrExamTimesID;
        private string _StrStudentID;
        private string _StrSubjectID;
        private decimal _DGrade;

        [Key]
        [Column("StudentID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrStudentID { get => _StrStudentID; set => _StrStudentID = value; }

        [Key]
        [Column("ExamTimesID", TypeName = "varchar", Order = 1)]
        [StringLength(10)]
        public string StrExamTimesID { get => _StrExamTimesID; set => _StrExamTimesID = value; }

        [Key]
        [Column("SubjectID", TypeName = "varchar", Order = 2)]
        [StringLength(10)]
        public string StrSubjectID { get => _StrSubjectID; set => _StrSubjectID = value; }

        [Column("Grade", TypeName = "Decimal", Order = 3)]
        public decimal DGrade { get => _DGrade; set => _DGrade = value; }

        //Khai bao khoa ngoai
        public virtual ExamTimesModel ExamTimesModel { get; set; }
        public virtual StudentModel StudentModel { get; set; }
        public virtual SubjectModel SubjectModel { get; set; }

    }
}
