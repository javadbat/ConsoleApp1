namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AzmoonPreRegisterStatu
    {
        [Key]
        public int AzmoonPreRegisterStatusId { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }
    }
}
