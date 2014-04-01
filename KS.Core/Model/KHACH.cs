using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KS.Core.Model
{
     [Table("KHACH")]
    public partial class KHACH:PersistentEntity
    {
        public KHACH()
        {
            this.CHITIETPHIEUDPs = new HashSet<CHITIETPHIEUDP>();
            this.KHACHCUNGPHONGs = new HashSet<KHACHCUNGPHONG>();
            this.PHIEUTHUETRAs = new HashSet<PHIEUTHUETRA>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinhKhach { get; set; }
        public string DiaChiKhach { get; set; }
        public string CMND { get; set; }
        public string QuocTich { get; set; }
        public string Dienthoai { get; set; }
        public string MaDoan { get; set; }

        public virtual ICollection<CHITIETPHIEUDP> CHITIETPHIEUDPs { get; set; }
        public virtual DOANKHACH DOANKHACH { get; set; }
        public virtual ICollection<KHACHCUNGPHONG> KHACHCUNGPHONGs { get; set; }
        public virtual ICollection<PHIEUTHUETRA> PHIEUTHUETRAs { get; set; }
    }
}
