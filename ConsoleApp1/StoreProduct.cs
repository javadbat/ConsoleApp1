namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreProduct")]
    public partial class StoreProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StoreProduct()
        {
            StoreBaskets = new HashSet<StoreBasket>();
            StoreGradeOfferProducts = new HashSet<StoreGradeOfferProduct>();
            StoreInvoiceItems = new HashSet<StoreInvoiceItem>();
            StoreProductSalePolicies = new HashSet<StoreProductSalePolicy>();
            StoreScreenShots = new HashSet<StoreScreenShot>();
            StoreDiscounts = new HashSet<StoreDiscount>();
            Grades = new HashSet<Grade>();
            Tags = new HashSet<Tag>();
        }

        [Key]
        public long ProductId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public string FullDescription { get; set; }

        [StringLength(255)]
        public string SubTitle { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductType { get; set; }

        public int Weight { get; set; }

        public double Rate { get; set; }

        public long NumberofRate { get; set; }

        public bool IsEnabled { get; set; }

        public byte? StatusId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual StoreApp StoreApp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreBasket> StoreBaskets { get; set; }

        public virtual StoreBook StoreBook { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreGradeOfferProduct> StoreGradeOfferProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreInvoiceItem> StoreInvoiceItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreProductSalePolicy> StoreProductSalePolicies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreScreenShot> StoreScreenShots { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreDiscount> StoreDiscounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
