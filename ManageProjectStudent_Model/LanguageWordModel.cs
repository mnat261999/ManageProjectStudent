using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Language_Word")]
    public class LanguageWordModel
    {
        private string _StrLanguageID;
        private string _StrWordID;
        private string _StrMean;
        private bool _BStatus;

        [Key]
        [Column("LanguageID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrLanguageID { get => _StrLanguageID; set => _StrLanguageID = value; }

        [Key]
        [Column("WordID", TypeName = "varchar", Order = 1)]
        [StringLength(10)]
        public string StrWordID { get => _StrWordID; set => _StrWordID = value; }

        [Column("Mean", TypeName = "nvarchar", Order = 2)]
        [StringLength(100)]
        public string StrMean { get => _StrMean; set => _StrMean = value; }

        [Column("Status", Order = 3)]
        public bool BStatus { get => _BStatus; set => _BStatus = value; }

        // Khai bao khoa ngoai.
        public virtual LanguageModel LanguageModel { get; set; }
        public virtual WordModel WordModel { get; set; }
    }
}
