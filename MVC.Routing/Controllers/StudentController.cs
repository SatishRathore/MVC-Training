using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Index(int id)
        {           
            return View();
        }

        public ActionResult Details(int StudentId)
        {
            //The values for the segments in the URL request can be read using the Page.RouteData property in the body of the action method that processes the request
            string id = (string)RouteData.Values["MoreValues"];
            string controller = (string)RouteData.Values["controller"];
            string studentId = (string)RouteData.Values["studentId"];
            //System.Web.Routing.RouteValueDictionary, that contains all the values for the segments in the URL
            return View();
        }

        //string id = (string)RouteData.Values["id"];
        //return View();

    }
}
