namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SecurityClient")]
    public partial class SecurityClient
    {
        [Key]
        [StringLength(200)]
        public string ClientId { get; set; }

        [StringLength(500)]
        public string SecretKey { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public int RefreshTokenLifeTime { get; set; }

        [Required]
        [StringLength(500)]
        public string AllowedOrigin { get; set; }

        [Required]
        [StringLength(500)]
        public string ClientType { get; set; }
    }
}
