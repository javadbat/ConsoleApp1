namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonPackage")]
    public partial class AzmoonPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonPackage()
        {
            AzmoonKarnamehReceipts = new HashSet<AzmoonKarnamehReceipt>();
            AzmoonPackageDars = new HashSet<AzmoonPackageDar>();
            AzmoonUserAnswers = new HashSet<AzmoonUserAnswer>();
        }

        public int AzmoonPackageId { get; set; }

        public int ServerAzmoonGradeId { get; set; }

        public int AzmoonOnlineId { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }

        public int OmoomiSelectNo { get; set; }

        public int EkhtesasiSelectNo { get; set; }

        [Required]
        [StringLength(255)]
        public string OmoomiQuestionPdf { get; set; }

        [Required]
        [StringLength(255)]
        public string EkhtesasiQuestionPdf { get; set; }

        [Required]
        [StringLength(2000)]
        public string OmoomiKelid { get; set; }

        [Required]
        [StringLength(2000)]
        public string EkhtesasiKelid { get; set; }

        public byte AzmoonSalId { get; set; }

        public int CreateBy { get; set; }

        public int? EditBy { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? EditAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonKarnamehReceipt> AzmoonKarnamehReceipts { get; set; }

        public virtual AzmoonOnline AzmoonOnline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonPackageDar> AzmoonPackageDars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonUserAnswer> AzmoonUserAnswers { get; set; }
    }
}
