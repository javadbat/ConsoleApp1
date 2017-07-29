namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreAppRelease")]
    public partial class StoreAppRelease
    {
        [Key]
        public int AppReleaseId { get; set; }

        public int VersionCode { get; set; }

        [Required]
        [StringLength(255)]
        public string VersionName { get; set; }

        public int ReleaseNumber { get; set; }

        public int MinSdk { get; set; }

        public int Size { get; set; }

        public long DownloadCount { get; set; }

        public int State { get; set; }

        [StringLength(255)]
        public string Icon { get; set; }

        [StringLength(255)]
        public string Video { get; set; }

        [StringLength(255)]
        public string Cover { get; set; }

        public bool IsForceUpdate { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long ProductId { get; set; }

        public bool IsEnabled { get; set; }

        public virtual StoreApp StoreApp { get; set; }
    }
}
