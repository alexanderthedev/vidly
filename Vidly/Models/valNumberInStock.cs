using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class ValNumberInStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var numberInStock = (Movie)validationContext.ObjectInstance;

            if ((int)numberInStock.NumberInStock < 0 ||
                (int)numberInStock.NumberInStock > 20)
            {
                return new ValidationResult("Number in stock should be between 0 and 20");
            }


            return ValidationResult.Success;


        }

    }
}