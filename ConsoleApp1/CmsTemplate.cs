namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CmsTemplate")]
    public partial class CmsTemplate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public string Header { get; set; }

        [Required]
        public string Body { get; set; }

        [StringLength(4000)]
        public string Separator { get; set; }

        public string Footer { get; set; }
    }
}
