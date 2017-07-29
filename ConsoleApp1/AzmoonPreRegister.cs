namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonPreRegister")]
    public partial class AzmoonPreRegister
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonPreRegister()
        {
            AzmoonTypes = new HashSet<AzmoonType>();
        }

        public int AzmoonPreRegisterId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Family { get; set; }

        [Required]
        [StringLength(50)]
        public string NationalId { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public int StateId { get; set; }

        public int GradeId { get; set; }

        public int AzmoonRepresentativeId { get; set; }

        public int Years { get; set; }

        public DateTime PreRegisterAt { get; set; }

        public int AzmoonPreRegisterStatusId { get; set; }

        public virtual AzmoonRepresentive AzmoonRepresentive { get; set; }

        public virtual Grade Grade { get; set; }

        public virtual State State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonType> AzmoonTypes { get; set; }
    }
}
