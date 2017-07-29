namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonRepresentive")]
    public partial class AzmoonRepresentive
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonRepresentive()
        {
            AzmoonPreRegisters = new HashSet<AzmoonPreRegister>();
            AzmoonRepresentiveLandLines = new HashSet<AzmoonRepresentiveLandLine>();
        }

        [Key]
        public int AzmoonRepresentativeId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int StateId { get; set; }

        public int CityId { get; set; }

        [Required]
        [StringLength(255)]
        public string Director { get; set; }

        [Required]
        public string Address { get; set; }

        public string WorkDay { get; set; }

        public string HoursofWork { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime CreatedAt { get; set; }

        [StringLength(60)]
        public string GoogleMapCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonPreRegister> AzmoonPreRegisters { get; set; }

        public virtual City City { get; set; }

        public virtual State State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonRepresentiveLandLine> AzmoonRepresentiveLandLines { get; set; }
    }
}
