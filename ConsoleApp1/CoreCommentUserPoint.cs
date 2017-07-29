namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoreCommentUserPoint")]
    public partial class CoreCommentUserPoint
    {
        [Key]
        public long UserPointId { get; set; }

        public long UserId { get; set; }

        public long SourceId { get; set; }

        public byte Point { get; set; }
    }
}
