using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("StaffType")]
    public class StaffTypeModel
    {
        private string _StrStaffTypeID;
        private string _StrStaffTypeName;

        [Key]
        [Column("StaffTypeID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrStaffTypeID { get => _StrStaffTypeID; set => _StrStaffTypeID = value; }

        [Column("StaffTypeName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrStaffTypeName { get => _StrStaffTypeName; set => _StrStaffTypeName = value; }

        //tao khoa ngoai
        //tao moi lien ket 
        public ICollection<StaffModel> StaffModels { get; set; }
        public ICollection<DecentralizeModel> DecentralizeModels { get; set; }
        public StaffTypeModel()
        {
            this.StaffModels = new HashSet<StaffModel>();
            this.DecentralizeModels = new HashSet<DecentralizeModel>();
        }
    }
}
    