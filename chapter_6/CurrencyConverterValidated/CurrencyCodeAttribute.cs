using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CurrencyConverterValidated
{
    public class CurrencyCodeAttribute : ValidationAttribute
    {
        private readonly string[] allowedCodes;

        public CurrencyCodeAttribute(params string[] allowedCodes)
        {
            this.allowedCodes = allowedCodes;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is not string code || !allowedCodes.Contains(code))
            {
                return new ValidationResult("Not a valid currency code");
            }
            return ValidationResult.Success;
        }
    }
}