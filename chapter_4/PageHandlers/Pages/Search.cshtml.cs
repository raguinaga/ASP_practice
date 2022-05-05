using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PageHandlers.Pages
{
    public class Search : PageModel
    {
        /* Search service is provided to SearchModel for use in page handlers */ 
        private readonly SearchService _searchService;
        public Search(SearchService service) => _searchService = service;
        
        /* Any properties decorated with BindProperty attribute will be model
         * bound */
        [BindProperty]
        public BindingModel Input { get; set; }
        
        // Undecorated props will not be model-bound
        public List<Product> Results { get; set; }
        
        // Page handler does not need to check if the model is valid
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // All bound properties should be checked for validity using
            // ModelState.IsValid 
            if (!ModelState.IsValid)
            {
                return RedirectToPage("/Error");
            }
            Results = SearchService.SearchProducts(Input.SearchTerm);
            return Page();
        }
        
        public class BindingModel
        {
            [Required]
            public string SearchTerm { get; set; }
        }
    }
}