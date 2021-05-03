using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Controllers
{
    public class ViewDataController : Controller
    {
        public IActionResult Index()
        {
            ViewData["UserId"] = 101;         
            return View();
        }
        
        [Route("viewdata/pessoa")]
        public JsonResult Person()
        {
            var person = new { Id = ViewData["UserId"], Nome = "Jonathan", Idade = 34, Sexo = "Masculino", Altura = "1.71" };

            return Json(person);
            
        }
    }
}
