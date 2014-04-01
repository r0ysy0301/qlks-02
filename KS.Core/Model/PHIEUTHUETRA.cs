using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KS.Core.Model
{
    [Table("PHIEUTHUETRA")]
    public partial class PHIEUTHUETRA:PersistentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MaPhieuThue { get; set; }
        public string MaPhong { get; set; }
        public string MaKhach { get; set; }
        public Nullable<System.DateTime> NgayThue { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string MaNV { get; set; }

        public virtual KHACH KHACH { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}
