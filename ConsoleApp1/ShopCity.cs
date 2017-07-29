namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopCity")]
    public partial class ShopCity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CityId { get; set; }

        public long ProvinceId { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        public virtual ShopProvince ShopProvince { get; set; }
    }
}
