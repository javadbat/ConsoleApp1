namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreBook")]
    public partial class StoreBook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StoreBook()
        {
            StoreBookAuthors = new HashSet<StoreBookAuthor>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ProductId { get; set; }

        public byte State { get; set; }

        public int Stock { get; set; }

        [StringLength(255)]
        public string Publihser { get; set; }

        [StringLength(60)]
        public string ISBN { get; set; }

        public int Pages { get; set; }

        public DateTime DatePublished { get; set; }

        [StringLength(255)]
        public string FolioSize { get; set; }

        [StringLength(255)]
        public string SamplePDF { get; set; }

        public int Code { get; set; }

        public int Submission { get; set; }

        public int Edition { get; set; }

        public bool IsIllustrated { get; set; }

        public int CopyCount { get; set; }

        public int BookTypeId { get; set; }

        public virtual StoreProduct StoreProduct { get; set; }

        public virtual StoreBookType StoreBookType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreBookAuthor> StoreBookAuthors { get; set; }
    }
}
