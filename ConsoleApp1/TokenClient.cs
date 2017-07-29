namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TokenClient")]
    public partial class TokenClient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TokenClientId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string SecretKey { get; set; }
    }
}
