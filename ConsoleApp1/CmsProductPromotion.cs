namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CmsProductPromotion")]
    public partial class CmsProductPromotion
    {
        [Key]
        public int PromotionId { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageUrl { get; set; }

        public long ProductId { get; set; }

        public int SortOrder { get; set; }

        public bool IsEnabled { get; set; }

        public int? GradeId { get; set; }

        public virtual StoreApp StoreApp { get; set; }

        public virtual Grade Grade { get; set; }
    }
}
