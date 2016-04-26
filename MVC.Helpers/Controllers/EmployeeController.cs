using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpers.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult ListV()
        {
            List<string> Employee = new List<string>();
            Employee.Add("Jignesh");
            Employee.Add("Tejas");
            Employee.Add("Rakesh");

            ViewData["EmployeeList"] = Employee;
            return View();
        }

        public ActionResult ListVB()
        {
            List<string> Employee = new List<string>();
            Employee.Add("Jignesh");
            Employee.Add("Tejas");
            Employee.Add("Rakesh");

            ViewBag.Employee = Employee;
            return View();
        }

        public ActionResult ListTemp()
        {
            List<string> Employee = new List<string>();
            Employee.Add("Jignesh");
            Employee.Add("Tejas");
            Employee.Add("Rakesh");

            TempData["EmployeeList"] = Employee;
            return View();
        }

    }
}
