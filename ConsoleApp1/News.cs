namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public News()
        {
            NewsGalleries = new HashSet<NewsGallery>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NewsId { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public DateTime EventDate { get; set; }

        public bool IsEnabled { get; set; }

        public byte Type { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Body { get; set; }

        [Required]
        [StringLength(38)]
        public string TumbnailPictureName { get; set; }

        [Required]
        [StringLength(38)]
        public string ListPictureName { get; set; }

        [Required]
        [StringLength(38)]
        public string OrginalPictureName { get; set; }

        public DateTime CreatedAt { get; set; }

        public long RegistrantUserId { get; set; }

        public DateTime EditedAt { get; set; }

        public long EditorUserId { get; set; }

        public bool IsDeleted { get; set; }

        public long VisitCount { get; set; }

        [StringLength(1000)]
        public string Tags { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsGallery> NewsGalleries { get; set; }
    }
}
