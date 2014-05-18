using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KS.Core.Model
{
    [Table("PHIEUDATPHONG")]
    public partial class PHIEUDATPHONG:PersistentEntity
    {
        
        public PHIEUDATPHONG()
        {
            this.CHITIETPHIEUDPs = new HashSet<CHITIETPHIEUDP>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaPhieuDP { get; set; }
        public string YeuCauLoaPhong { get; set; }
        public Nullable<int> SoLuongPhong { get; set; }

        public virtual ICollection<CHITIETPHIEUDP> CHITIETPHIEUDPs { get; set; }
    }
}
