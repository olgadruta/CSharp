using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet("result")]
        public ViewResult Result(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View();
        }
        [HttpPost("postform")]
        public RedirectToActionResult PostForm(string name, string location, string language, string comment)
        {
            return RedirectToAction("Result", new {Name=name, location=location, language=language, comment=comment});
        }

        // public IActionResult Index()
        // {
        //     return View();
        // }

    }
}
