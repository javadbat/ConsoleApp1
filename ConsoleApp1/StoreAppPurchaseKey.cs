namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreAppPurchaseKey")]
    public partial class StoreAppPurchaseKey
    {
        [Key]
        public int AppPurchaseKeyId { get; set; }

        [Required]
        [StringLength(4000)]
        public string PrivateKey { get; set; }

        [Required]
        [StringLength(4000)]
        public string PublicKey { get; set; }

        [Required]
        [StringLength(4000)]
        public string PrivateKeyPem { get; set; }

        [Required]
        [StringLength(4000)]
        public string PublicKeyPem { get; set; }

        public long ProductId { get; set; }

        public virtual StoreApp StoreApp { get; set; }
    }
}
