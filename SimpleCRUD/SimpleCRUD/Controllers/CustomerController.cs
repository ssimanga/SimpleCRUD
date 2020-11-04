using SimpleCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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

        public ActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNew(Customer customer)
        {
            if (ModelState.IsValid)
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
                

            return RedirectToAction("Index");
        }

        public ActionResult Update(string id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var customer = context.Customers.SingleOrDefault(c => c.Id == id);
            if(customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        [HttpPost]
        public ActionResult Update(Customer customer)
        {
            if (ModelState.IsValid)
            {
                context.Entry(customer).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }
    }
}