using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoSoKTPM.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string Acc, string Pass)
        {
            bool isAuthentic = (Acc != null && Pass != null && Acc.Equals("admin") && Pass.Equals("admin"));
            if (isAuthentic)
            {
                return View("~/Areas/PrivateAreas/Views/Dashboard/Index.cshtml");
            }
            return View();
        }
    }
}