using System;
using System.Collections.Generic;

namespace hungry_ninja
{

    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int calories, bool isSpice, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpice;
            IsSweet = isSweet;
        }
    }

    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                // add a constructor and set Menu to a hard coded list of 7 or more Food objects you instantiate manually
                new Food("Ice cream", 900, false, true),
                new Food("Bananas", 300, false, false),
                new Food("Watermelon", 600, false, true),
                new Food("Fish", 450, false, false),
                new Food("Salad", 400, true, false),
                new Food("Bread", 400, false, true),
                new Food("Chips", 1100, true, true),
            };
        }
        // build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object
        public Food Serve()
        {
            Random foodList = new Random();
            return (Menu[foodList.Next(0, Menu.Count - 1)]);
        }
    }

    class Ninja
    {
        // public string Name;
        private int calorieIntake;
        public List<Food> FoodHistory;
        public int caloriesProps
        {
            get { return calorieIntake; }
        }


        public Ninja()
        {
            // Name = name;
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool isFull
        {
            get
            {
                if (calorieIntake >= 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Eat(Food item)
        {
            // while (calorieIntake < 1200)
            if (!isFull)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($" You are eating {item.Name}");
                // Console.WriteLine($" You are eating {item.Name} and it's spicy {item.IsSpicy} or it's sweet {item.IsSweet}?");
            }
            else
            {
                Console.WriteLine($"Ninja ate {this.caloriesProps} calories and cannot eat anymore!!!");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Buffet dojo = new Buffet();
            Console.WriteLine(dojo.Serve().Name);
            Ninja newNinja = new Ninja();
            // while (!newNinja.isFull)
            // {
            //     newNinja.Eat(dojo.Serve());
            // }
            newNinja.Eat(dojo.Serve());
            newNinja.Eat(dojo.Serve());
            newNinja.Eat(dojo.Serve());
            newNinja.Eat(dojo.Serve());
            // Console.WriteLine(newNinja.Eat());

        }
    }
}
