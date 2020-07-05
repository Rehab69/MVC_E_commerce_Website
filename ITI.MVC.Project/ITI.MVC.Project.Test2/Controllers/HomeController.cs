using ITI.MVC.Project.Test2.Models;
using ITI.MVC.Project.Test2.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITI.MVC.Project.Test2.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        protected ApplicationDbContext ApplicationDbContext { get; set; }
        public ApplicationDbContext context = new ApplicationDbContext();
        [AllowAnonymous]
        public ActionResult Index()
        {
            //IdentityRole Admin = new IdentityRole("Admin");
            //IdentityRole NormalUser = new IdentityRole("NormalUser");
            //IdentityRole Seller = new IdentityRole("Seller");
            //IdentityRole Buyer = new IdentityRole("Buyer");

            //RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

            //roleManager.Create(Admin);
            //roleManager.Create(NormalUser);
            //roleManager.Create(Seller);
            //roleManager.Create(Buyer);

            GeneralViewModel GVM = new GeneralViewModel();
            GVM.HVM.products = context.products.Where(x=>x.Status == "Confirmed").ToList();
            GVM.HVM.categories = context.categories.ToList();
            GVM.HVM.brands = context.brands.ToList();
            GVM.HVM.subcategories = context.subcategories.ToList();

            return View(GVM);
        }
        public ActionResult Sell()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var isSellerAlreadyExists = context.seller.ToList().Any(x => x.FK_User == user.Id);
            if (!isSellerAlreadyExists)
            {
                Seller seller = new Seller();
                seller.FK_User = user.Id;
                seller.FirstName = user.FirstName;
                GeneralViewModel GVM = new GeneralViewModel();
                GVM.seller = seller;
                GVM.HVM.categories = context.categories.ToList();
                GVM.HVM.subcategories = context.subcategories.ToList();
                return View(GVM);
            }
            else
            {
                return RedirectToAction("SellerProfile");
            }
           
        }
        [HttpPost]
        public ActionResult Sell(Seller seller)
        {
            string fileName = Path.GetFileName(seller.BackImageFile.FileName);
            seller.IdBackPath = "~/Content/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Content/"), fileName);
            seller.BackImageFile.SaveAs(fileName);

            string fileName2 = Path.GetFileName(seller.FrontImageFile.FileName);
            seller.IdFrontPath = "~/Content/" + fileName2;
            fileName2 = Path.Combine(Server.MapPath("~/Content/"), fileName2);
            seller.FrontImageFile.SaveAs(fileName2);

            seller.Status = "Pending";
            if (ModelState.IsValid)
            {
                context.seller.Add(seller);
                context.SaveChanges();

                return RedirectToAction("SellerProfile");

            }

            return View();
        }

        public ActionResult SellerProfile()
        {
            GeneralViewModel GVM = new GeneralViewModel();
            GVM.HVM.categories = context.categories.ToList();
            GVM.HVM.subcategories = context.subcategories.ToList();

            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            Seller seller = context.seller.Single(x => x.FK_User == user.Id);
            GVM.HVM.seller = seller;
            return View(GVM);
        }

        public ActionResult Product()
        {
            GeneralViewModel GVM = new GeneralViewModel();
            GVM.HVM.categories = context.categories.ToList();
            GVM.HVM.subcategories = context.subcategories.ToList();
            return View(GVM);
        }

        public JsonResult GetSubCategoryById(int ID)
        {
            context.Configuration.ProxyCreationEnabled = false;
            return Json(context.subcategories.Where(e => e.Fk_category == ID), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Product(GeneralViewModel GVM)
        {
            var isBrandAlreadyExists = context.brands.ToList().Any(x => x.Name == GVM.HomeVM.brand.Name);
            if (GVM.HomeVM.brand != null && !isBrandAlreadyExists)
            {
                context.brands.Add(GVM.HomeVM.brand);
                context.SaveChanges();
                GVM.HomeVM.product.FK_Brand = GVM.HomeVM.brand.Id;
                GVM.HomeVM.product.Brand = GVM.HomeVM.brand;
                GVM.HomeVM.product.KeyWord = GVM.HomeVM.brand.Name;

            }
            else
            {
                Brand b = context.brands.Single(x => x.Name == GVM.HomeVM.brand.Name);
                GVM.HomeVM.product.FK_Brand = b.Id;
                GVM.HomeVM.product.Brand = b;
                GVM.HomeVM.product.KeyWord = b.Name;

            }

            Subcategory sub = context.subcategories.Single(x => x.Id == GVM.HomeVM.product.FK_Subcategory);
            Category category = context.categories.Single(x => x.Id == sub.Fk_category);
            GVM.HomeVM.product.KeyWord += " " + sub.Name + " " + category.Name;
                 

            string fileName = Path.GetFileName(GVM.HomeVM.product.image_data.FileName);
            GVM.HomeVM.product.Image = "~/Content/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Content/"), fileName);
            GVM.HomeVM.product.image_data.SaveAs(fileName);

            GVM.HomeVM.product.Status = "Pending";

            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var isSellerAlreadyExists = context.seller.ToList().Any(x => x.FK_User == user.Id);
            if (isSellerAlreadyExists)
            {
                Seller seller = context.seller.Single(e => e.FK_User == user.Id);
                GVM.HomeVM.product.FK_seller = seller.Id;
            }
            


            if (ModelState.IsValid)
            {
                context.products.Add(GVM.HomeVM.product);
                context.SaveChanges();

                return RedirectToAction("Profile");

            }

            return View();
        }

        public ViewResult Search(string search)
        {

            GeneralViewModel GVM = new GeneralViewModel();
            GVM.HVM.products = context.products.Where(x => x.Status == "Confirmed"  && x.KeyWord.Contains(search) || search== null).ToList();
            GVM.HVM.categories = context.categories.ToList();
            GVM.HVM.subcategories = context.subcategories.ToList();
            return View("Search",GVM);
        }
        [AllowAnonymous]
        public ActionResult AddToCart(int id)
        {
            Product productModel = new Product();
            if (Session["cart"] == null)
            {
                List<CartItem> cart = new List<CartItem>();
                cart.Add(new CartItem(context.products.Find(id), 1));
                //context.ShoppingCartItems.Include(e => e.Product).ToList();
                Session["cart"] = cart;

            }
            else
            {
                List<CartItem> cart = (List<CartItem>)Session["cart"];
                int index = isExist(id.ToString());
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new CartItem(context.products.Find(id), 1)/*{ Product = productModel.find(id), Quantity = 1 }*/);
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Index");
        }
        [AllowAnonymous]
        public ActionResult Remove(string id)
        {
            List<CartItem> cart = (List<CartItem>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index + 1);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }
        [AllowAnonymous]
        private int isExist(string id)
        {
            List<CartItem> cart = (List<CartItem>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.Id.Equals(id))
                    return i;
            return -1;
        }
        [AllowAnonymous]
        public ActionResult Cart()
        {
            GeneralViewModel GVM = new GeneralViewModel();
            GVM.HVM.categories = context.categories.ToList();
            GVM.HVM.subcategories = context.subcategories.ToList();
            return View(GVM);
        }

        public ActionResult About()
        {
            GeneralViewModel GVM = new GeneralViewModel();
            GVM.HVM.categories = context.categories.ToList();
            GVM.HVM.subcategories = context.subcategories.ToList();
            return View(GVM);
        }

        public ActionResult Contact()
        {
            GeneralViewModel GVM = new GeneralViewModel();
            GVM.HVM.categories = context.categories.ToList();
            GVM.HVM.subcategories = context.subcategories.ToList();
            return View(GVM);
        }
    }
}