namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportExportTicket")]
    public partial class ImportExportTicket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IETicketID { get; set; }

        public int? TaM_ID { get; set; }

        [StringLength(1)]
        public string IorE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IEDate { get; set; }

        public int? Quantity { get; set; }

        public long? Total { get; set; }

        public virtual ToolAndMaterial ToolAndMaterial { get; set; }
    }
}
