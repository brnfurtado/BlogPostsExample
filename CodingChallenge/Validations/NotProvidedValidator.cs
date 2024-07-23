using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CodingChallenge.Validations
{
    public class NotProvidedAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && !Guid.Empty.Equals(value))
            {
                return new ValidationResult("This object should not be provided.");
            }
            return ValidationResult.Success;
        }
    }

}