namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceDiscountAudit")]
    public partial class InvoiceDiscountAudit
    {
        public long InvoiceDiscountAuditId { get; set; }

        public long InvoiceId { get; set; }

        public long CodeId { get; set; }

        [Required]
        [StringLength(60)]
        public string Code { get; set; }

        [Column(TypeName = "money")]
        public decimal DiscountPrice { get; set; }

        public int Percentage { get; set; }

        [Required]
        [StringLength(10)]
        public string OrganizeTitle { get; set; }

        public int? OrganizeId { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
