namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreProductSalePolicy")]
    public partial class StoreProductSalePolicy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long StoreProductSalePolicyId { get; set; }

        public long ProductId { get; set; }

        public int? MinOrderCount { get; set; }

        public int? MaxOrderCount { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool IsDeleted { get; set; }

        public long CreatedBy { get; set; }

        public long? EditedBy { get; set; }

        public int? DiscountId { get; set; }

        public int? OfferId { get; set; }

        public virtual StoreDiscount StoreDiscount { get; set; }

        public virtual StoreOffer StoreOffer { get; set; }

        public virtual StoreProduct StoreProduct { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
