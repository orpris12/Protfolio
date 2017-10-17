using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Protfolio.Models
{
    public class Tag
    {
        public Tag()
        {
            projects = new List<Project>();
        }
       List<Project> projects { get; set; }
        [Key]
        public int tagID { get; set; }
        public string Name { get; set; }
    }
}