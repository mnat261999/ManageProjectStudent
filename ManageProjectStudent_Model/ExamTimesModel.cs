using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("ExamTimes")]
    public class ExamTimesModel
    {
        private string _StrExamTimesID;
        private int _ITimes;
        private DateTime _DtExamTime;

        [Key]
        [Column("ExamTimesID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrExamTimesID { get => _StrExamTimesID; set => _StrExamTimesID = value; }

        [Column("Times", TypeName = "int", Order = 1)]
        public int ITimes { get => _ITimes; set => _ITimes = value; }

        [Column("ExamTime", TypeName = "Datetime", Order = 2)]
        public DateTime DtExamTime { get => _DtExamTime; set => _DtExamTime = value; }

        //Tao moi lien ket
        public ICollection<ExamResultModel> ExamResultModels { get; set; }

        public ExamTimesModel()
        {
            this.ExamResultModels = new HashSet<ExamResultModel>();
        }
    }
}
