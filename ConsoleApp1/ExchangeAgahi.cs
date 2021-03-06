namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExchangeAgahi")]
    public partial class ExchangeAgahi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExchangeAgahi()
        {
            ExchangeCategories = new HashSet<ExchangeCategory>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long AgahiId { get; set; }

        public long UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserFamily { get; set; }

        [Required]
        [StringLength(24)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string CoverUrl { get; set; }

        [StringLength(1500)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public long TypeId { get; set; }

        public bool IsApproved { get; set; }

        [StringLength(1500)]
        public string Sharayet { get; set; }

        public int StateId { get; set; }

        public int CityId { get; set; }

        public DateTime ExpiredAt { get; set; }

        public virtual City City { get; set; }

        public virtual State State { get; set; }

        public virtual ExchangeAgahiType ExchangeAgahiType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangeCategory> ExchangeCategories { get; set; }
    }
}
