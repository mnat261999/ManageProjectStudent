using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Language")]
    public class LanguageModel
    {
        private string _StrLanguageID;
        private string _StrLanguageName;
        private bool _BDefault;
        private bool _BStatus;

        [Key]
        [Column("LanguageID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrLanguageID { get => _StrLanguageID; set => _StrLanguageID = value; }
       
        [Column("LanguageName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrLanguageName { get => _StrLanguageName; set => _StrLanguageName = value; }

        [Column("Default", Order = 2)]
        public bool BDefault { get => _BDefault; set => _BDefault = value; }

        [Column("Status", Order = 3 )]
        public bool BStatus { get => _BStatus; set => _BStatus = value; }

        // Khai bao khoa ngoai.
        public ICollection<LanguageWordModel> LanguageWordModel { get; set; }

        public LanguageModel()
        {
            this.LanguageWordModel = new HashSet<LanguageWordModel>();
        }
    }
}
