using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "This is your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Contact page changed from Visual Studio for Continuous Integration demo";

			return View();
		}
	}
}
