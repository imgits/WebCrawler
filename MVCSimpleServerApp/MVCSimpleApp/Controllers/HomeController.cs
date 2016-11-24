using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSimpleApp.Models; // <-- ensure you refer to the model namespace if code is seperated out

namespace MVCSimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ContentResult GetXML()
        {
            // assign post parameters to variables
            string ReceivedID = Request.Params["ItemID"];
            // generate a random sleep time in milli-seconds to simulate response time over the web
            Random rnd = new Random();
            // multiplier ensures we have good breaks between sleeps
            // note that with Random, the upper bound is exclusive so this really means 1..5
            int SleepTime = rnd.Next(1, 2) * 1000;
            // generate XML string to send back
            System.Threading.Thread.Sleep(SleepTime);
            return Content(TestModel.GetXMLResponse(ReceivedID), "text/xml");
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
