namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dictionary")]
    public partial class Dictionary
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Culture { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(4000)]
        public string Value { get; set; }
    }
}
