namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NowruzCamp")]
    public partial class NowruzCamp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NowruzCamp()
        {
            NowruzCampRegisterationCodes = new HashSet<NowruzCampRegisterationCode>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NowruzCampId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }

        public DateTime CreatedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NowruzCampRegisterationCode> NowruzCampRegisterationCodes { get; set; }
    }
}
