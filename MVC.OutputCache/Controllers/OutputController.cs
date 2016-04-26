using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_OutputCache.Controllers
{
    public class OutputController : Controller
    {
        //
        // GET: /Output/

        public ActionResult Index()
        {
            Response.Write("<h2>Outer Test Cache Page" + DateTime.Now.ToString() + "</h2>");
            return View();            
        }

        [ChildActionOnly]
        [OutputCache(Duration = 60)]
        public ActionResult PartCache()
        {
            Response.Write("<h2>Part Cache Page" + DateTime.Now.ToString() + "</h2>");
            return PartialView();
        }
    }
}
