using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KS.Core.Model
{
    [Table("PHIEUDICHVU")]
    public partial class PHIEUDICHVU: PersistentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaPhieuDV { get; set; }
        public string MaDV { get; set; }
        public string MaPhong { get; set; }
        public Nullable<int> SoLuongDV { get; set; }
        public Nullable<System.DateTime> NgaySD { get; set; }

        public virtual DICHVU DICHVU { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}
