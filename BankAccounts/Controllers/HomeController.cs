﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccounts.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Controllers
{
    public class HomeController : Controller
    {
        private BankContext dbContext;

        public HomeController(BankContext context)
        {
            dbContext = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

    }
}
