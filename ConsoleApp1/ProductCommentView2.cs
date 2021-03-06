namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductCommentView2
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CommentId { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CreatedAt { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4000)]
        public string Description { get; set; }

        [StringLength(181)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UserId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SourceId { get; set; }

        [StringLength(336)]
        public string ProductTitle { get; set; }

        public int? GradeId { get; set; }

        [StringLength(50)]
        public string GradeName { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsApproved { get; set; }

        public long? ParentId { get; set; }

        [StringLength(4000)]
        public string ReplayAtDescription { get; set; }
    }
}
