namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchoolProfile")]
    public partial class SchoolProfile
    {
        public long SchoolProfileId { get; set; }

        [Required]
        [StringLength(255)]
        public string SchoolName { get; set; }

        [Required]
        [StringLength(4000)]
        public string Address { get; set; }

        [Required]
        [StringLength(16)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string ManagerName { get; set; }

        public long UserId { get; set; }

        public bool IsVertify { get; set; }

        public virtual User User { get; set; }
    }
}
