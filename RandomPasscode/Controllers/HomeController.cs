using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Random random = new Random();
            string num ="ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] stringnum = new char[14];
            for(int i=0; i<stringnum.Length; i++)
            {
                stringnum[i] = num[random.Next(num.Length)];
            }

            if(HttpContext.Session.GetInt32("counter") == null)
            {
                HttpContext.Session.SetInt32("counter",0);
            }
            ViewBag.Counter = HttpContext.Session.GetInt32("counter");
            string totalnum = new string(stringnum);
            ViewBag.newnum = totalnum;
            
            return View();
        }
        [HttpGet("success")]
        public IActionResult Passcode()
        {
            int? num= HttpContext.Session.GetInt32("counter");
            num +=1;
            HttpContext.Session.SetInt32("counter", (int)num);

            return RedirectToAction ("Index");
        }

        [HttpGet("restart")]
        public ViewResult Restart()
        {
            // HttpContext.Session.Clear();
            return View("Index");
        }
    }
}
