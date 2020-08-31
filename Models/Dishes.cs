using System.ComponentModel.DataAnnotations;
using System;
namespace CRUDelicious.Models
{
    public class Dish
    {
        public int DishId{get;set;}

        [Required]
        public string Name{get;set;}

    
        [Required]
        public string Chef{get;set;}

        [Required]
        [Range(1,5)]
        public int Tastiness{get;set;}

        [Required]
        [Range(0, 10000)]
        public int Calories{get;set;}

        [Required]
        public string Description{get;set;}

        [Required]
        public DateTime CreatedAt {get;set;}

        [Required]
        public DateTime UpdatedAt {get;set;}
    }


}