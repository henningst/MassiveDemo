using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MassiveDemo.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Save(string name)
        {

            return RedirectToAction("Index", "Home");
        }

    }
}
