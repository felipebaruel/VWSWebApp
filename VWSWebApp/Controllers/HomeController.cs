using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VWSWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Test Test Test";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. 123";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HighCPU()
        {
            

            var datea = System.DateTime.Now;
            ViewBag.Message = $"Start CPU Time: {datea}";

            int result = 1;
            for (int x = 1; x < 20; x++)
            {
                for (int i = 1; i < 2147483647; i++)
                {
                    result = result * i;
                }
            }

            var dateb = System.DateTime.Now;
            ViewBag.Message2 = $"End CPU Time: {dateb}";

            
            return View();
        }

        public ActionResult Crash()
        {
            ViewBag.Message = "Test";

            var fn = 10;
            var sn = 0;
            var a = fn / sn;

            return View();
        }
    }
}