namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Giftcard")]
    public partial class Giftcard
    {
        public int GiftcardId { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(16)]
        public string Code { get; set; }

        public DateTime? ConsumedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpireAt { get; set; }

        public long? ConsumedBy { get; set; }

        [Required]
        [StringLength(12)]
        public string Serial { get; set; }

        public virtual User User { get; set; }
    }
}
