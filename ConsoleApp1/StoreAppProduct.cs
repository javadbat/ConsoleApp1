namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreAppProduct")]
    public partial class StoreAppProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StoreAppProduct()
        {
            StoreAppPurchases = new HashSet<StoreAppPurchase>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AppProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(4000)]
        public string Description { get; set; }

        [Required]
        [StringLength(120)]
        public string Sku { get; set; }

        public byte Type { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsEnabled { get; set; }

        public long ProductId { get; set; }

        public virtual StoreApp StoreApp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreAppPurchase> StoreAppPurchases { get; set; }
    }
}
