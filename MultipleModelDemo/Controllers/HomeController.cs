using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultipleModelDemo.Controllers
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

        Repository _repository = new Repository();

        public ActionResult ViewDataDemo()
        {
            ViewData["Courses"] = _repository.GetCourses();
            ViewData["Students"] = _repository.GetStudents();
            ViewData["Faculties"] = _repository.GetFaculties();
            return View();
        }
    }
}