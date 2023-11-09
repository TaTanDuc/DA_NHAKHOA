namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Schedule")]
    public partial class Schedule
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

        [StringLength(2)]
        public string StatusID { get; set; }

        public virtual Detail Detail { get; set; }

        public virtual User User { get; set; }

        public virtual Status Status { get; set; }
    }
}
