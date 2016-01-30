using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace PayPal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Budget()
        {
            return View();
        }
        public IActionResult Employees()
        {
            return View();
        }
        public IActionResult Roles()
        {
            return View();
        }
        public IActionResult Expenses()
        {
            return View();
        }
        public IActionResult PayRoll()
        {
            return View();
        }
        public IActionResult Tasks()
        {           
            return View();
        }
        public IActionResult Promotions()
        {
            return View();
        }
    }
}
