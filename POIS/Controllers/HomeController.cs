using POIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POIS.Controllers
{   
    public class HomeController : Controller
    {

        private ProductsDBEntities db = new ProductsDBEntities();
        public ActionResult Index()
        {
            var products = (from product in db.DBs select product).ToList();
            return View(products);
        }
        public ActionResult Details(int id)
        {
            var productDetails = (from product in db.DBs where product.Id == id  select product).First();
            return View(productDetails);
        }

    }
}