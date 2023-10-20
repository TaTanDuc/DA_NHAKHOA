namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prescription")]
    public partial class Prescription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrescriptionID { get; set; }

        [StringLength(10)]
        public string CustomerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PrescriptionDate { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
