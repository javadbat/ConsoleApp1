namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModuleGetaway")]
    public partial class ModuleGetaway
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModuleId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GetawayId { get; set; }

        public bool IsEnabled { get; set; }

        public int SortOrder { get; set; }

        public virtual Module Module { get; set; }

        public virtual PaymentGetaway PaymentGetaway { get; set; }
    }
}
