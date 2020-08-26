using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers
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
            if(ModelState.IsValid)
            {
            return RedirectToAction("Result", survey);
            }
            else
            {
                return View("Index");
            }
        }

        // [HttpGet("result")]
        public ViewResult Result(Survey survey)
        {
            return View("Result", survey);
        }


    }
}
