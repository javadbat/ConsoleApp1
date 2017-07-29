namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonTopRankPerson")]
    public partial class AzmoonTopRankPerson
    {
        [Key]
        public int TopRankPersonId { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonName { get; set; }

        public byte StudyField { get; set; }

        public int StateId { get; set; }

        public int CityId { get; set; }

        public int Rank { get; set; }

        [Required]
        [StringLength(4)]
        public string Year { get; set; }

        public bool IsDelete { get; set; }

        public DateTime CreatedAt { get; set; }

        public long? CreatedBy { get; set; }

        public long? EditedBy { get; set; }

        public DateTime? EditedAt { get; set; }

        public virtual State State { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
