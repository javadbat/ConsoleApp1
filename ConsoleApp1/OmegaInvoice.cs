namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OmegaInvoice")]
    public partial class OmegaInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OmegaInvoice()
        {
            OmegaInvoicePayments = new HashSet<OmegaInvoicePayment>();
            OmegaPackages = new HashSet<OmegaPackage>();
            Payments = new HashSet<Payment>();
        }

        public int OmegaInvoiceId { get; set; }

        public long UserId { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [StringLength(255)]
        public string OmegaRefCode { get; set; }

        public int? MoarefDiscountPercent { get; set; }

        public long? MoarefId { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OmegaInvoicePayment> OmegaInvoicePayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OmegaPackage> OmegaPackages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
