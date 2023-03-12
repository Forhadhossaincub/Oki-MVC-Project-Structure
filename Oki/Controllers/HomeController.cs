using Oki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oki.Controllers
{
    public class HomeController : Controller
    {
        private readonly OkiDbContext db = new OkiDbContext();

        // GET: Home
        public ActionResult Index()
        {
          var count =  db.Customers.Count();
            ViewBag.Count = count;
            ViewData["FirstCustomer"] = db.Customers.First().CompanyName;


            return View(db.Customers.ToList());
            //return View(db.Customers.OrderBy(c =>c.CustomerID).Skip(10).Take(10).ToList());
        }
    }
}