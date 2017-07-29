namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tree")]
    public partial class Tree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long ParentId { get; set; }

        public long ModuleId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(4000)]
        public string Path { get; set; }

        public int Status { get; set; }

        public bool HasChild { get; set; }

        public int ShowOrder { get; set; }
    }
}
