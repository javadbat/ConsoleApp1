namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaymentStatu
    {
        [Key]
        public int StatusId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }
    }
}
