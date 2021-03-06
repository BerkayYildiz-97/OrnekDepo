﻿using MVC_Layout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Layout.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveCustomer(string customerId)
        {
            var customer = db.Customers.Find(customerId);
            if (customer != null)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult UpdateCustomer(string customerId)
        {
            var customer = db.Customers.Find(customerId);
            return View(customer);
        }

        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            var updated = db.Customers.Find(customer.CustomerID);
            updated.CompanyName = customer.CompanyName;
            updated.ContactName = customer.ContactName;
            updated.ContactTitle = customer.ContactTitle;
            updated.Address = customer.Address;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}