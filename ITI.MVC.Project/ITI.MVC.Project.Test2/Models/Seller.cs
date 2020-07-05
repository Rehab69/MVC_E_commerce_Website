using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ITI.MVC.Project.Test2.Models
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string StoreName { get; set; }
        [DataType(DataType.Upload)]
        public string IdFrontPath { get; set; }
        [DataType(DataType.Upload)]
        public string IdBackPath { get; set; }
        [NotMapped]
        public HttpPostedFileBase FrontImageFile { get; set; }
        [NotMapped]
        public HttpPostedFileBase BackImageFile { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DefaultValue("Pending")]
        public string Status { get; set; }
        [Required]
        public string FK_User { get; set; }

        public virtual List<Product> products { get; set; }
    }
}