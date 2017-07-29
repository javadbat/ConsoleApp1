namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AzmoonJozeDar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonJozeDar()
        {
            AzmoonPackageJozeDars = new HashSet<AzmoonPackageJozeDar>();
        }

        [Key]
        public int AzmoonJozeDarsId { get; set; }

        public int AzmoonDarsId { get; set; }

        public int JozeCode { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public virtual AzmoonDar AzmoonDar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonPackageJozeDar> AzmoonPackageJozeDars { get; set; }
    }
}
