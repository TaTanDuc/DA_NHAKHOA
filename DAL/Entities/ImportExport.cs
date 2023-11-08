namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportExport")]
    public partial class ImportExport
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TicketID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string ItemType { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Quantity { get; set; }

        public long? Total { get; set; }

        public virtual Item Item { get; set; }
    }
}
