using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KS.Core.Model
{
    [Table("LOAIPHONG")]
    public partial class LOAIPHONG:PersistentEntity
    {
        public LOAIPHONG()
        {
            this.PHONGs = new HashSet<PHONG>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MaLoaiPhong { get; set; }
        public string TenLoai { get; set; }
        public Nullable<decimal> DonGia { get; set; }

        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
}
