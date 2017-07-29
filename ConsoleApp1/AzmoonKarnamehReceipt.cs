namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonKarnamehReceipt")]
    public partial class AzmoonKarnamehReceipt
    {
        public int AzmoonKarnamehReceiptId { get; set; }

        public int AzmoonPackageId { get; set; }

        public DateTime SendAt { get; set; }

        public virtual AzmoonPackage AzmoonPackage { get; set; }
    }
}
