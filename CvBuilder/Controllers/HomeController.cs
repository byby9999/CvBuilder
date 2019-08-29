using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvBuilder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult GetOrgs()
        {
            var items = new List<string>();

            items.Add("new yorker");
            items.Add("fox news");
            items.Add("london UK");
            items.Add("ceva RO");

            return Json(items);
        }
    }
}