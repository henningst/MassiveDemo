using MassiveDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MassiveDemo.Controllers
{
    public class AdHocController : Controller
    {
        public ActionResult Index()
        {
            var db = new MassiveDemo.DB.DynamicModel("MassiveDemo");
            var result = db.Query("SELECT * FROM Products");

            var products = result.Select(p => new Product() { Id = p.Id, Name = p.Name }).ToList();
            return View(products);
        }
    }
}
