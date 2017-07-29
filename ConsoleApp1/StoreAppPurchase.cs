namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreAppPurchase")]
    public partial class StoreAppPurchase
    {
        [Key]
        public int AppPurchaseId { get; set; }

        public DateTime PurchasedAt { get; set; }

        public bool IsConsumed { get; set; }

        public DateTime? ConsumedAt { get; set; }

        [Required]
        [StringLength(255)]
        public string DeveloperPayload { get; set; }

        [Required]
        [StringLength(255)]
        public string Token { get; set; }

        public long UserId { get; set; }

        public int AppProductId { get; set; }

        public virtual StoreAppProduct StoreAppProduct { get; set; }

        public virtual User User { get; set; }
    }
}
