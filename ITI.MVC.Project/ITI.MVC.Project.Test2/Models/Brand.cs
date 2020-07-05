using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ITI.MVC.Project.Test2.Models
{
    public class Brand
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Product> products = new List<Product>();
    }
}