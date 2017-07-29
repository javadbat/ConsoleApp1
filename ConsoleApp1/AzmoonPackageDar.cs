namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AzmoonPackageDar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonPackageDar()
        {
            AzmoonPackageJozeDars = new HashSet<AzmoonPackageJozeDar>();
        }

        [Key]
        public int AzmoonPackageDarsId { get; set; }

        public int AzmoonDarsId { get; set; }

        public int AzmoonPackageId { get; set; }

        public int StartAt { get; set; }

        public int EndAt { get; set; }

        public byte Status { get; set; }

        public bool IsDeleted { get; set; }

        public virtual AzmoonPackage AzmoonPackage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonPackageJozeDar> AzmoonPackageJozeDars { get; set; }
    }
}
