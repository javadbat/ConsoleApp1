namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonMoaref")]
    public partial class AzmoonMoaref
    {
        [Key]
        public int MoarefId { get; set; }

        public int Code { get; set; }

        public int DiscountPercent { get; set; }
    }
}
