using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoSoKTPM.Areas.PrivateAreas.Controllers
{
    public class OrdersController : Controller
    {
        // GET: PrivateAreas/Orders
        public ActionResult Index()
        {
            return View();
        }
    }
}