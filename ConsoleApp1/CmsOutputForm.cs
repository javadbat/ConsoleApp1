namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CmsOutputForm")]
    public partial class CmsOutputForm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long TreeId { get; set; }

        [StringLength(4000)]
        public string PreTitle { get; set; }

        [StringLength(4000)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string Summery { get; set; }

        public string Text { get; set; }

        public short? Status { get; set; }

        public long? ViewAccessGroupId { get; set; }

        public bool? ActiveShowTime { get; set; }

        public DateTime? ShowTimeStart { get; set; }

        public DateTime? ShowTimeEnd { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public long? CreatorUserId { get; set; }

        [StringLength(50)]
        public string CreatorUserIp { get; set; }

        [StringLength(4000)]
        public string CreatorUserNameAndFamily { get; set; }

        public DateTime? ModifyDateTime { get; set; }

        public long? ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserIp { get; set; }

        [StringLength(4000)]
        public string ModifyUserNameAndFamily { get; set; }

        public DateTime? PublishDateTime { get; set; }

        public long? PublishUserId { get; set; }

        [StringLength(50)]
        public string PublishUserIp { get; set; }

        [StringLength(4000)]
        public string PublishUserNameAndFamily { get; set; }

        public int? UserCounter { get; set; }

        public int? HitCounter { get; set; }

        [StringLength(4000)]
        public string DescriptionTag { get; set; }

        [StringLength(4000)]
        public string KeywordsTag { get; set; }

        [StringLength(500)]
        public string Author { get; set; }

        [StringLength(4000)]
        public string AuthorUrl { get; set; }

        [StringLength(500)]
        public string Source { get; set; }

        [StringLength(4000)]
        public string SourceUrl { get; set; }

        public short? Robot { get; set; }

        [StringLength(4000)]
        public string SmallImage { get; set; }

        [StringLength(4000)]
        public string SmallImageAlt { get; set; }

        [StringLength(4000)]
        public string NormalImage { get; set; }

        [StringLength(4000)]
        public string NormalImageAlt { get; set; }

        [StringLength(4000)]
        public string BigImage { get; set; }

        [StringLength(4000)]
        public string BigImageAlt { get; set; }

        public double? RatingValue { get; set; }

        public DateTime? LadtVisitDateTime { get; set; }

        public bool? IsSpecial { get; set; }

        public bool? IsSelected { get; set; }

        public bool? ActiveShare { get; set; }

        public bool? ShowToolbar { get; set; }

        public bool? ShowToolbarPrint { get; set; }

        public bool? ShowToolbarMail { get; set; }

        public bool? ShowCommentForm { get; set; }

        public bool? ShowComment { get; set; }

        public bool? ShowDetails { get; set; }

        public bool? ShowPublishDetails { get; set; }

        public bool? ShowCreationDateTime { get; set; }

        public bool? ShowCreationUserNameAndFamily { get; set; }

        public bool? ShowModifyDateTime { get; set; }

        public bool? ShowModifyUserNameAndFamily { get; set; }

        public bool? ShowPublishDateTime { get; set; }

        public bool? ShowPublishUserNameAndFamily { get; set; }

        public bool? ShowUserCounter { get; set; }

        public bool? ShowHitCounter { get; set; }

        public bool? ShowRating { get; set; }

        public bool? ShowLadtVisitDateTime { get; set; }

        public int? ShowOrder { get; set; }

        [StringLength(255)]
        public string VideoUrl { get; set; }

        public virtual Tree Tree { get; set; }
    }
}
