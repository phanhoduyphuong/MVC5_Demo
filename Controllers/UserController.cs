using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel loginModel)
        {
            if(loginModel.Username == "admin" && loginModel.Password == "admin")
            {
                Session["User"] = loginModel.Username;
                HttpCookie cookie = new HttpCookie("Last_view", DateTime.Now.ToString());
                Response.Cookies.Add(cookie);
                return RedirectToAction("Index");
            }
            return View("Index", loginModel);
        }
        public ActionResult Logout()
        {
            if (Session["User"] != null)
            {
                Session.Remove("User");
            }
            return RedirectToAction("Index");
        }
    }
}