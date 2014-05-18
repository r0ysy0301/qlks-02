using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KS.Core.Model
{
    [Table("DICHVU")]
    public partial class DICHVU : PersistentEntity
    {
        public DICHVU()  
        {
            this.PHIEUDICHVUs = new HashSet<PHIEUDICHVU>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public string DonViTinh { get; set; }
        public Nullable<decimal> DonGia { get; set; }
    
        public virtual ICollection<PHIEUDICHVU> PHIEUDICHVUs { get; set; }
    }
}
