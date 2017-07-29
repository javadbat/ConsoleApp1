namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            ExchangePayments = new HashSet<ExchangePayment>();
            InvoiceAudits = new HashSet<InvoiceAudit>();
            InvoiceDiscountAudits = new HashSet<InvoiceDiscountAudit>();
            InvoiceItems = new HashSet<InvoiceItem>();
            ExchangePayments1 = new HashSet<ExchangePayment>();
        }

        public long InvoiceId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Family { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(24)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(24)]
        public string Landline { get; set; }

        [Required]
        [StringLength(24)]
        public string AreaCode { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public byte DiscountType { get; set; }

        [Column(TypeName = "money")]
        public decimal DiscountPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal SendPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal CreditPolicyPrice { get; set; }

        public byte StatusId { get; set; }

        [Required]
        [StringLength(4000)]
        public string Address { get; set; }

        [Required]
        [StringLength(60)]
        public string PostalCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int PaymentMethodId { get; set; }

        public long UserId { get; set; }

        public int CityId { get; set; }

        public int StateId { get; set; }

        public byte SendMethodId { get; set; }

        public long? UserAddressId { get; set; }

        public virtual City City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangePayment> ExchangePayments { get; set; }

        public virtual InvoicePaymentMethod InvoicePaymentMethod { get; set; }

        public virtual InvoiceSendMethod InvoiceSendMethod { get; set; }

        public virtual InvoiceStatu InvoiceStatu { get; set; }

        public virtual UserAddress UserAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceAudit> InvoiceAudits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDiscountAudit> InvoiceDiscountAudits { get; set; }

        public virtual User User { get; set; }

        public virtual State State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangePayment> ExchangePayments1 { get; set; }
    }
}
