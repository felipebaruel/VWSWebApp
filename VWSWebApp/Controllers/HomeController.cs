using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace VWSWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Test Test Test";

            Trace.WriteLine("Entering Index method");
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            Trace.TraceInformation("Displaying the Index page at " + DateTime.Now.ToLongTimeString());
            Trace.WriteLine("Leaving Index method");
            

            return View();
        }

        public ActionResult About()
        {
            string currentTime = DateTime.Now.ToLongTimeString();
            

            Trace.WriteLine("Entering About method");
            ViewBag.Message = "The current time is " + currentTime;
            Trace.TraceWarning("Transient error on the About page at " + DateTime.Now.ToShortTimeString());
            Trace.WriteLine("Leaving About method");

            return View();
        }

        public ActionResult Contact()
        {
            Trace.WriteLine("Entering Contact method");
            ViewBag.Message = "Your contact page.";
            Trace.TraceError("Fatal error on the Contact page at " + DateTime.Now.ToLongTimeString());
            Trace.WriteLine("Leaving Contact method");
            return View();
        }

        public ActionResult HighCPU()
        {

            Trace.WriteLine("Entering HighCPU method");
            var datea = System.DateTime.Now;
            ViewBag.Message = $"Start CPU Time: {datea}";
            Trace.TraceInformation($"Start CPU Time: {datea}");
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
            Trace.TraceInformation($"End CPU Time: {dateb}");


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

        public ActionResult Error404()
        {
            //var urlquery = Request.QueryString.Get(0);
            var fullurl = Request.Url;
            ViewBag.Message = "PageNotFound: " + fullurl;

            return View();
        }
    }
}