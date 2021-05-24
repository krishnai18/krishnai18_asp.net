using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/Greet/{name?}")]
        public IActionResult Greet(string name)
        {
            // return Content("Welcome to MVC");
            // if change name
            //return View("Greet1");
            ViewBag.wish = "Hello" + name;
            return View();
        }
        public IActionResult GetData(int id)
        {
            ViewBag.message = "Id = " + id;
            return View();
        }
        [Route("Home/AddNumber/{a:int}/{b:int:range(1,10)}")]
        
        public IActionResult AddNumber(int a, int b)
        {
            ViewBag.sum = "sum = " + (a + b);
            return View();
        }

        public IActionResult ModelDemo()
        {
            Employee employee = new Employee { EmpId = 1, EmpName = "krishnai", Salary = 10000 };
            //ViewBag.emp = employee;
            ViewData["emp"] = employee;

            return View();
        }
        public IActionResult EmployeeForm()
        {
            return View(new Employee());
        }

        public IActionResult DisplayEmployeeData(Employee employee)
        {
            if (ModelState.IsValid)
            {
                return View(employee);
            }
            return View("EmployeeForm", employee);
        }

         

    }
}
