namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModuleAccess")]
    public partial class ModuleAccess
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModuleAccessId { get; set; }

        public int ModuleId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual Module Module { get; set; }
    }
}
