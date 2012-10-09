using MassiveDemo.Domain;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MassiveDemo.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Save()
        {
            var products = new Products();
            var product = products.CreateFrom(Request.Form);
            
            products.Insert(product);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Delete(int id)
        {
            var products = new Products();
            products.Delete(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
