using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KS.Core.Model
{
    [Table("CHITIETPHIEUDP")]
    public partial class CHITIETPHIEUDP: PersistentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaPhieuDP { get; set; }
        public string MaKhach { get; set; }
        public System.DateTime NgayDen { get; set; }
        public System.DateTime NgayDi { get; set; }

        public virtual KHACH KHACH { get; set; }
        public virtual PHIEUDATPHONG PHIEUDATPHONG { get; set; }
    }
}
