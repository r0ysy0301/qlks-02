using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KS.Core.Model
{
    [Table("PHONG")]
    public partial class PHONG:PersistentEntity
    {
        public PHONG()
        {
            this.PHIEUDICHVUs = new HashSet<PHIEUDICHVU>();
            this.PHIEUTHUETRAs = new HashSet<PHIEUTHUETRA>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MaPhong { get; set; }
        public string TinhTrang { get; set; }
        public string SDTPhong { get; set; }
        public string MaLoaiPhong { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }
        public virtual ICollection<PHIEUDICHVU> PHIEUDICHVUs { get; set; }
        public virtual ICollection<PHIEUTHUETRA> PHIEUTHUETRAs { get; set; }
    }
}
