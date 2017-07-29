namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExchangeAgahiBook")]
    public partial class ExchangeAgahiBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long AgahiId { get; set; }

        [StringLength(500)]
        public string PageShortage { get; set; }

        [StringLength(500)]
        public string Rupture { get; set; }

        [StringLength(500)]
        public string Underline { get; set; }

        [StringLength(500)]
        public string Highlight { get; set; }

        [StringLength(500)]
        public string Annotation { get; set; }

        public int BookStateId { get; set; }

        [StringLength(500)]
        public string Editors { get; set; }

        [StringLength(9)]
        public string PublishedYearAt { get; set; }

        public int? Edition { get; set; }

        [StringLength(1000)]
        public string Authors { get; set; }

        [StringLength(1000)]
        public string Translators { get; set; }

        [StringLength(1000)]
        public string Publication { get; set; }

        public virtual ExchangeBookState ExchangeBookState { get; set; }
    }
}
