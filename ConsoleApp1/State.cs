namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("State")]
    public partial class State
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public State()
        {
            AzmoonCampRegisters = new HashSet<AzmoonCampRegister>();
            AzmoonPreRegisters = new HashSet<AzmoonPreRegister>();
            AzmoonRepresentives = new HashSet<AzmoonRepresentive>();
            AzmoonTopRankPersons = new HashSet<AzmoonTopRankPerson>();
            Cities = new HashSet<City>();
            ExchangeAgahis = new HashSet<ExchangeAgahi>();
            SaleStores = new HashSet<SaleStore>();
            StoreInvoices = new HashSet<StoreInvoice>();
            StoreUserAddresses = new HashSet<StoreUserAddress>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StateId { get; set; }

        [Required]
        [StringLength(255)]
        public string PName { get; set; }

        [Required]
        [StringLength(255)]
        public string EName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonCampRegister> AzmoonCampRegisters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonPreRegister> AzmoonPreRegisters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonRepresentive> AzmoonRepresentives { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AzmoonTopRankPerson> AzmoonTopRankPersons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> Cities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangeAgahi> ExchangeAgahis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleStore> SaleStores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreInvoice> StoreInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreUserAddress> StoreUserAddresses { get; set; }
    }
}
