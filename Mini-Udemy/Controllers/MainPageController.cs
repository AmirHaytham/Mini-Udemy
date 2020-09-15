using Mini_Udemy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
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
            if (Session["email"] != null)
            {
                ViewBag.Departments = new SelectList(db.Departments, "Dept_Id", "Dept_Name");
                return View(db.Departments);
            }
            else
            {
                return RedirectToAction("Index","Home");
            }
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
            Student student = db.Students.FirstOrDefault(stud => stud.St_Email == storedSession);
            ViewBag.Student = student;
            return View(db.Departments);

        }
        [HttpPost] 
        public ActionResult Signout()
        {
            Session.Clear();
   
            return RedirectToAction("Index","Home");
        }
        [HttpPost]
        // [Ashour] Can't figure out how to enroll (Course) in the List of courses inside the (Student) Entity.

        public ActionResult Enroll()
        {
            if (Session["enroller"] != null&& Session["enrolledcourse"] != null) {
                Student studentEnrolled = (Student)Session["enroller"];
                var course = (Course)Session["enrolledcourse"];
                Debug.WriteLine(studentEnrolled.Courses.Count());
                studentEnrolled.Courses.Add(course);
                db.Students.AddOrUpdate(studentEnrolled);
                ViewBag.Student = studentEnrolled;
                db.SaveChanges(); 

                Debug.WriteLine(studentEnrolled.Courses.Count());
            }
            return RedirectToAction("Index");
        }
        public ActionResult ViewProfile()
        {
            String studentEmail =(String) Session["email"];
            Student s = db.Students.FirstOrDefault(std=>std.St_Email.Equals(studentEmail));
            return View(s);
        }
    }
}