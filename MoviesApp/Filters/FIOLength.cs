using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Filters
{
    public class FIOLength : ValidationAttribute
    {
        private readonly int nameLength;

        public FIOLength(int nameLength)
        {
            this.nameLength = nameLength;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString().Length < nameLength) return new ValidationResult(this.ErrorMessage);

            return ValidationResult.Success;
        }
    }
}