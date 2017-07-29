namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookInListView")]
    public partial class BookInListView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(255)]
        public string Authors { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string Tags { get; set; }

        public string Grades { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime DatePublished { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsEnabled { get; set; }
    }
}
