using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderItemsWeb.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Brief introduction";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Our contact information";

			return View();
		}
	}
}