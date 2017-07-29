namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CmsSlideShow")]
    public partial class CmsSlideShow
    {
        [Key]
        public int SlideShowId { get; set; }

        [Required]
        [StringLength(128)]
        public string ImageName { get; set; }

        [StringLength(255)]
        public string LinkURL { get; set; }

        public byte Sort { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool IsEnabled { get; set; }

        public byte? UsagePlace { get; set; }

        public long? CreatedBy { get; set; }

        public long? EditedBy { get; set; }
    }
}
