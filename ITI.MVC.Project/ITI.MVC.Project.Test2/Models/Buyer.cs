using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ITI.MVC.Project.Test2.Models
{
    public class Buyer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string LocationType { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Area { get; set; }
        [Required]
        public string StreetName { get; set; }
        public string ShippingNote { get; set; }
        [Required(ErrorMessage = "Card Type is required")]
        [Display(Name = "Card Type")]
        [StringLength(20)]
        public string CardType { get; set; }
        [Required(ErrorMessage = "Card Holders Name is required")]
        [Display(Name = "Card Holders Name")]
        [StringLength(160)]
        public string CardHoldersName { get; set; }
        [DataType(DataType.CreditCard)]
        public int CardNumber { get; set; }
        public int CardExpMonth { get; set; }
        public int CardExpYear { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        public virtual ApplicationUser AppUser { get; set; }
    }
}