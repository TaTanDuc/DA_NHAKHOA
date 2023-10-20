namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogIn")]
    public partial class LogIn
    {
        [Key]
        [StringLength(10)]
        public string StaffID { get; set; }

        [Column(TypeName = "ntext")]
        public string Password { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
