namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GcmDevice")]
    public partial class GcmDevice
    {
        public long GcmDeviceId { get; set; }

        [Required]
        [StringLength(255)]
        public string RegistrationId { get; set; }

        public DateTime CreatedAt { get; set; }

        public long? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
