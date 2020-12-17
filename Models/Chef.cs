using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefNDishes.Models 
{
    
    public class Chef 
    {
        [Key]
        public int ChefId {get; set;}
        [Required]

        [Display(Name="First Name")]
        public string FirstName {get;set;}
        [Required]

        [Display(Name="Last Name")]
        public string LastName {get;set;}
        [Required]

        [Display(Name="Date of Birth")]
        [NoFutureDate]
        public DateTime DateOfBirth {get;set;}
        public int Age {get;set;}
        public List<Dish> CreatedDishes {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }

    public class NoFutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((DateTime)value > DateTime.Now)
                return new ValidationResult("Date must be in the past");
            return ValidationResult.Success;
        }
    }
}