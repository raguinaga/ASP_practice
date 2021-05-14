using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PageHandlers.Pages
{
    public class Search : PageModel
    {
        private readonly SearchService searchService;
        public Search(SearchService service) => this.searchService = service;
        
        [BindProperty]
        public BindingModel Input { get; set; }
        public List<Product> Results { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage();
            }
            Results = this.searchService.SearchProducts(Input.SearchTerm);
            return Page();
        }
        
        public class BindingModel
        {
            [Required]
            public string SearchTerm { get; set; }
        }
    }
}