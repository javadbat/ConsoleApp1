namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AzmoonPackageJozeDar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AzmoonPackageDarsId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AzmoonJozeDarsId { get; set; }

        public int StartAt { get; set; }

        public int EndAt { get; set; }

        public virtual AzmoonJozeDar AzmoonJozeDar { get; set; }

        public virtual AzmoonPackageDar AzmoonPackageDar { get; set; }
    }
}
