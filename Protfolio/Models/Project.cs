using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Protfolio.Models
{
    public class Project
    {
       

        [Key]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Column("Upload Date")]
        public DateTime UploadDate { get; set; }

        [DataType(DataType.Url)]
        public string Video { get; set; }

       
        public string Image { get; set; }

        [DataType(DataType.Url)]
        [Column("Github Link")]
        public string  GitLink { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string Description { get; set; }
        public string tagListing { get; set; }
       

        
    }

    public class ProjectContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        
    }
}