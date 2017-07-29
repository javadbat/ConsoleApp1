namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OmegaInvoicePayment")]
    public partial class OmegaInvoicePayment
    {
        public long OmegaInvoicePaymentId { get; set; }

        public int OmegaInvoiceId { get; set; }

        [Required]
        [StringLength(255)]
        public string Token { get; set; }

        public long UserId { get; set; }

        public int GetawayId { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public byte Status { get; set; }

        public long? ReferenceId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [StringLength(255)]
        public string StatusMessage { get; set; }

        public virtual OmegaInvoice OmegaInvoice { get; set; }

        public virtual User User { get; set; }
    }
}
