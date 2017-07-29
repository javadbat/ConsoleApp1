namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreOffer")]
    public partial class StoreOffer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StoreOffer()
        {
            StoreDiscounts = new HashSet<StoreDiscount>();
            StoreGradeOfferProducts = new HashSet<StoreGradeOfferProduct>();
            StoreProductSalePolicies = new HashSet<StoreProductSalePolicy>();
        }

        [Key]
        public int OfferId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public int SortOrder { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreDiscount> StoreDiscounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreGradeOfferProduct> StoreGradeOfferProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreProductSalePolicy> StoreProductSalePolicies { get; set; }
    }
}
