using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class IntroductoryController : Controller
    {
        // GET: HelloWorld
       
        public ActionResult Index()
        {
            return View();
        }
        //GET: HelloWorld/Welcome
        public String Welcome()
        {
            return "This is the Welcome action method.";
        }
        public String Display(String name,int id)
        {
            return HttpUtility.HtmlEncode("hello, "+name+ ". number is "+id);
        }
    }
}