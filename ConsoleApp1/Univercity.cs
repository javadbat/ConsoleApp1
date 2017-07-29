namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Univercity")]
    public partial class Univercity
    {
        [Key]
        public int UniversityId { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }

        [StringLength(120)]
        public string CityName { get; set; }

        public int MajorId { get; set; }
    }
}
