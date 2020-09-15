using Mini_Udemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_Udemy.Controllers
{
    public class MainPageController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Departments = new SelectList(db.Departments, "Dept_Id", "Dept_Name");
            return View(db.Departments);
        }

        [HttpPost]
        public ActionResult Index(int searchVal = 10, String courseName = "Unix")
        {

            ViewBag.Departments = new SelectList(db.Departments, "Dept_Id", "Dept_Name");
            if (courseName == null || courseName == "")
            {
                ViewBag.Courses = db.Courses.Where(s => s.Dept_Id == searchVal);

            }
            else
            {
                ViewBag.Courses = db.Courses.Where(s => s.Crs_Name.Contains(courseName));

            }
            String storedSession = (String)Session["email"];
            System.Diagnostics.Debug.WriteLine(storedSession);
            Student student = db.Students.FirstOrDefault(stud => stud.St_Email == storedSession);
            ViewBag.Student = student;
            return View(db.Departments);

        }
        [HttpPost]
        public ActionResult Enroll()
        {
            if (Session["enroller"] != null&& Session["courseEnrolled"] != null) {
                Student studentEnrolled = (Student)Session["enroller"];
                Course course = (Course)Session["courseEnrolled"];
 
                studentEnrolled.Courses.Add(course);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}