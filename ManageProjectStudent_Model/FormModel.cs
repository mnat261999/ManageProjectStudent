using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Form")]
    public class FormModel
    {
        private string _StrFormID;
        private string _StrFormName;

        [Key]
        [Column("FormID", TypeName = "varchar", Order = 0)]
        [StringLength(100)]
        public string StrFormID { get => _StrFormID; set => _StrFormID = value; }

        [Column("FormName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrFormName { get => _StrFormName; set => _StrFormName = value; }

        

        // Tao moi quan he
        public ICollection<DecentralizeModel> DecentralizeModels { get; set; }

        public FormModel()
        {
            this.DecentralizeModels = new HashSet<DecentralizeModel>();
        }

    }
}
