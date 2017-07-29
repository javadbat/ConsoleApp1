namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceUserAddressListGridView")]
    public partial class InvoiceUserAddressListGridView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long InvoiceId { get; set; }

        [StringLength(337)]
        public string Username { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(24)]
        public string PhoneNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(49)]
        public string Landline { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(60)]
        public string PostalCode { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CreatedAt { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte StatusId { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? ItemCount { get; set; }

        [StringLength(255)]
        public string SendMethodDisplayName { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte SendMethodId { get; set; }

        public int? WeightSum { get; set; }
    }
}
