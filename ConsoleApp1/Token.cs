namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Token")]
    public partial class Token
    {
        [Key]
        [StringLength(100)]
        public string RefreshToken { get; set; }

        [Required]
        public string AccessToken { get; set; }

        public long UserId { get; set; }

        public byte ClientId { get; set; }

        public DateTime Issued { get; set; }

        public DateTime Expires { get; set; }

        public int ExpiresIn { get; set; }

        [Required]
        [StringLength(20)]
        public string Ip { get; set; }
    }
}
