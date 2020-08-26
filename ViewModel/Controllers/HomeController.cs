using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("users")]
        public ViewResult Index()
        {
            User firstUser = new User()
            {
                FirstName = "Olga",
                LastName = "Druta"
            };
            User secodUser = new User()
            {
                FirstName = "Bob",
            };
            User thirdUser = new User()
            {
                FirstName = "Andy",
                LastName = "Filip"
            };
            User fourthUser = new User()
            {
                FirstName = "Alec",
                LastName = "Boboc"
            };
            List<User> viewModel = new List<User>()
            {
                firstUser,secodUser,thirdUser,fourthUser
            };
            return View(viewModel);
        }
        [HttpGet("/{user}")]
        public ViewResult ViewUser()
        {
            User newUser = new User()
            {
                FirstName = "Olga",
                LastName = "Druta"
            };
            return View(newUser);
        }
        
        [HttpGet("numbers")]
        public ViewResult Numbers()
        {
            int[] numb = new int[]
            {
                1,4,8
            };
 
            return View(numb);
        }
        [HttpGet("")]
        public ViewResult Message()
        {
        //     string message = new string
        //     {
        //         "Here is my message!!!!!!!!!!!"
        //     };
            return View();
        }

    }
}
