using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.Common.ResponseObjects;

namespace Udemy.TodoAppNTier.Business.Extensions
{
    public static class ValidationResultExtensions
    {
        public static List<CustomValidationError> ConvertToCustomValidationError(this ValidationResult validationResult)
        {
            List<CustomValidationError> errors = new();
            foreach (var error in validationResult.Errors)
            {
                errors.Add(new() { ErrorMessage = error.ErrorMessage, PropertyName = error.PropertyName });
            }
            return errors;
        }
    }
}
