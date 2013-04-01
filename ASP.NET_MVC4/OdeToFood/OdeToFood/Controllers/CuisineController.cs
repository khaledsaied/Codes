using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

       // [Authorize]
        [Log]
        public ActionResult Search(string name="arab")
        {
            throw new Exception("ERRRRRORR");

            var message = Server.HtmlEncode(name);

            return Content(message);
            //return RedirectPermanent("http://www.google.dk");
            //return RedirectToAction("Index", "Home", new  { name = name});
            //return RedirectToRoute("Default", new {controller = "Home", action = "About"});
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new {Message = message, Name = "Khaled"}, JsonRequestBehavior.AllowGet);
        }

        //[HttpGet]
        //public ActionResult Search()
        //{
            
        //    return Content("search");
        //}

    }
}
