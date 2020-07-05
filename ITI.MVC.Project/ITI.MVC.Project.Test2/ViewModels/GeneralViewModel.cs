using ITI.MVC.Project.Test2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITI.MVC.Project.Test2.ViewModels
{
    public class GeneralViewModel
    {
        public HomeViewModel HomeVM { get; set; }
        public HomeViewModel HVM = new HomeViewModel();
        public RegisterViewModel RVM { get; set; }
        public LoginViewModel LVM { get; set; }
        public Seller seller { get; set; }
    }
}