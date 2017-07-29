namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonCamp")]
    public partial class AzmoonCamp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonCamp()
        {
            AzmoonCampRegistrationCodes = new HashSet<AzmoonCampRegistrationCode>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AzmoonCampId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public long? CreatedBy { get; set; }

        public long? EditedBy { get; set; }

        public DateTime? EditedAt { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonCampRegistrationCode> AzmoonCampRegistrationCodes { get; set; }
    }
}
