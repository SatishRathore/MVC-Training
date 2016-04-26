using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataValidation.Models;

namespace DataValidation.Controllers
{
    public class MessageController : Controller
    {
        //
        // GET: /Message/

        public ActionResult Send()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Send(Message model)
        {
            //if (string.IsNullOrEmpty(model.From)) 
            //{ ModelState.AddModelError("From", "The From field is required."); } 
            //if (string.IsNullOrEmpty(model.Email)) 
            //{ ModelState.AddModelError("Email", "The Email field is required."); } 
            //if (string.IsNullOrEmpty(model.Contain)) 
            //{ ModelState.AddModelError("Contain", "The Message field is required."); }
            if (ModelState.IsValid) { return RedirectToAction("ThankYou"); }
            ModelState.AddModelError("", "One or more errors were found"); return View(model);
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
