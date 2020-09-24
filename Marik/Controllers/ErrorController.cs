using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marik.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            ViewBag.TopImage = "/Content/img/about-banner.jpg";
            ViewBag.Headline = "404";
            ViewBag.SubHeadline = "page not found";

            return View();
        }
    }
}