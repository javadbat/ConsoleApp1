namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CrashReport")]
    public partial class CrashReport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CrashReportId { get; set; }

        [Required]
        [StringLength(160)]
        public string ReportId { get; set; }

        [Required]
        public string DeviceFeatures { get; set; }

        [Required]
        [StringLength(60)]
        public string PhoneModel { get; set; }

        [Required]
        [StringLength(60)]
        public string AndroidVersion { get; set; }

        [Required]
        [StringLength(160)]
        public string PackageName { get; set; }

        public int VersionCode { get; set; }

        [Required]
        public string CrashConfiguration { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required]
        public string Build { get; set; }

        [Required]
        public string StackTrace { get; set; }

        [Required]
        public string Display { get; set; }

        [Required]
        [StringLength(120)]
        public string VersionName { get; set; }

        public long AvailableMemorySize { get; set; }

        [Required]
        [StringLength(120)]
        public string Brand { get; set; }

        [Required]
        public string InitialConfiguration { get; set; }

        public long TotalMemorySize { get; set; }

        [Required]
        [StringLength(255)]
        public string FilePath { get; set; }

        [Required]
        public string Environment { get; set; }

        public long ProductId { get; set; }

        public virtual StoreApp StoreApp { get; set; }
    }
}
