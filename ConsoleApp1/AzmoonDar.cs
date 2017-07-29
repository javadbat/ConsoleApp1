namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AzmoonDar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AzmoonDar()
        {
            AzmoonJozeDars = new HashSet<AzmoonJozeDar>();
            AzmoonUserAnswers = new HashSet<AzmoonUserAnswer>();
            Users = new HashSet<User>();
        }

        [Key]
        public int AzmoonDarsId { get; set; }

        public int ServerAzmoonGradeId { get; set; }

        [Required]
        [StringLength(120)]
        public string Title { get; set; }

        public bool IsPublic { get; set; }

        public int Code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonJozeDar> AzmoonJozeDars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonUserAnswer> AzmoonUserAnswers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
