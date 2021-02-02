using EShopApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShopApp.Controllers
{
    public class HomeController : Controller
    {
        private ProductContext db = new ProductContext();
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category).Where(p => p.IsOnSale == true);
            return View(products.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}