using SimpleCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleCRUD.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CRUContext context = new CRUContext();
        // GET: Customer
        public ActionResult Index()
        {
            var customers = context.Customers.ToList();
            return View(customers);
        }
    }
}