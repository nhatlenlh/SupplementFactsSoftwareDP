using OrderItemsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderItemsWeb.Controllers
{
    public class ProductsController : Controller
    {
        private DevConn db = new DevConn();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.ToList();

            return View(products);
        }
    }
}