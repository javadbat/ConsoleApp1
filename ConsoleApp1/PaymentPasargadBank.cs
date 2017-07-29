namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentPasargadBank")]
    public partial class PaymentPasargadBank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PaymentId { get; set; }

        public int? InvoiceNumber { get; set; }

        public long? TransactionReferenceId { get; set; }

        public int? TraceNumber { get; set; }

        public int? ReferenceNumber { get; set; }

        [StringLength(255)]
        public string VerifyMessage { get; set; }

        public virtual Payment Payment { get; set; }
    }
}
