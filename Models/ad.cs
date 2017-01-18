namespace cftest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("cftestdb.ad")]
    public partial class ad
    {
        public int id { get; set; }

        
        public string title { get; set; }

        
        public string imageURL { get; set; }

        public int? category { get; set; }

        [Column(TypeName = "date")]
        public DateTime? publishedDate { get; set; }
    }

    public class adsDBcontext : DbContext
    {
        public DbSet<ad> Ads { get; set; }

    }


}
