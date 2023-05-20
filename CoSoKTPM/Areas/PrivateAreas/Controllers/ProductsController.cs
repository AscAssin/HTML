using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoSoKTPM.Areas.PrivateAreas.Controllers
{
    public class ProductsController : Controller
    {
        // GET: PrivateAreas/Products
        public ActionResult Index()
        {
            return View();
        }
    }
}