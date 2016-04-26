using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC.ResultSet.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult ViewResultDemo()
        {
            return View();
        }

        public PartialViewResult PartialViewDemo()
        {
            return PartialView();
        }

        public ActionResult RedirectToActionDemo()
        {
            return RedirectToAction("Index");
        }

        public ContentResult ContentResultDemo()
        {
            return Content("<p>Welcome to the User</p>", "text/html", Encoding.UTF8);
        }

        public JsonResult JsonResultDemo()
        {
            bool isAdmin = false;            
            string output = isAdmin ? "Welcome to the Admin User" : "Welcome to the User";

            return Json(output, JsonRequestBehavior.AllowGet);  
        }

    }
}
