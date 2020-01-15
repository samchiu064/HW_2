using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_2.Controllers
{
    public class SystemSetupController : Controller
    {
        // GET: SystemSetup
        public ActionResult Index()
        {
            return View();
        }
        public new ActionResult User()
        {
            return View();
        }
        public ActionResult Role()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
    }
}