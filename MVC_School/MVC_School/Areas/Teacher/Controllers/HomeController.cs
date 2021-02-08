using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_School.Areas.Teacher.Controllers
{
    [Authorize(Roles ="teacher")]
    public class HomeController : Controller
    {
        // GET: Teacher/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}