using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Routing_Examples.Pages
{
    public class Products : PageModel
    {
        private readonly ProductService service;

        public Products(ProductService service)
        {
            this.service = service;
        }
        
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public Product Selected { get; set; }
        
        public IActionResult OnGet()
        {
            Selected = service.GetProduct(Name);
            if (Selected is null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}