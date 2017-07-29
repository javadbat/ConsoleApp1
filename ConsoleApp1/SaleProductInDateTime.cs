namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleProductInDateTime")]
    public partial class SaleProductInDateTime
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookTypeId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string BookTypeDisplayName { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumDiscountPrice { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiscountPercentage { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedAt { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte StatusId { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(255)]
        public string StatusDisplayName { get; set; }

        public int? SumCount { get; set; }

        public int? InvoiceCount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? PaymentTotalPrice { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long InvoiceId { get; set; }
    }
}
