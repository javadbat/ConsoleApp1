namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnalyticsRedirect")]
    public partial class AnalyticsRedirect
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long AnalyticsId { get; set; }

        [Required]
        [StringLength(128)]
        public string IP { get; set; }

        [StringLength(255)]
        public string Referer { get; set; }

        public byte Type { get; set; }

        [Required]
        [StringLength(255)]
        public string Url { get; set; }
    }
}
