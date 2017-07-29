namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        public long PaymentId { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(128)]
        public string IP { get; set; }

        public long UserId { get; set; }

        public int GetawayId { get; set; }

        [StringLength(255)]
        public string ModuleCallBack { get; set; }

        public int ModuleId { get; set; }

        [Required]
        [StringLength(255)]
        public string ModuleToken { get; set; }

        public int? VerifyResCode { get; set; }

        public DateTime PaidAt { get; set; }

        public int StatusId { get; set; }

        [Required]
        [StringLength(255)]
        public string AdditionalData { get; set; }

        public long? ReferenceId { get; set; }

        [Required]
        [StringLength(255)]
        public string UserAgent { get; set; }

        public virtual Module Module { get; set; }

        public virtual PaymentPasargadBank PaymentPasargadBank { get; set; }

        public virtual PaymentHekmatBank PaymentHekmatBank { get; set; }

        public virtual PaymentMellatBank PaymentMellatBank { get; set; }

        public virtual PaymentGetaway PaymentGetaway { get; set; }

        public virtual PaymentSamanBank PaymentSamanBank { get; set; }
    }
}
