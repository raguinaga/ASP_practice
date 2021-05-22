using System.Collections.Generic;

namespace ListBinding
{
    public class CurrencyService
    {
        public static readonly Dictionary<string, decimal> AllCurrencies = new()
        {
            {"GBP", 1.00m},
            {"USD", 1.22m},
            {"CAD", 1.64m},
            {"EUR", 1.15m}
        };
    }
}