namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExchangePayment")]
    public partial class ExchangePayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExchangePayment()
        {
            Invoices = new HashSet<Invoice>();
        }

        [Key]
        public long PaymentId { get; set; }

        [StringLength(255)]
        public string Token { get; set; }

        public long? UserId { get; set; }

        public int GetawayId { get; set; }

        [StringLength(255)]
        public string UrlForm { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(255)]
        public string IP { get; set; }

        public DateTime PaidAt { get; set; }

        public long InvoiceId { get; set; }

        public long? ReferenceId { get; set; }

        public byte PaymentSourceId { get; set; }

        [Required]
        [StringLength(30)]
        public string PaymentSourceTitle { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
