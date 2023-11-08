namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            ServicesDetails = new HashSet<ServicesDetail>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string CategoryID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceID { get; set; }

        [Column(TypeName = "ntext")]
        public string ServiceName { get; set; }

        [Column(TypeName = "ntext")]
        public string ServiceUnit { get; set; }

        public int? ServiceUnitPrice { get; set; }

        public virtual ServiceCategory ServiceCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicesDetail> ServicesDetails { get; set; }
    }
}
