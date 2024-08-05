using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2_DepDsgEmp_1147.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DateofMovie(int year,int month)
        {
            return Content(year.ToString() + "/" + month.ToString());
        }

    }
}