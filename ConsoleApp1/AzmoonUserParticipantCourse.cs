namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonUserParticipantCourse")]
    public partial class AzmoonUserParticipantCourse
    {
        public long AzmoonUserParticipantCourseId { get; set; }

        public int AzmoonOnlineId { get; set; }

        public long UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string ParticipantDarsIdsString { get; set; }

        public bool Archived { get; set; }

        public DateTime? ArchivedAt { get; set; }

        public virtual AzmoonOnline AzmoonOnline { get; set; }

        public virtual User User { get; set; }
    }
}
