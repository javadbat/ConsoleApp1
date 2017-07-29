namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExchangeBookState")]
    public partial class ExchangeBookState
    {
        public int ExchangeBookStateId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
    }
}
