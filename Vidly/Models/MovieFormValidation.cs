using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieFormValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.NumberInStock < 0 || movie.NumberInStock > 20)
            {
                return new ValidationResult("Choose from 0-20");
            }
            
            return ValidationResult.Success;
            
        }
    }
}