using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CurrencyConverter.Pages
{
    public class Convert : PageModel
    {
        public string Values { get; set; }

        public void OnGet(string currencyIn, string currencyOut, int qty)
        {
            Values = $@"CurrencyIn: {currencyIn}
            CurrencyOut: {currencyOut}
            Qty: {qty}";
        }

        public void OnPost(string currencyIn, string currencyOut, int qty)
        {
            Values = $@"CurrencyIn: {currencyIn}
            CurrencyOut: {currencyOut}
            Qty: {qty}";
        }
    }
}