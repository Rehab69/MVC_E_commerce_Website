using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ITI.MVC.Project.Test2.Models
{
    public class Subcategory
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey("category")]
        public int Fk_category { get; set; }
        public virtual Category category { get; set; }

        public List<Product> products = new List<Product>();
    }
}