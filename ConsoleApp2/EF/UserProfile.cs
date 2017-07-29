namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserProfile")]
    public partial class UserProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UserId { get; set; }

        [StringLength(60)]
        public string NationalId { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool? Gender { get; set; }

        public long? StudentCode { get; set; }

        public long? Province { get; set; }

        public long? City { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(60)]
        public string Landline { get; set; }

        [StringLength(5)]
        public string LandlineAreaCode { get; set; }

        public int? Job { get; set; }

        public bool? Married { get; set; }

        [StringLength(4000)]
        public string Address { get; set; }

        public int? EducationDegree { get; set; }

        public virtual User User { get; set; }
    }
}
