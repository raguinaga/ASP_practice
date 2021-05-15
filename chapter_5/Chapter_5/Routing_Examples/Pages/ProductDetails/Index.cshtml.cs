using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Routing_Examples.Pages.ProductDetails
{
    public class Index : PageModel
    {
        private readonly ProductService service;

        public Index(ProductService service)
        {
            this.service = service;
        }
        
        public Product Selected { get; set; }
        public IActionResult OnGet(string name)
        {
            Selected = this.service.GetProduct(name);
            if (Selected is null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}