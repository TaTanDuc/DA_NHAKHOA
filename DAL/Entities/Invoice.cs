namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }

        [StringLength(2)]
        public string PermissionID { get; set; }

        public int? UserID { get; set; }

        public DateTime? Appointment { get; set; }

        public int? StaffID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InvoiceDate { get; set; }

        public int? PrescriptionID { get; set; }

        public virtual Detail Detail { get; set; }

        public virtual Prescription Prescription { get; set; }
    }
}
