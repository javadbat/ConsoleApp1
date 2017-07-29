namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonCity")]
    public partial class AzmoonCity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonCity()
        {
            NowruzCampRegisters = new HashSet<NowruzCampRegister>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CityId { get; set; }

        public long ProvinceId { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        public virtual AzmoonProvince AzmoonProvince { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NowruzCampRegister> NowruzCampRegisters { get; set; }
    }
}
