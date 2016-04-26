using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UnitTest.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult GetView(int id)
		{
			if (id == 0)
			{
				return View("View2");
			}
			else
			{
				return View("View1");
			}
		}


		public ActionResult Details(int Id)
		{
			if (Id < 0)
			{
				return RedirectToAction("Index", "SomeElse");
			}
			else
			{
				return View("Details");
			}

		}
	}
}
