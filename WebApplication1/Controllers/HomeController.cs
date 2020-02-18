using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public class Priority
        {
            public string Name { get; set; }
            public int Level { get; set; }
            public Priority(){}

            public Priority(string name, int lv)
            {
                this.Name = name;
                this.Level = lv;
            }
        }
        public ActionResult Index()
        {
            List<Priority>  list= new List<Priority>();
            list.Add(new Priority("Leo", 1));
            list.Add(new Priority("Chris", 2));

            ViewBag.List = list;
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

        public ActionResult Test(string key)
        {
            if (!string.IsNullOrEmpty(key))
            {
                Priority pp = new Priority();
                pp.Name = "admin";
                pp.Level = 999;
                ViewBag.Priority = pp;
                return View();
            }
            else
            {
                return View();
            }

        }
    }
}