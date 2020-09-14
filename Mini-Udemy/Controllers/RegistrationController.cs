using Mini_Udemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace Mini_Udemy.Controllers
{
    public class RegistrationController : Controller
    {
        DatabaseContext context = new DatabaseContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student s, String confirmPassword)
        {
            if (!emailValidation(s.St_Email))
            {
                ViewBag.Message = "Please Write your email Correctly!";

                return View();
            }
            else if (!passwordValidation(s.St_Password,confirmPassword))
            {
                ViewBag.Message = "Please Write your Password Correctly or type atleast 8 characters!";

                return View();
            }
            else if (!AgeValidation(s.St_Age))
            {
                ViewBag.Message = "Please Write your Age Correctly!";

                return View();
            }else if (s.St_Fname.IsEmpty() || s.St_Lname.IsEmpty())
            {

                ViewBag.Message = "Please Write your Name!";

                return View();
            }else if (CheckIfEmailExists(s.St_Email))
            {

                ViewBag.Message = "Sorry , This email is already used!";

                return View();
            }
            else
            {
                s.St_Id = context.Students.Count() + 102;
                context.Students.Add(s);
                context.SaveChanges();
                Session["Email"] = s.St_Email;
                Session["Fname"] = s.St_Fname;
                Session["Lname"] = s.St_Lname;
                Session["Password"] = s.St_Password;

                return RedirectToAction("Index","MainPage");
            }
        }
         
        public bool emailValidation(String email) {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CheckIfEmailExists(String email)
        {

         return  (context.Students.FirstOrDefault(student => student.St_Email == email) != null)?true:false;
        }
        public bool passwordValidation(String password, String confirmPassword)
        {
            try
            {

            if (password.CompareTo(confirmPassword)==-1 || password.IsEmpty() || confirmPassword.IsEmpty()||password.Length<8)
            {
                return false;
            }

            return true;

            }
            catch (Exception)
            {
                return false;
             }
        }
        public bool AgeValidation(int? age)
        {
            if (age < 10 || age > 100||age.ToString().IsEmpty())
            {
                return false;
            }
            return true;
        }
    }
}