namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoreComment")]
    public partial class CoreComment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoreComment()
        {
            CoreComment1 = new HashSet<CoreComment>();
        }

        [Key]
        public long CommentId { get; set; }

        [Required]
        [StringLength(4000)]
        public string Description { get; set; }

        public long UserId { get; set; }

        public long SourceId { get; set; }

        public long DownVote { get; set; }

        public long UpVote { get; set; }

        [StringLength(160)]
        public string IP { get; set; }

        public bool IsApproved { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public long? ParentId { get; set; }

        public bool IsGajReplied { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoreComment> CoreComment1 { get; set; }

        public virtual CoreComment CoreComment2 { get; set; }
    }
}
