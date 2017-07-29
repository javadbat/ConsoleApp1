namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Baskets = new HashSet<Basket>();
            ExchangePayments = new HashSet<ExchangePayment>();
            Invoices = new HashSet<Invoice>();
            UserAddresses = new HashSet<UserAddress>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Family { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        [Required]
        [StringLength(500)]
        public string Password { get; set; }

        public DateTime RegisteredAt { get; set; }

        public DateTime? LastLoggedinAt { get; set; }

        [StringLength(4000)]
        public string SecurityStamp { get; set; }

        public byte LoginFailedCount { get; set; }

        public DateTime? LockoutEndDate { get; set; }

        public bool LockoutEnabled { get; set; }

        public byte Status { get; set; }

        public int? GradeId { get; set; }

        public Guid? UsernameIdentifier { get; set; }

        [Required]
        [StringLength(255)]
        public string Avatar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basket> Baskets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangePayment> ExchangePayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }

        public virtual InvoiceAudit InvoiceAudit { get; set; }

        public virtual UserProfile UserProfile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
