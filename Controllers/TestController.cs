using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2_DepDsgEmp_1147.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return Content("Testing");
        }
        public ActionResult abc()
        {
            return Content("dot net training");
        }
    }
}