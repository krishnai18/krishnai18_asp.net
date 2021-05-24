using Microsoft.AspNetCore.Mvc;
using MVCDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegistrationForm()
        {
            Person per = new Person();
            return View(per);
        }
        public IActionResult DisplayData(Person per)
        {
            if (per != null)
            {
                ViewBag.DefaultMessage = "thankyou" + per.Name;
                if (per.WillAttend == "yes")
                {
                    ViewBag.Message = "thankyou for coming ,we will be waiting for you";
                }
                if (per.WillAttend == "no")
                {
                    ViewBag.Message = "sorry to hear that";
                }
            }
            return View();
        }

    }
}
