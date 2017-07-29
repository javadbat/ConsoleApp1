namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonOnline")]
    public partial class AzmoonOnline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonOnline()
        {
            AzmoonPackages = new HashSet<AzmoonPackage>();
            AzmoonUserParticipantCourses = new HashSet<AzmoonUserParticipantCourse>();
        }

        public int AzmoonOnlineId { get; set; }

        [Required]
        [StringLength(60)]
        public string Title { get; set; }

        public int AzmoonSal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonPackage> AzmoonPackages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonUserParticipantCourse> AzmoonUserParticipantCourses { get; set; }
    }
}
