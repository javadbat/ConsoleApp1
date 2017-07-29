namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SecurityGroup")]
    public partial class SecurityGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long GroupId { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }
    }
}
