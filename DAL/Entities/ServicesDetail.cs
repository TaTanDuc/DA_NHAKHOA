namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ServicesDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Count { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime Appointment { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string PermissionID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [StringLength(3)]
        public string CategoryID { get; set; }

        public int? ServiceID { get; set; }

        public int? Quantity { get; set; }

        public long? Total { get; set; }

        public virtual Detail Detail { get; set; }

        public virtual Service Service { get; set; }
    }
}
