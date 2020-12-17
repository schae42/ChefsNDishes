using System;
using System.ComponentModel.DataAnnotations;

namespace ChefNDishes.Models 
{
    public class Dish 
    {
        [Key]
        public int DishId {get;set;}
        [Required]

        [Display(Name="Name of Dish")]
        public string Name {get;set;}
        [Required]

        [Display(Name="# of Calories")]
        [Range(1, Int32.MaxValue, ErrorMessage="Calories must be greater than 0")]
        public int Calories {get;set;}
        [Required]

        public string Description {get;set;}
        [Required]
        public int ChefId {get;set;}
        public Chef Chef {get;set;}
        [Required]
        public int Tastiness {get;set;}
    }
}