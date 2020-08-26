using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortfolioII.Models;

namespace PortfolioII.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet ("") ]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet ("projects") ]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet ("contact") ]
        public ViewResult Contact()
        {
            return View();
        }

        [HttpPost ("submitform")]
        public RedirectToActionResult SubmitForm()
        {
            return RedirectToAction();
        }

        // public IActionResult Index()
        // {
        //     return View();
        // }

    }
}
