namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentMellatBank")]
    public partial class PaymentMellatBank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PaymentId { get; set; }

        [StringLength(255)]
        public string RefId { get; set; }

        public int PaymentResCode { get; set; }

        public long? SaleReferenceId { get; set; }

        public int? SettleResCode { get; set; }

        public long? SaleOrderId { get; set; }

        public virtual Payment Payment { get; set; }
    }
}
