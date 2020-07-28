    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Subject")]
    public class SubjectModel
    {
        private string _StrSubjectID;
        private string _strSubjectName;
        private DateTime _DtStartDay;
        private DateTime _DtEndDay;
        private string _StrFacultyID;
        [Key]
        [Column("SubjectID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrSubjectID { get => _StrSubjectID; set => _StrSubjectID = value; }

        [Column("SubjectName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrSubjectName { get => _strSubjectName; set => _strSubjectName = value; }

        [Column("StartDay", TypeName = "Date", Order = 2)]
        public DateTime DtStartDay { get => _DtStartDay; set => _DtStartDay = value; }

        [Column("EndDay", TypeName = "Date", Order = 3)]
        public DateTime DtEndDay { get => _DtEndDay; set => _DtEndDay = value; }

        //khai tao khoa ngoai
        [Column("FacultyID", TypeName = "varchar", Order = 4)]
        [StringLength(10)]
        public string StrFacultyID { get => _StrFacultyID; set => _StrFacultyID = value; }

        //Khai bao khoa ngoai
        public virtual FacultyModel FacultyModel { get; set; }

        // Tao moi lien ket giua cac bang
        public ICollection<ProjectModel> ProjectModels { get; set; }
        public ICollection<SubjectAssignmentModel> SubjectAssignmentModels { get; set; }
        public ICollection<TeachAndStudy> TeachAndStudies { get; set; }
        public ICollection<ClassGroupOfSubject> ClassGroupOfSubjects { get; set; }
        public ICollection<ExamResultModel> ExamResultModels { get; set; }

        public SubjectModel()
        {
            this.ProjectModels = new HashSet<ProjectModel>();
            this.SubjectAssignmentModels = new HashSet<SubjectAssignmentModel>();
            this.TeachAndStudies = new HashSet<TeachAndStudy>();
            this.ClassGroupOfSubjects = new HashSet<ClassGroupOfSubject>();
            this.ExamResultModels = new HashSet<ExamResultModel>();
        }
    }
}
