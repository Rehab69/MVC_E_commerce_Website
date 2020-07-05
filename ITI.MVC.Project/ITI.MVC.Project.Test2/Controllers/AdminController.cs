using ITI.MVC.Project.Test2.Models;
using ITI.MVC.Project.Test2.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.MVC.Project.Test2.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET: Admin
        public ActionResult AdminProfile()
        {
            GeneralViewModel GVM = new GeneralViewModel();
            GVM.HVM.categories = context.categories.ToList();
            GVM.HVM.subcategories = context.subcategories.ToList();
            return View(GVM);
        }
        [HttpGet]
        public ActionResult Sellers()
        {
            GeneralViewModel GVM = new GeneralViewModel();
            GVM.HVM.categories = context.categories.ToList();
            GVM.HVM.subcategories = context.subcategories.ToList();
            GVM.HVM.sellers = context.seller.ToList();

            return View(GVM);
        }

        public bool DeleteSeller(int id)
        {
            Seller seller = context.seller.Find(id);
            if (seller != null)
            {
                context.seller.Remove(seller);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ConfirmSeller(int id)
        {
            Seller seller = context.seller.Find(id);
                if (seller != null)
                {
                    seller.Status = "Confirmed";
                    context.Entry(seller).State = EntityState.Modified;
                    if (ModelState.IsValid)
                    {
                        context.SaveChanges();
                    }
                    return true;
                }
            return false;
        }
        
        public ActionResult Products()
        {
            GeneralViewModel GVM = new GeneralViewModel();
            GVM.HVM.categories = context.categories.ToList();
            GVM.HVM.subcategories = context.subcategories.ToList();
            GVM.HVM.products = context.products.ToList();
            GVM.HVM.brands = context.brands.ToList();
            return View(GVM);
        }

        public bool DeleteProduct(int id)
        {
            Product product = context.products.Find(id);
            if (product != null)
            {
                context.products.Remove(product);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ConfirmProduct(int id)
        {
            Product product = context.products.Find(id);
            if (product != null)
            {
                product.Status = "Confirmed";
                context.Entry(product).State = EntityState.Modified;
                if (ModelState.IsValid)
                {
                    context.SaveChanges();
                }
                return true;
            }
            return false;
        }
    }
}