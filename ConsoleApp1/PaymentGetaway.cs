namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentGetaway")]
    public partial class PaymentGetaway
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentGetaway()
        {
            ModuleGetaways = new HashSet<ModuleGetaway>();
            Payments = new HashSet<Payment>();
        }

        [Key]
        public int GetawayId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int BankId { get; set; }

        public bool IsEnabled { get; set; }

        public long TerminalId { get; set; }

        [StringLength(160)]
        public string UserName { get; set; }

        [StringLength(160)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModuleGetaway> ModuleGetaways { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }

        public virtual PaymentBank PaymentBank { get; set; }
    }
}
