namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewsGallery")]
    public partial class NewsGallery
    {
        public int NewsGalleryId { get; set; }

        public long NewsId { get; set; }

        [Required]
        [StringLength(38)]
        public string PictureName { get; set; }

        public virtual News News { get; set; }
    }
}
