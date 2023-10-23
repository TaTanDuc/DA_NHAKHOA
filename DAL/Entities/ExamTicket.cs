namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExamTicket")]
    public partial class ExamTicket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TicketID { get; set; }

        [StringLength(10)]
        public string CustomerID { get; set; }

        [StringLength(10)]
        public string StaffID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AppointmentDate { get; set; }

        public int? StatusID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ExamDetail ExamDetail { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual Status Status { get; set; }
    }
}
