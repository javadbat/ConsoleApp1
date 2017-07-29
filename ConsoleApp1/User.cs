namespace ConsoleApp1
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
            AzmoonCamps = new HashSet<AzmoonCamp>();
            AzmoonCamps1 = new HashSet<AzmoonCamp>();
            AzmoonTopRankPersons = new HashSet<AzmoonTopRankPerson>();
            AzmoonTopRankPersons1 = new HashSet<AzmoonTopRankPerson>();
            AzmoonUserAnswers = new HashSet<AzmoonUserAnswer>();
            AzmoonUserParticipantCourses = new HashSet<AzmoonUserParticipantCourse>();
            GcmDevices = new HashSet<GcmDevice>();
            Giftcards = new HashSet<Giftcard>();
            News = new HashSet<News>();
            News1 = new HashSet<News>();
            OmegaInvoices = new HashSet<OmegaInvoice>();
            OmegaInvoicePayments = new HashSet<OmegaInvoicePayment>();
            SaleStores = new HashSet<SaleStore>();
            SaleStores1 = new HashSet<SaleStore>();
            SchoolProfiles = new HashSet<SchoolProfile>();
            StoreAppPurchases = new HashSet<StoreAppPurchase>();
            StoreBaskets = new HashSet<StoreBasket>();
            StoreInvoices = new HashSet<StoreInvoice>();
            StorePayments = new HashSet<StorePayment>();
            StoreProductSalePolicies = new HashSet<StoreProductSalePolicy>();
            StoreProductSalePolicies1 = new HashSet<StoreProductSalePolicy>();
            StoreUserAddresses = new HashSet<StoreUserAddress>();
            AzmoonDars = new HashSet<AzmoonDar>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Family { get; set; }

        [StringLength(100)]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonCamp> AzmoonCamps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonCamp> AzmoonCamps1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonTopRankPerson> AzmoonTopRankPersons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonTopRankPerson> AzmoonTopRankPersons1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonUserAnswer> AzmoonUserAnswers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonUserParticipantCourse> AzmoonUserParticipantCourses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GcmDevice> GcmDevices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Giftcard> Giftcards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News> News { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News> News1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OmegaInvoice> OmegaInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OmegaInvoicePayment> OmegaInvoicePayments { get; set; }

        public virtual OmegaUser OmegaUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleStore> SaleStores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleStore> SaleStores1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchoolProfile> SchoolProfiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreAppPurchase> StoreAppPurchases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreBasket> StoreBaskets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreInvoice> StoreInvoices { get; set; }

        public virtual StoreInvoiceAudit StoreInvoiceAudit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StorePayment> StorePayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreProductSalePolicy> StoreProductSalePolicies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreProductSalePolicy> StoreProductSalePolicies1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreUserAddress> StoreUserAddresses { get; set; }

        public virtual UserProfile UserProfile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonDar> AzmoonDars { get; set; }
    }
}
