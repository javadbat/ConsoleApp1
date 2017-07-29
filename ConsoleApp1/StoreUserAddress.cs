namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreUserAddress")]
    public partial class StoreUserAddress
    {
        [Key]
        public long UserAddressId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Family { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(60)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(60)]
        public string Landline { get; set; }

        [Required]
        [StringLength(24)]
        public string AreaCode { get; set; }

        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(60)]
        public string PostalCode { get; set; }

        public long UserId { get; set; }

        public int CityId { get; set; }

        public int StateId { get; set; }

        public virtual City City { get; set; }

        public virtual State State { get; set; }

        public virtual User User { get; set; }
    }
}
