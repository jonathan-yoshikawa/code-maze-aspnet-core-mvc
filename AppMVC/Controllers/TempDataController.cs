using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult Index()
        {
            return View("First");
        }

        public IActionResult First()
        {
            TempData["UserId"] = 101;
            TempData.Keep();
            return View();
        }
        public IActionResult Second()
        {
            var userId = TempData["UserId"] ?? null;
            TempData.Keep();
            return View();
        }
        public IActionResult Third()
        {
            TempData.Keep();
            return View();
        }
    }
}
