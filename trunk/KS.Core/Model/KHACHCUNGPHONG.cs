using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KS.Core.Model
{
    [Table("KHACHCUNGPHONG")]
    public partial class KHACHCUNGPHONG:PersistentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaKhachCP { get; set; }
        public string MaKhach { get; set; }
        public string TenKhachCP { get; set; }
        public Nullable<System.DateTime> NgaySinhKhachCP { get; set; }
        public string GioiTinhCP { get; set; }
        public string DiaChiCP { get; set; }
        public string CMND { get; set; }
        public string QuocTich { get; set; }
        public string SDTCP { get; set; }

        public virtual KHACH KHACH { get; set; }
    }
}
