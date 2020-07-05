using ITI.MVC.Project.Test2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITI.MVC.Project.Test2.ViewModels
{
    public class HomeViewModel
    {
        public List<Seller> sellers = new List<Seller>();

        public Seller seller { get; set; }

        public Product product { get; set; }

        public List<Product> products = new List<Product>();

        public List<Category> categories = new List<Category>();

        public List<Subcategory> subcategories = new List<Subcategory>();

        public List<Brand> brands = new List<Brand>();

        public Brand brand { get; set; }

    }
}