using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helpers.Models;

namespace Helpers.Controllers
{
    public class RegistrationController : Controller
    {
        //
        // GET: /Registration/
        [HttpGet]
        public ActionResult Index()
        {
            Registration obj = new Registration();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Save(Registration obj)
        {
            ViewBag.Name = Request.Form["Name"].ToString();
            ViewBag.Address = Request.Form["Address"].ToString();            
            ViewBag.IsApproved = obj.IsApproved.ToString();
            return View();
        }
    }
}
