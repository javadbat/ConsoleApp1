namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonUserAnswer")]
    public partial class AzmoonUserAnswer
    {
        public int AzmoonUserAnswerId { get; set; }

        public long UserId { get; set; }

        public int AzmoonPackageId { get; set; }

        public int AzmoonDarsId { get; set; }

        [StringLength(2000)]
        public string Result { get; set; }

        public virtual AzmoonDar AzmoonDar { get; set; }

        public virtual AzmoonPackage AzmoonPackage { get; set; }

        public virtual User User { get; set; }
    }
}
