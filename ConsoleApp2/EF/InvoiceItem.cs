namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceItem")]
    public partial class InvoiceItem
    {
        public long InvoiceItemId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string Image { get; set; }

        public int Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal CoverPrice { get; set; }

        public int Count { get; set; }

        public int DiscountPercentage { get; set; }

        public long InvoiceId { get; set; }

        public long AgahiId { get; set; }

        public virtual ExchangeAgahi ExchangeAgahi { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
