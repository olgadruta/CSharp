// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModel.Models;

namespace DojoSurveyModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("survey")]
        public IActionResult Survey(Survey survey)
        {

            return RedirectToAction("Result", survey);
        }

        // [HttpGet("result")]
        public ViewResult Result(Survey survey)
        {
            return View("Result", survey);
        }
    }
}
