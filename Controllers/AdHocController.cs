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
            var result = new MassiveDemo.DB.DynamicModel("MassiveDemo").Query("SELECT * FROM Products");

            var products = result.Select(p => new Product() { Id = p.Id, Name = p.Name }).ToList();
            return View(products);
        }
    }
}
