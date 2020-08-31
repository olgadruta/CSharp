using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            List<Dish> allDishes = dbContext.Dishes.OrderByDescending(dish => dish.CreatedAt).ToList();
            return View(allDishes);
        }

        [HttpGet("new")]
        public IActionResult AddDish()
        {
            return View();
        }

        [HttpPost("newdish")]
        public IActionResult NewDish(Dish food )
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(food);
                dbContext.SaveChanges();
                // System.Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                return RedirectToAction("Index");
            }
            else
            {
                return View("AddDish");
            }
        }

        [HttpGet("/{Id}")]
        public IActionResult ViewDish(int Id)
        {
            Dish singledish = dbContext.Dishes.FirstOrDefault(d => d.DishId == Id);
            return View(singledish);
        }


        [HttpGet("/edit/{Id}")]
        public ViewResult EditDish(int Id)
        {
            // System.Console.WriteLine("*******************************************" + ID);
            Dish editDish = dbContext.Dishes.FirstOrDefault(updated => updated.DishId == Id);
            // System.Console.WriteLine("*******************************************" + editDish.Name);
            return View("Edit", editDish);
        }

        [HttpPost("update/{Id}")]
        public IActionResult UpdateDish(Dish newDish, int Id)
        {
            System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$" + Id);
            if(ModelState.IsValid)
            {
                Dish updateDish = dbContext.Dishes.FirstOrDefault(updated => updated.DishId == Id);
                updateDish.Name = newDish.Name;
                updateDish.Chef = newDish.Chef;
                updateDish.Tastiness = newDish.Tastiness;
                updateDish.Calories = newDish.Calories;
                updateDish.Description = newDish.Description;
                dbContext.SaveChanges();
                System.Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$" + updateDish.Name);
                System.Console.WriteLine("#####################################" + newDish.Name);
                return RedirectToAction("ViewDish", new{Id = updateDish.DishId});
            }
            else
            {
                return RedirectToAction("EditDish", new{Id = Id});
            }
        }

        [HttpGet("delete/{Id}")]
        public IActionResult DeleteDish(int Id)
        {
            Dish deletedish = dbContext.Dishes.FirstOrDefault(d => d.DishId == Id);
            dbContext.Dishes.Remove(deletedish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
