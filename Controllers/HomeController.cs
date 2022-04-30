using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
                
            if (CheckLogin()==false)
                return RedirectToAction("Index","User");
            else
                return View();
        }
        public ActionResult IndexLayout()
        {
            return View("About");
        }
        public ActionResult IndexWithoutLayout()
        {
            return PartialView("Index");
        }
        [ChildActionOnly]
        public ActionResult SubMenu()
        {
            return PartialView();
        }
        public ActionResult getString()
        {
            return Content("Xin chào các bạn");
        }
        public ActionResult readFile()
        {
            return File("~/App_Data/data.txt","text/plain");
        }
        public ActionResult getJson()
        {
            var data = new { Name = "Duy Phương", Year = 2022 };
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        public ActionResult JsonArray()
        {
            ArrayList data = new ArrayList();
            data.Add(new { Name = "Duy Phương", Year = 2022 });
            data.Add(new { Name = "Minh Duy", Year = 2023 });
            data.Add(new { Name = "Tran Thanh", Year = 2024 });
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult RedirectToAction()
        {
            return RedirectToAction("About");
        }
        public ActionResult RedirectToUrl()
        {
            return Redirect("http://google.com");
        }
        [HttpGet]
        public ActionResult JSResult()
        {
            string script = "alert('Hello world!');";
            return JavaScript(script);
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
        public ActionResult Test()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public bool CheckLogin()
        {
            return Session["User"] == null ? false : true;            
        }
    }
}