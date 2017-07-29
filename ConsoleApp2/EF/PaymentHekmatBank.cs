namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentHekmatBank")]
    public partial class PaymentHekmatBank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PaymentId { get; set; }

        [StringLength(255)]
        public string TransactionCode { get; set; }

        public int PaymentResCode { get; set; }

        public virtual Payment Payment { get; set; }
    }
}
