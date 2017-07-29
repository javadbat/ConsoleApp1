namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceAudit")]
    public partial class InvoiceAudit
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

        public virtual Invoice Invoice { get; set; }

        public virtual User User { get; set; }
    }
}
