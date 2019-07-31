using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvBuilder.Controllers
{
    public class BuilderController : Controller
    {
        // GET: Builder
        public ActionResult Index()
        {
            return RedirectToAction("AddDataStep1");
        }

        // GET: Builder/Details/5
        public ActionResult Editor()
        {
            return View();
        }
    }
}
