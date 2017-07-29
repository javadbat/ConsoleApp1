namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreScreenShot")]
    public partial class StoreScreenShot
    {
        [Key]
        public int ScreenShotId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public long ProductId { get; set; }

        public virtual StoreProduct StoreProduct { get; set; }
    }
}
