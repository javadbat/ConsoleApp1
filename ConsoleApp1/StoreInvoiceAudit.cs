namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreInvoiceAudit")]
    public partial class StoreInvoiceAudit
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public long InvoiceId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string OldAddress { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string NewAddress { get; set; }

        [Required]
        [StringLength(24)]
        public string OldPhoneNumber { get; set; }

        [Required]
        [StringLength(24)]
        public string NewPhoneNumber { get; set; }

        [Required]
        [StringLength(24)]
        public string OldLandline { get; set; }

        [Required]
        [StringLength(24)]
        public string NewLandline { get; set; }

        [Required]
        [StringLength(24)]
        public string OldAreaCode { get; set; }

        [Required]
        [StringLength(24)]
        public string NewAreaCode { get; set; }

        [Required]
        [StringLength(60)]
        public string OldPostalCode { get; set; }

        [Required]
        [StringLength(60)]
        public string NewPostalCode { get; set; }

        public byte? OldStatusId { get; set; }

        public byte? NewStatusId { get; set; }

        public virtual StoreInvoice StoreInvoice { get; set; }

        public virtual StoreInvoiceStatu StoreInvoiceStatu { get; set; }

        public virtual StoreInvoiceStatu StoreInvoiceStatu1 { get; set; }

        public virtual User User { get; set; }
    }
}
