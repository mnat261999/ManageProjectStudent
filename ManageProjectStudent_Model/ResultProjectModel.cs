using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("ResultProject")]
    public class ResultProjectModel
    {
        private string _StrProjectID;
        private string _StrStudentID;
        private decimal _DGrade;

        // Khoi tao khoa ngoai de mapping.
        [Key]
        [Column("ProjectID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrProjectID { get => _StrProjectID; set => _StrProjectID = value; }

        [Key]
        [StringLength(10)]
        [Column("StudentID", TypeName = "varchar", Order = 1)]
        public string StrStudentID { get => _StrStudentID; set => _StrStudentID = value; }
        // Khoi tao khoa ngoai de mapping.

        [Column("Grade", TypeName = "decimal", Order = 2)]
        public decimal DGrade { get => _DGrade; set => _DGrade = value; }

        // Khai bao khoa ngoai.
        public virtual ProjectModel ProjectModel { get; set; }
        public virtual StudentModel StudentModel { get; set; }
    }
}
