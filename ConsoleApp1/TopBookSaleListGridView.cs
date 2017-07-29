namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TopBookSaleListGridView")]
    public partial class TopBookSaleListGridView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ProductId { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "money")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [StringLength(255)]
        public string SamplePDF { get; set; }

        public int? SaleSum { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Percentage { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountPrice { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GradeId { get; set; }
    }
}
