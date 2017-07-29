namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NowruzCampRegister")]
    public partial class NowruzCampRegister
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NowruzCampRegister()
        {
            NowruzCampRegisterationCodes = new HashSet<NowruzCampRegisterationCode>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NowruzCampRegisterId { get; set; }

        [Required]
        [StringLength(120)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(120)]
        public string LastName { get; set; }

        public bool IsMale { get; set; }

        [Required]
        [StringLength(120)]
        public string FatherName { get; set; }

        [Required]
        [StringLength(50)]
        public string ShomareShenasname { get; set; }

        public long NationalId { get; set; }

        public DateTime? BirthDate { get; set; }

        public long CoreGradeId { get; set; }

        [Required]
        [StringLength(24)]
        public string Landline { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public long AzmoonProvinceId { get; set; }

        public long AzmoonCityId { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(24)]
        public string PostalCode { get; set; }

        [StringLength(120)]
        public string Email { get; set; }

        [StringLength(60)]
        public string SchoolName { get; set; }

        [StringLength(60)]
        public string SchoolAdminName { get; set; }

        [StringLength(24)]
        public string SchoolLandline { get; set; }

        [StringLength(4000)]
        public string SchoolAddress { get; set; }

        public DateTime RegisteredAt { get; set; }

        public virtual AzmoonCity AzmoonCity { get; set; }

        public virtual AzmoonProvince AzmoonProvince { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NowruzCampRegisterationCode> NowruzCampRegisterationCodes { get; set; }
    }
}
