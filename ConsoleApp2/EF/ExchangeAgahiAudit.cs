namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExchangeAgahiAudit")]
    public partial class ExchangeAgahiAudit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long UserId { get; set; }

        public long AgahiId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool IsApproved { get; set; }

        [Column(TypeName = "money")]
        public decimal? CoverPrice { get; set; }

        public int Weight { get; set; }

        public int? Count { get; set; }

        public byte ApprovalStatusId { get; set; }
    }
}
