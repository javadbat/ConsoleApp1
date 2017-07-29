namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserAddress")]
    public partial class UserAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserAddress()
        {
            Invoices = new HashSet<Invoice>();
        }

        public long UserAddressId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Family { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(60)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(60)]
        public string Landline { get; set; }

        [Required]
        [StringLength(24)]
        public string AreaCode { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [Required]
        [StringLength(4000)]
        public string Address { get; set; }

        [Required]
        [StringLength(60)]
        public string PostalCode { get; set; }

        public long UserId { get; set; }

        public int CityId { get; set; }

        public int StateId { get; set; }

        public virtual City City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }

        public virtual State State { get; set; }

        public virtual User User { get; set; }
    }
}
