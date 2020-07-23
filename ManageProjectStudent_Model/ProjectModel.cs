using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Project")]
    public class ProjectModel
    {
        private string _StrProjectID;
        private string _StrProjectName;
        private DateTime _DtStartDay;
        private DateTime _DtEndDay;
        private string _StrStaffID;
        private string _StrSubjectID;

        [Key]
        [Column("ProjectID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrProjectID { get => _StrProjectID; set => _StrProjectID = value; }

        [Column("ProjectName", TypeName = "nvarchar", Order = 1)]
        public string StrProjectName { get => _StrProjectName; set => _StrProjectName = value; }

        [Column("StartDay", TypeName = "Date", Order = 2)]
        public DateTime DtStartDay { get => _DtStartDay; set => _DtStartDay = value; }

        [Column("EndDay", TypeName = "Date", Order = 3)]
        public DateTime DtEndDay { get => _DtEndDay; set => _DtEndDay = value; }

        //khoi tao khoa ngoai
        [Column("StaffID", TypeName = "varchar", Order = 4)]
        [StringLength(10)]
        public string StrStaffID { get => _StrStaffID; set => _StrStaffID = value; }

        [Column("SubjectID", TypeName = "varchar", Order = 5)]
        [StringLength(10)]
        public string StrSubjectID { get => _StrSubjectID; set => _StrSubjectID = value; }

        //Khai bao khoa ngoai 
        public virtual StaffModel StaffModel { get; set; }
        public virtual SubjectModel SubjectModel { get; set; }

        //tao moi lien ket
        public ICollection<ResultProjectModel> ResultProjectModels { get; set; }
        public ICollection<ProjectTaskModel> ProjectTaskModels { get; set; }

        public ProjectModel()
        {
            this.ResultProjectModels = new HashSet<ResultProjectModel>();
            this.ProjectTaskModels = new HashSet<ProjectTaskModel>();
        }
    }
}
