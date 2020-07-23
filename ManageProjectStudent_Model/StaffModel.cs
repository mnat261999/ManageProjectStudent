using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Staff")]
    public class StaffModel
    {
        private string _StrStaffID;
        private string _StrStaffName;
        private string _StrCardID;
        private DateTime _DtBirthDay;
        private string _StrEmail;
        private string _StrAddress;
        private string _StrPhone;
        private bool _BStatus;
        private string _StrSex;
        private string _StrStaffTypeID;
        private string _strFacultyID;

        [Key]
        [Column("StaffID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrStaffID { get => _StrStaffID; set => _StrStaffID = value; }

        [Column("StaffName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrStaffName { get => _StrStaffName; set => _StrStaffName = value; }

        [Column("CardID", TypeName = "varchar", Order = 2)]
        public string StrCardID { get => _StrCardID; set => _StrCardID = value; }

        [Column("BirthDay", TypeName = "Date", Order = 3)]
        public DateTime DtBirthDay { get => _DtBirthDay; set => _DtBirthDay = value; }

        [Column("Email", TypeName = "varchar", Order = 4)]
        [StringLength(200)]
        public string StrEmail { get => _StrEmail; set => _StrEmail = value; }

        [Column("Address", TypeName = "nvarchar", Order = 5)]
        public string StrAddress { get => _StrAddress; set => _StrAddress = value; }

        [Column("Phone", TypeName = "varchar", Order = 6)]
        [StringLength(30)]
        public string StrPhone { get => _StrPhone; set => _StrPhone = value; }

        [Column("Status", TypeName = "bit", Order = 7)]
        public bool BStatus { get => _BStatus; set => _BStatus = value; }

        [Column("Sex", TypeName = "nvarchar", Order = 8)]
        [StringLength(10)]
        public string StrSex { get => _StrSex; set => _StrSex = value; }

        //Khoi tao khoa ngoai
        [Column("StaffTypeID", TypeName = "varchar", Order = 9)]
        [StringLength(10)]
        public string StrStaffTypeID { get => _StrStaffTypeID; set => _StrStaffTypeID = value; }

        [Column("FacultyID", TypeName = "varchar", Order = 10)]
        [StringLength(10)]
        public string StrFacultyID { get => _strFacultyID; set => _strFacultyID = value; }

        // khai bao khoa ngoai
        public virtual StaffTypeModel StaffTypeModel { get; set; }
        public virtual FacultyModel FacultyModel { get; set; }

        // tao moi quan he 1
        public ICollection<ProjectModel> ProjectModels { get; set; }
        public ICollection<ClassGroupOfSubject> ClassGroupOfSubjects { get; set; }
        public ICollection<TeachAndStudy> TeachAndStudies { get; set; }

        public StaffModel()
        {
            this.ProjectModels = new HashSet<ProjectModel>();
            this.ClassGroupOfSubjects = new HashSet<ClassGroupOfSubject>();
            this.TeachAndStudies = new HashSet<TeachAndStudy>();
        }
    }
}
 