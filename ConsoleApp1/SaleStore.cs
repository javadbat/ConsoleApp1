namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleStore")]
    public partial class SaleStore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaleStore()
        {
            SaleStoreLandLines = new HashSet<SaleStoreLandLine>();
        }

        public int SaleStoreId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(24)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Director { get; set; }

        [Required]
        public string Address { get; set; }

        [StringLength(60)]
        public string GoogleMapCode { get; set; }

        public int CityId { get; set; }

        public int StateId { get; set; }

        public string WorkDay { get; set; }

        public string HoursofWork { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime CreatedAt { get; set; }

        public long? CreatedBy { get; set; }

        public long? EditedBy { get; set; }

        public virtual City City { get; set; }

        public virtual State State { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleStoreLandLine> SaleStoreLandLines { get; set; }
    }
}
