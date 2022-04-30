using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(string Id)
        {
            var MaSV = Id;
            Student stu = new Student
            {
                Id = MaSV,
                Name = "Phuong Duy",
                Address = "TP.HCM"

            };
            return View(stu);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student stu)
        {
            if (ModelState.IsValid)
            {
                return View("Details", stu);
            }
            ModelState.AddModelError("inform", "Vui lòng kiểm tra lại");
            return View(stu);
        }
        
    }
}