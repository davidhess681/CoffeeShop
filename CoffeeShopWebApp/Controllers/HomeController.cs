using CoffeeShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CoffeeShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UserRegistration()
        {
            return View();
        }
        public ActionResult AddUser(UserInfo newUser)
        {
            {
                // ToDo: validation!!!!!!

                if (ModelState.IsValid)
                {
                    // ToDo: Send the data to the DB

                    // confirmation, or maybe send to the Index page

                    //ViewData["ConfMessage"] = "Thanks " + newUser.FirstName;

                    ViewBag.ConfMessage = "Welcome " + newUser.FirstName;
                    ViewBag.Name = $"Name: {newUser.FirstName} {newUser.LastName}";
                    ViewBag.Email = $"Email: {newUser.Email}";
                    ViewBag.Birthday = $"Birthday: {newUser.Birthday}";

                    return View("Summary");
                }

                else
                {
                    ViewBag.ErrorMessage = "Something was invalid. Please fix it and try again.";
                    
                    return View("UserRegistration");
                }
            }
        }
    }
}