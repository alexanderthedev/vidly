using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAmember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MemberShipTypeId == 0 || 
                customer.MemberShipTypeId == 1)
            {
                return  ValidationResult.Success;
            }

            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthday is required");
            }

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            if (age >= 18)
            {
               return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Customer should be at least 18 years old");
            }
        }
    }
}