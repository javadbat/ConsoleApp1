namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AzmoonData")]
    public partial class AzmoonData
    {
        public int AzmoonDataId { get; set; }

        public int YearFa { get; set; }

        public int GradeId { get; set; }

        public string Data { get; set; }

        public virtual Grade Grade { get; set; }
    }
}
