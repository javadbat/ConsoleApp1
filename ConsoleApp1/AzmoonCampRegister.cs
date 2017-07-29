namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonCampRegister")]
    public partial class AzmoonCampRegister
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonCampRegister()
        {
            AzmoonCampRegistrationCodes = new HashSet<AzmoonCampRegistrationCode>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CampRegisterId { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }

        [Required]
        [StringLength(120)]
        public string Family { get; set; }

        public bool IsMale { get; set; }

        [Required]
        [StringLength(120)]
        public string FatherName { get; set; }

        [Required]
        [StringLength(50)]
        public string ShomareShenasname { get; set; }

        public long NationalId { get; set; }

        public DateTime? BirthDate { get; set; }

        public int GradeId { get; set; }

        [Required]
        [StringLength(24)]
        public string Landline { get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public int StateId { get; set; }

        public int CityId { get; set; }

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

        public string SchoolAddress { get; set; }

        public DateTime RegisteredAt { get; set; }

        public int CampRegisterationCodeId { get; set; }

        public virtual AzmoonCampRegistrationCode AzmoonCampRegistrationCode { get; set; }

        public virtual City City { get; set; }

        public virtual Grade Grade { get; set; }

        public virtual State State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonCampRegistrationCode> AzmoonCampRegistrationCodes { get; set; }
    }
}
