namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreInvoiceItem")]
    public partial class StoreInvoiceItem
    {
        [Key]
        public long InvoiceItemId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public string FullDescription { get; set; }

        [StringLength(255)]
        public string Subtitle { get; set; }

        [Required]
        [StringLength(255)]
        public string Image { get; set; }

        public int Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int Count { get; set; }

        public int DiscountPercentage { get; set; }

        public long InvoiceId { get; set; }

        public long ProductId { get; set; }

        public virtual StoreInvoice StoreInvoice { get; set; }

        public virtual StoreProduct StoreProduct { get; set; }
    }
}
