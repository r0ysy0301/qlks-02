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
            this.DATPHONGs = new HashSet<DATPHONG>();
            this.HOADONs = new HashSet<HOADON>();
            this.HUYDATPHONGs = new HashSet<HUYDATPHONG>();
            this.KHACHCUNGPHONGs = new HashSet<KHACHCUNGPHONG>();
            this.PHIEUTHUETRAs = new HashSet<PHIEUTHUETRA>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
        public virtual ICollection<DATPHONG> DATPHONGs { get; set; }
        public virtual DOANKHACH DOANKHACH { get; set; }
        public virtual ICollection<HOADON> HOADONs { get; set; }
        public virtual ICollection<HUYDATPHONG> HUYDATPHONGs { get; set; }
        public virtual ICollection<KHACHCUNGPHONG> KHACHCUNGPHONGs { get; set; }
        public virtual ICollection<PHIEUTHUETRA> PHIEUTHUETRAs { get; set; }
    }
}
