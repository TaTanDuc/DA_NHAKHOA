namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Detail()
        {
            Invoices = new HashSet<Invoice>();
            ServicesDetails = new HashSet<ServicesDetail>();
        }

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

        public virtual Schedule Schedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicesDetail> ServicesDetails { get; set; }

        public virtual UsageDetail UsageDetail { get; set; }
    }
}
