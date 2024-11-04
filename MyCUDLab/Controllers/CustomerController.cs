using MyCUDLab.Context;
using MyCUDLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCUDLab.Controllers
{
    public class CustomerController : Controller
    {
        CustomerContext db = new CustomerContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customer.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            var dataById = db.Customer.Single(x => x.Id == id);
            return View(dataById);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                db.Customer.Add(customer);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var dataById = db.Customer.Single(x => x.Id == id);
            return View(dataById);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer collection)
        {
            try
            {
                Customer cusObj = db.Customer.Single(x => x.Id == id);

                cusObj.Id = collection.Id;
                cusObj.Image = collection.Image;
                cusObj.CustomerName = collection.CustomerName;
                cusObj.Address = collection.Address;
                cusObj.Country = collection.Country;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            var dataById = db.Customer.Single(x => x.Id == id);
            return View(dataById);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var dataById = db.Customer.Single(x => x.Id == id);
                db.Customer.Remove(dataById);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
