namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            ExamTickets = new HashSet<ExamTicket>();
        }

        [StringLength(10)]
        public string StaffID { get; set; }

        [StringLength(300)]
        public string FullName { get; set; }

        [Column(TypeName = "ntext")]
        public string Phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamTicket> ExamTickets { get; set; }

        public virtual LogIn LogIn { get; set; }
    }
}
