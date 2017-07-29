namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flag")]
    public partial class Flag
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ParentId { get; set; }

        public long? UserId { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CreatedAt { get; set; }
    }
}
