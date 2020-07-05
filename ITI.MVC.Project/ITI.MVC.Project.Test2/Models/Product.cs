using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ITI.MVC.Project.Test2.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
        [DataType(DataType.Upload)]
        public string Image { get; set; }
        [NotMapped]
        public HttpPostedFileBase image_data { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public string Date { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public int? Offer { get; set; }
        public bool Shipping { get; set; }
        [DefaultValue("Pending")]
        public string Status { get; set; }
        [ForeignKey("Subcategory")]
        public int FK_Subcategory { get; set; }
        public Subcategory Subcategory { get; set; }
        [ForeignKey("Brand")]
        public int FK_Brand { get; set; }
        public Brand Brand { get; set; }
        [Required]
        [ForeignKey("seller")]
        public int FK_seller { get; set; }
        public virtual Seller seller { get; set; }
        public string KeyWord { get; set; }


    }
}