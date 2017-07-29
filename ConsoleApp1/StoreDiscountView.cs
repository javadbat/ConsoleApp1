namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreDiscountView")]
    public partial class StoreDiscountView
    {
        [Key]
        [Column(Order = 0)]
        public int DiscountId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Percentage { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsEnabled { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime StartAt { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime EndAt { get; set; }
    }
}
