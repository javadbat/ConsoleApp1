namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExchangeCategory")]
    public partial class ExchangeCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExchangeCategory()
        {
            ExchangeCategory1 = new HashSet<ExchangeCategory>();
            ExchangeAgahis = new HashSet<ExchangeAgahi>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CategoryId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string IconUrl { get; set; }

        public bool IsEnabled { get; set; }

        public int SortOrder { get; set; }

        public long? ParentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangeCategory> ExchangeCategory1 { get; set; }

        public virtual ExchangeCategory ExchangeCategory2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangeAgahi> ExchangeAgahis { get; set; }
    }
}
