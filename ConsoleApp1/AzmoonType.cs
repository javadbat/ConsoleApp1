namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonType")]
    public partial class AzmoonType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonType()
        {
            AzmoonPreRegisters = new HashSet<AzmoonPreRegister>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte AzmoonTypeId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonPreRegister> AzmoonPreRegisters { get; set; }
    }
}
