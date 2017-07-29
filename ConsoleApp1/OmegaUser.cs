namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OmegaUser")]
    public partial class OmegaUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Landline { get; set; }

        [StringLength(50)]
        public string AreaCode { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int Job { get; set; }

        public int Sex { get; set; }

        public int Married { get; set; }

        public int? Cognation { get; set; }

        public int? StateId { get; set; }

        public int? CityId { get; set; }

        public int Grade { get; set; }

        [StringLength(255)]
        public string RefCode { get; set; }

        public virtual User User { get; set; }
    }
}
