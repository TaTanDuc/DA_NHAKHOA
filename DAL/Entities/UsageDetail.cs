namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UsageDetail
    {
        [Key]
        [Column(Order = 0)]
        public DateTime Appointment { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string PermissionID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public int? DentistID { get; set; }

        [StringLength(3)]
        public string ItemType { get; set; }

        public int? ItemID { get; set; }

        public int? ItemNO { get; set; }

        public virtual Schedule Schedule { get; set; }

        public virtual Storage Storage { get; set; }
    }
}
