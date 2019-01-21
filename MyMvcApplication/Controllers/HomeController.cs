using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;





namespace MyMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Photo photo = new Photo();
            photo.Title = "12";
            ViewBag.Title = "sdasdas";
            return View(photo);
        }
    }
}