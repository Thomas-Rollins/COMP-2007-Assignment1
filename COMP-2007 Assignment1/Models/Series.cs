namespace COMP_2007_Assignment1.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Series
    {
        public int SeriesID { get; set; }

        [Required]
        [StringLength(128)]
        public string SeriesName { get; set; }

        public string Synopsis { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RunStartDate { get; set; }

        [StringLength(1024)]
        public string Producer { get; set; }

        public decimal? Raiting { get; set; }

        [StringLength(1024)]
        public string CoverArtURL { get; set; }

        public int Genre { get; set; }

        public virtual Genre Genre1 { get; set; }
    }
}
