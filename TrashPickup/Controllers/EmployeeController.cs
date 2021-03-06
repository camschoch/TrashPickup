﻿using Microsoft.AspNet.Identity;
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
            //Need to refactor
            ViewBag.Message = "Your application employee pickup description page.";

            List<ApplicationUser> finalList = new List<ApplicationUser>();
            var userName = User.Identity.GetUserName();
            var worker = (from data in context.Users where data.UserName == userName select data).First();
            worker.ZipCode = model.ZipCode;
            context.SaveChanges();
            var today = DateTime.Now;
            if (today.DayOfWeek.ToString().Equals("Sunday"))
            {
                worker.ActualPickup = 9;
            }
            else if (today.DayOfWeek.ToString().Equals("Monday"))
            {
                worker.ActualPickup = 10;
            }
            else if (today.DayOfWeek.ToString().Equals("Tuesday"))
            {
                worker.ActualPickup = 11;
            }
            else if (today.DayOfWeek.ToString().Equals("Wednesday"))
            {
                worker.ActualPickup = 12;
            }
            else if (today.DayOfWeek.ToString().Equals("Thursday"))
            {
                worker.ActualPickup = 13;
            }
            else if (today.DayOfWeek.ToString().Equals("Friday"))
            {
                worker.ActualPickup = 14;
            }
            else if (today.DayOfWeek.ToString().Equals("Saturday"))
            {
                worker.ActualPickup = 15;
            }
            context.SaveChanges();
            var users = (from data in context.Users where data.ZipCode == worker.ZipCode select data).ToList();

            var customers = (from data in context.Roles where data.Name == "Customer" select data.Users).ToList();
            List<ApplicationUser> tempHold = new List<ApplicationUser>();            
            var allCustomers = customers[0];
            foreach (var person in allCustomers)
            {
                var results = (from data in context.Users where data.Id == person.UserId && data.ActualPickup == worker.ActualPickup select data).ToList();
                if (results.Count > 0)
                {
                    tempHold.Add(results[0]);
                }
            }
            foreach (var item in tempHold)
            {                
                for (int i = 0; i < users.Count; i++)
                {
                    if (item == users[i])
                    {
                        finalList.Add(item);
                        break;
                    }
                }                
            }
            return View(finalList);
        }
        
        public ActionResult EmployeePickupPost(string clientId)
        {
            var user = (from data in context.Users where data.Id == clientId select data).First();
            user.ActualPickup = user.RegularPickup;
            user.NumberOfPickups++;
            context.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }
        public ActionResult Maps()
        {
            return View();
        }
    }
}