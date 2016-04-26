using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class BasicController : Controller
    {
        //
        // GET: /Basic/Index
        public string Index()
        {
            return "<H1>Welcome to Home Page</H1>";
        }

        //Action with Parameter as id
        public string Products(int id = 10)
        {
            return "<H2>Browsing Product of dept " + id.ToString() + "</H2>";
        }

    }
}
