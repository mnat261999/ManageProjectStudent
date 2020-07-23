using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("TrainingProgram")]
    public class TrainingProgramModel
    {
        private string _StrTrainingProgramID;
        private string _StrTrainingProgramName;

        [Key]
        [Column("TrainingProgramID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrTrainingProgramID { get => _StrTrainingProgramID; set => _StrTrainingProgramID = value; }

        [Column("TrainingProgramName", TypeName = "nvarchar", Order = 1)]
        [StringLength(10)]
        public string StrTrainingProgramName { get => _StrTrainingProgramName; set => _StrTrainingProgramName = value; }

        //Tao moi lien ket
        public ICollection<SubjectAssignmentModel> SubjectAssignmentModels { get; set; }

        public TrainingProgramModel()
        {
            this.SubjectAssignmentModels = new HashSet<SubjectAssignmentModel>();
        }
    }
}
