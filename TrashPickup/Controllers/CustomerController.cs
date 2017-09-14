using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{   
    public class CustomerController : Controller
    {
        ApplicationDbContext context;
        public CustomerController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Pickup()
        {
            ViewBag.Message = "Your application Pickup page.";
            DaysOfTheWeekModel model = new DaysOfTheWeekModel();
            model.Days = context.DaysOfTheWeek.ToList();

            return View(model);
        }

        [HttpPost]
        public ActionResult Pickup(DaysOfTheWeekModel model)
        {
            if (ModelState.IsValid)
            {
                string userName = User.Identity.GetUserName();
                var user = (from data in context.Users where data.UserName == userName select data).First();
                user.RegularPickup = model.Id;


                user.ActualPickup = model.DayKey;
                context.SaveChanges();
                return RedirectToAction("Index", "Customer");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Billing()
        {
            string userName = User.Identity.GetUserName();
            var user = (from data in context.Users where data.UserName == userName select data).First();
            int amountOwed = user.NumberOfPickups * 35;//change to a variable called cost of pickup
            return View(amountOwed);
        }
    }
}