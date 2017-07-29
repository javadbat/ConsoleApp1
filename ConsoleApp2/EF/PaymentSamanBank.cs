namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentSamanBank")]
    public partial class PaymentSamanBank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PaymentId { get; set; }

        [StringLength(255)]
        public string Token { get; set; }

        public long? TraceNo { get; set; }

        public int? ResNum { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string RefId { get; set; }

        public virtual Payment Payment { get; set; }
    }
}
