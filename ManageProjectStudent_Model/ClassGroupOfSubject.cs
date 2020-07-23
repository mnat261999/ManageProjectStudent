using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("ClassGroupOfSubject")]
    public class ClassGroupOfSubject
    {
        private string _StrGroupID;
        private string _StrGroupName;
        private string _StrStaffID;
        private string _StrSubjectID;

        [Key]
        [Column("GroupID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrGroupID { get => _StrGroupID; set => _StrGroupID = value; }

        [Column("GroupName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrGroupName { get => _StrGroupName; set => _StrGroupName = value; }

        //Khai tao Khoa ngoai
        [Column("StaffID", TypeName = "varchar", Order = 2)]
        [StringLength(10)]
        public string StrStaffID { get => _StrStaffID; set => _StrStaffID = value; }

        [Column("SubjectID", TypeName = "varchar", Order = 3)]
        [StringLength(10)]
        public string StrSubjectID { get => _StrSubjectID; set => _StrSubjectID = value; }

        //khai bao khoa ngoai
        public virtual StaffModel StaffModel { get; set; }
        public virtual SubjectModel SubjectModel { get; set; }

        //Tao moi lien ket
        public ICollection<StudentClassGroup> StudentClassGroups { get; set; }


        public ClassGroupOfSubject()
        {
            this.StudentClassGroups = new HashSet<StudentClassGroup>();
        }

    }
}
