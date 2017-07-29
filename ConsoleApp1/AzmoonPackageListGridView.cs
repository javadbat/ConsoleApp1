namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonPackageListGridView")]
    public partial class AzmoonPackageListGridView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AzmoonOnlineId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AzmoonPackageId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServerAzmoonGradeId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(60)]
        public string AzmoonTitle { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string GradeName { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime StartAt { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime EndAt { get; set; }
    }
}
