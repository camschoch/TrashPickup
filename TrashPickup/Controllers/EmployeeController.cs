using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context;
        public EmployeeController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EmployeePickup(EmployeeSearchZip model)
        {

            ViewBag.Message = "Your application employee pickup description page.";
            var userName = User.Identity.GetUserName();
            var user = (from data in context.Users where data.UserName == userName select data).First();
            user.ZipCode = model.ZipCode;
            context.SaveChanges();
            var results = (from data in context.Users where data.ZipCode == user.ZipCode select data);

            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}