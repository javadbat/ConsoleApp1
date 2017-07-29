namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonCampRegistrationCode")]
    public partial class AzmoonCampRegistrationCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonCampRegistrationCode()
        {
            AzmoonCampRegisters = new HashSet<AzmoonCampRegister>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CampRegisterationCodeId { get; set; }

        [Required]
        [StringLength(16)]
        public string Code { get; set; }

        [Required]
        [StringLength(16)]
        public string Serial { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime ExpireAt { get; set; }

        public DateTime? ConsumedAt { get; set; }

        public int? ConsumedBy { get; set; }

        public int AzmoonCampId { get; set; }

        public virtual AzmoonCamp AzmoonCamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonCampRegister> AzmoonCampRegisters { get; set; }

        public virtual AzmoonCampRegister AzmoonCampRegister { get; set; }
    }
}
