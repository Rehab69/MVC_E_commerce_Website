using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITI.MVC.Project.Test2.Models
{
    public class CartItem
    {
        public int ItemId { get; set; }

        //public int CartId { get; set; }
        internal int quantity;
        public int Quantity { get; set; }

        //public System.DateTime DateCreated { get; set; }

        //public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public CartItem() { }
        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}