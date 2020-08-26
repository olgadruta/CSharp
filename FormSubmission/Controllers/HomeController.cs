using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FormSubmission.Models;


namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }


        [HttpPost("user")]
        public IActionResult Inform(User info)
        {
            System.Console.WriteLine(info.FirstName);
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", info);
            }
            else
            {
                return View("Index");
            }
        }
        
        public IActionResult Success(User info)
        {
            return View("Success", info);
        }

    }
}
