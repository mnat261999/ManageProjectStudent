using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("StudentClassGroup")]
    public class StudentClassGroup
    {
        private string _StrStudentID;
        private string _StrGroupID;

        [Key]
        [Column("StudentID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrStudentID { get => _StrStudentID; set => _StrStudentID = value; }

        [Key]
        [Column("GroupID", TypeName = "varchar", Order = 1)]
        [StringLength(10)]
        public string StrGroupID { get => _StrGroupID; set => _StrGroupID = value; }

        //khai bao khoa ngoai
       // public virtual ClassGroupOfSubject ClassGroupOfSubject { get; set; }
        public virtual StudentModel StudentModel { get; set; }

    }
}
