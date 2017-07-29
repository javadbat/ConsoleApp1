namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfferListView")]
    public partial class OfferListView
    {
        [Key]
        [Column(Order = 0)]
        public int OfferId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SortOrder { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsEnabled { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime StartAt { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime EndAt { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
