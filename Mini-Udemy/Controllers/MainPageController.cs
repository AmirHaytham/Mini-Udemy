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

        public ActionResult Index()
        {
            ViewBag.Departments = new SelectList(db.Departments, "Dept_Id", "Dept_Name");
            return View(db.Departments);
        }
    }
}