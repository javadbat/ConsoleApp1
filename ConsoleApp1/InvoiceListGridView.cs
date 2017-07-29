namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceListGridView")]
    public partial class InvoiceListGridView
    {
        public long? id { get; set; }

        public long? InvoiceId { get; set; }

        public long? PaymentId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SaleReferenceId { get; set; }

        public DateTime? CreatedAt { get; set; }

        [StringLength(337)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string SendMethodDisplayName { get; set; }

        public byte? Status { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [StringLength(255)]
        public string StatusDisplayName { get; set; }

        public byte? StatusId { get; set; }

        public bool? PaymentSuccessStatus { get; set; }

        [StringLength(30)]
        public string PaymentSourceTitle { get; set; }

        public byte? PaymentSourceId { get; set; }

        public bool? IsNotDefualtDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayingPrice { get; set; }
    }
}
