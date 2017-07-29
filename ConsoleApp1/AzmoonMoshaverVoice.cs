namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonMoshaverVoice")]
    public partial class AzmoonMoshaverVoice
    {
        public int AzmoonMoshaverVoiceId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        public DateTime CreatedAt { get; set; }

        public int? GradeId { get; set; }

        public virtual Grade Grade { get; set; }
    }
}
