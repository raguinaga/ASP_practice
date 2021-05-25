using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CurrencyConverterValidated.Pages.Currency
{
    public class Convert : PageModel
    {
        [BindProperty]
        public InputModel Model { get; init; }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("Success");
        }
        
        public record InputModel
        {
            [Required]
            [StringLength(3, MinimumLength = 3)]
            [CurrencyCode("GBP", "USD", "CAD", "EUR")]
            public string CurrencyFrom { get; init; }
            
            [Required]
            [StringLength(3, MinimumLength = 3)]
            [CurrencyCode("GBP", "USD","CAD", "EUR")]
            public string CurrencyTo { get; init; }
            
            [Required]
            [Range(1, 1_000)]
            public decimal Quantity { get; init; }
        }
    }
}