namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonRepresentiveLandLine")]
    public partial class AzmoonRepresentiveLandLine
    {
        [Key]
        public int RepresentativeLandlineId { get; set; }

        [Required]
        [StringLength(24)]
        public string AreaCode { get; set; }

        [Required]
        [StringLength(24)]
        public string Landline { get; set; }

        public int RepresentativeId { get; set; }

        public virtual AzmoonRepresentive AzmoonRepresentive { get; set; }
    }
}
