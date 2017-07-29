namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreInvoice")]
    public partial class StoreInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StoreInvoice()
        {
            InvoiceDiscountAudits = new HashSet<InvoiceDiscountAudit>();
            StorePayments = new HashSet<StorePayment>();
            StoreInvoiceItems = new HashSet<StoreInvoiceItem>();
            StorePayments1 = new HashSet<StorePayment>();
        }

        [Key]
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
        public decimal PriceSend { get; set; }

        [Column(TypeName = "money")]
        public decimal CreditPolicyPrice { get; set; }

        public byte StatusId { get; set; }

        [Required]
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

        public int? CourierId { get; set; }

        [StringLength(50)]
        public string PostTrackingCode { get; set; }

        public virtual City City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDiscountAudit> InvoiceDiscountAudits { get; set; }

        public virtual State State { get; set; }

        public virtual User User { get; set; }

        public virtual StoreInvoiceAudit StoreInvoiceAudit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StorePayment> StorePayments { get; set; }

        public virtual StoreInvoiceSendMethod StoreInvoiceSendMethod { get; set; }

        public virtual StoreInvoicePaymentMethod StoreInvoicePaymentMethod { get; set; }

        public virtual StoreInvoiceStatu StoreInvoiceStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreInvoiceItem> StoreInvoiceItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StorePayment> StorePayments1 { get; set; }
    }
}
