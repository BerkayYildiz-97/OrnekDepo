using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_School.Areas.Student
{
    [Authorize(Roles = "student")]
    // GET: Student/Home
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
    }
}