using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITI.MVC.Project.Test2.Models
{
    public class Category
    {
        public Category()
        {
            this.Subcategories = new HashSet<Subcategory>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Subcategory> Subcategories { get; set; }
    }
}