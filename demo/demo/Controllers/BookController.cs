using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public int MyProperty { get; set; }

        public ActionResult Edit()
        {
            Response.Write('Hello ASP.NET C# MVC');
        }
    }
}