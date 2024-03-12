using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Validations
{
    public class FileTypeValidation : ValidationAttribute
    {
        private readonly string[] validTypes;

        public FileTypeValidation(string[] validTypes) 
        {
            this.validTypes = validTypes;
        }

        public FileTypeValidation(FileTypeGroup fileTypeGroup)
        {
            if (fileTypeGroup == FileTypeGroup.Image)
                validTypes = new string[] { "image/jpeg", "iamge/png", "image/gif" };
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            IFormFile formFile = value as IFormFile;

            if (formFile == null) return ValidationResult.Success;

            if (!validTypes.Contains(formFile.ContentType))
                return new ValidationResult($"The file type must be one of the following: {string.Join(", ", validTypes)}");

            return ValidationResult.Success;
        }
    }
}
