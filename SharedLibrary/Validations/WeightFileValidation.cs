using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Validations
{
    public class WeightFileValidation : ValidationAttribute
    {
        private readonly int maxWeightOnMegaBytes;

        public WeightFileValidation(int maxWeightOnMegaBytes) 
        {
            this.maxWeightOnMegaBytes = maxWeightOnMegaBytes;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            IFormFile formFile = value as IFormFile;

            if(formFile == null) return ValidationResult.Success;

            if (formFile.Length > maxWeightOnMegaBytes * 1024 * 1024)
                return new ValidationResult($"The weight of the file should not be greater than {maxWeightOnMegaBytes}mb");

            return ValidationResult.Success;
        }
    }
}
