namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleStoreLandLine")]
    public partial class SaleStoreLandLine
    {
        public int SaleStoreLandlineId { get; set; }

        [StringLength(24)]
        public string AreaCode { get; set; }

        [Required]
        [StringLength(24)]
        public string Landline { get; set; }

        public int SaleStoreId { get; set; }

        public virtual SaleStore SaleStore { get; set; }
    }
}
