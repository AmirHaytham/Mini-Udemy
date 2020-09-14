using Mini_Udemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_Udemy.Controllers
{
    public class HomeController : Controller
    {
        /*
         [DatabaseContext] is the class which accesses our database
         */
        DatabaseContext databaseContext = new DatabaseContext();
        public ActionResult Index()
        {
            if (Session["email"] != null)
            {
                return RedirectToAction("Index", "MainPage");

            }
            else
            {
                return View(databaseContext.Students);
            }
        }

        [HttpPost]
        public ActionResult Login(String email , String password)
        {
            Console.WriteLine(email);
            Student loggedInStudent = databaseContext.Students.FirstOrDefault(student => student.St_Email == email && student.St_Password == password);
            
            if (loggedInStudent!=null)
            {
                //Redirect to home
                Session["email"] = email;
                Session["Fname"] = loggedInStudent.St_Fname;
                Session["Lname"] = loggedInStudent.St_Lname;
                Session["Password"] = loggedInStudent.St_Password;
                return RedirectToAction("Index", "MainPage");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        
    }
}