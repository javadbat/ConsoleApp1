namespace ConsoleApp2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Grade")]
    public partial class Grade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grade()
        {
            Grade1 = new HashSet<Grade>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GradeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public bool IsEnabled { get; set; }

        public int SortOrder { get; set; }

        [StringLength(255)]
        public string Icon { get; set; }

        [StringLength(255)]
        public string Cover { get; set; }

        public int? ParentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grade1 { get; set; }

        public virtual Grade Grade2 { get; set; }
    }
}
