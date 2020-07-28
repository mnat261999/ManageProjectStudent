using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Word")]
    public class WordModel
    {
        private string _StrWordId;
        private string _StrWordName;
        private string _StrModule;

        [Key]
        [Column("WordID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrWordId { get => _StrWordId; set => _StrWordId = value; }

        [Column("WordName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrWordName { get => _StrWordName; set => _StrWordName = value; }
 
        [Column("Module", TypeName = "nvarchar", Order = 2)]
        [StringLength(100)]
        public string StrModule { get => _StrModule; set => _StrModule = value; }

        public ICollection<LanguageWordModel> LanguageWordModels { get; set; }

        public WordModel()
        {
            this.LanguageWordModels = new HashSet<LanguageWordModel>();
        }
    }
}
