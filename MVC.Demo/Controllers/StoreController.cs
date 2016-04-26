using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class StoreController : Controller
    {
        #region Global Variable Declarations
        Repository db = new Repository();
        #endregion

        //
        // GET: /Store/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Product with viewbag example passing values from ViewBag to View
        /// </summary>
        /// <param name="id"></param>
        /// <returns>renders an html</returns>
        public ActionResult Product(int id)
        {
            ViewBag.dept = id.ToString();

            return View();
        }

        /// <summary>
        /// Display details of LineItem using scaffold template details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Display(int id)
        {
            List<LineItem> lineItems = db.GetItems();

            LineItem items = lineItems.Where(d => d.Id == id).Select(d => d).First();

            return View(items);
        }

        /// <summary>
        /// Display the complete Product List using scaffold template List
        /// </summary>
        /// <returns></returns>
        public ActionResult ProductList()
        {
            List<LineItem> items = db.GetItems();
            return View(items);
        }

        /// <summary>
        /// Adding new item as we normally do with using html or asp.net
        /// </summary>
        /// <returns></returns>
        public ActionResult AddItem()
        {
            return View();
        }

        /// <summary>
        /// fetching the form data using the request.form for saving the data
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveItem()
        {
            ViewBag.Id = Request.Form["txtid"].ToString();
            ViewBag.Name = Request.Form["txtname"].ToString();
            ViewBag.Price = Request.Form["txtprice"].ToString();
            ViewBag.Quantity = Request.Form["txtquantity"].ToString();
            return View();
        }

        /// <summary>
        /// creating a form using scaffold template Create and using html.begin form for posting the data
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// post the data with model as a parameter
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(LineItem obj)
        {
            return View(obj);
        }

    }
}
