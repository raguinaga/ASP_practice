namespace CurrencyConverter
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    public class CurrencyCodeAttribute : ValidationAttribute
    {
        private readonly string[] allowedCodes;

        public CurrencyCodeAttribute(params string[] allowedCodes)
        {
            this.allowedCodes = allowedCodes;
        }

        protected override ValidationResult? IsValid(
            object value,
            ValidationContext validationContext)
        {
            return value is not string code || !allowedCodes.Contains(code)
                ? new ValidationResult("Not a valid currency code")
                : ValidationResult.Success;
        }
    }
}