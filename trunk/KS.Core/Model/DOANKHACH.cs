using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KS.Core.Model
{
     [Table("DOANKHACH")]
    public partial class DOANKHACH:PersistentEntity
    {
        public DOANKHACH()
        {
            this.KHACHes = new HashSet<KHACH>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MaDoan { get; set; }
        public string TenDoanKhach { get; set; }

        public virtual ICollection<KHACH> KHACHes { get; set; }
    }
}
