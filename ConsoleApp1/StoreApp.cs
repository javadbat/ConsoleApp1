namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreApp")]
    public partial class StoreApp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StoreApp()
        {
            CmsProductPromotions = new HashSet<CmsProductPromotion>();
            CrashReports = new HashSet<CrashReport>();
            StoreAppProducts = new HashSet<StoreAppProduct>();
            StoreAppReleases = new HashSet<StoreAppRelease>();
            StoreAppPurchaseKeys = new HashSet<StoreAppPurchaseKey>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ProductId { get; set; }

        [Required]
        [StringLength(255)]
        public string PackageName { get; set; }

        public int SortOrder { get; set; }

        public int State { get; set; }

        public float GajPoint { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CmsProductPromotion> CmsProductPromotions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrashReport> CrashReports { get; set; }

        public virtual StoreProduct StoreProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreAppProduct> StoreAppProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreAppRelease> StoreAppReleases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreAppPurchaseKey> StoreAppPurchaseKeys { get; set; }
    }
}
