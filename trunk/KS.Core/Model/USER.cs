using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KS.Core.Model
{
    [Table("USER")]
    public partial class USER :PersistentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string User1 { get; set; }
        public string pass { get; set; }
        public string Quyen { get; set; }
    }
}
