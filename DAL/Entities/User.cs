namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Schedules = new HashSet<Schedule>();
        }

        [StringLength(30)]
        public string LoginName { get; set; }

        [StringLength(30)]
        public string Password { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string PermissionID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDay { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }

        [Column(TypeName = "image")]
        public byte[] ProfilePicture { get; set; }

        public virtual Permission Permission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
