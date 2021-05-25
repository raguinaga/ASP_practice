using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageLayout.Pages
{
    public class EditProduct : PageModel
    {
        private readonly ProductService productService;

        public EditProduct(ProductService service) => productService = service;
        
        [BindProperty]
        public InputModel Input { get; set; }
        
        public void OnGet()
        {
            
        }

        public IActionResult OnGet(int id)
        {
            var product = productService.GetProduct(id);
            if (product is null)
            {
                return NotFound();
            }

            Input = new InputModel
            {
                Name = product.Name,
                Price = product.SellPrice,
            };
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var product = productService.GetProduct(id);
            if (product is null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            productService.UpdateProduct(id, Input.Name, Input.Price);
            return RedirectToPage();
        }

        public record InputModel
        {
            [Required]
            public string Name { get; init; }
            
            [Range(0, int.MaxValue)]
            public decimal Price { get; init; }
        }
    }
}