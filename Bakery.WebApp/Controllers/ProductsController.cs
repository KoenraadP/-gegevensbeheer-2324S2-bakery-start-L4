using Bakery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bakery.WebApp.Controllers
{
    public class ProductsController : Controller
    {
        // READ ALL
        public ActionResult Index()
        {
            List<Product> lstProducts = new List<Product>();
            return View(lstProducts);
        }
    }
}