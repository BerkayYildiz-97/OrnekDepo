using MVC_Layout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Layout.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Product
        public ActionResult Index()
        {
            var products  = db.Products.ToList();
            return View(products);
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult RemoveProduct(int productId)
        {
            Product product = db.Products.Find(productId);
            if (product!=null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult UpdateProduct(int productId)
        {
            var product = db.Products.Find(productId);
            return View(product);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            var updatedProduct = db.Products.Find(product.ProductID);
            updatedProduct.ProductName = product.ProductName;
            updatedProduct.Category = product.Category;
            updatedProduct.UnitPrice = product.UnitPrice;
            updatedProduct.UnitsInStock = product.UnitsInStock;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}