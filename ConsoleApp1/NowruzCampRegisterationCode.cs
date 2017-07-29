namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NowruzCampRegisterationCode")]
    public partial class NowruzCampRegisterationCode
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NowruzCampRegisterationCodeId { get; set; }

        [Required]
        [StringLength(16)]
        public string Code { get; set; }

        [Required]
        [StringLength(16)]
        public string Serial { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime ExpireAt { get; set; }

        public DateTime? ConsumedAt { get; set; }

        public long? ConsumedBy { get; set; }

        public long NowruzCampId { get; set; }

        public virtual NowruzCamp NowruzCamp { get; set; }

        public virtual NowruzCampRegister NowruzCampRegister { get; set; }
    }
}
