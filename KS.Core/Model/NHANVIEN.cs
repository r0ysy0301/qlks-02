using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KS.Core.Model
{
    [Table("NHANVIEN")]
    public partial class NHANVIEN:PersistentEntity
    {
        public NHANVIEN()
        {
            this.PHIEUTHUETRAs = new HashSet<PHIEUTHUETRA>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<System.DateTime> NgaySinhNV { get; set; }
        public string GioiTinhNV { get; set; }
        public string DiaChiNV { get; set; }
        public string SoDTNV { get; set; }
        public string ChucVu { get; set; }

        public virtual ICollection<PHIEUTHUETRA> PHIEUTHUETRAs { get; set; }
    }
}
