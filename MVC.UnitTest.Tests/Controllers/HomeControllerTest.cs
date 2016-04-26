using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC.UnitTest;
using MVC.UnitTest.Controllers;

namespace MVC.UnitTest.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTest
	{

		#region ViewResult Test
		
		[TestMethod]
		public void About()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.About() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void Contact()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.Contact() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}

		#endregion

		#region ViewBag Test

		[TestMethod]
		public void Index()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
		}

		#endregion

		#region RedirectResult Test

		[TestMethod]
		public void TestDetailsForRedirect()
		{
			HomeController controller = new HomeController();
			var result = controller.Details(-1) as RedirectToRouteResult;
			Assert.AreEqual("Index", result.RouteValues["action"]); //action method name
			Assert.AreEqual("SomeElse", result.RouteValues["controller"]); // controller name
		}


		[TestMethod]
		public void TestDetailsForViewResult()
		{
			HomeController controller = new HomeController();
			ViewResult result1 = (ViewResult)controller.Details(2);
			Assert.AreEqual("Details", result1.ViewName);
		}

		#endregion
	}
}


