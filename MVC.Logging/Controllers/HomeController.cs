using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logging.Controllers
{
    
    public class HomeController : Controller
    {
        //
        // GET: /Home/
       // [HandleError]
        public ActionResult Index()
        {
            throw new Exception("Something went wrong");
        }

        public ActionResult IndexNew()
        {
            throw new Exception("Something went wrong");
        }

    }
}
