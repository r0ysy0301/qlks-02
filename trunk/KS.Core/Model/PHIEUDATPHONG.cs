using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KS.Core.Model
{
    [Table("PHIEUDATPHONG")]
    public partial class PHIEUDATPHONG:PersistentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MaPhieuDP { get; set; }
        public string YeuCauLoaPhong { get; set; }
        public Nullable<int> SoLuongPhong { get; set; }

        public virtual CHITIETPHIEUDP CHITIETPHIEUDP { get; set; }
    }
}
