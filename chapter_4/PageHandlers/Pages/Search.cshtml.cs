using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PageHandlers.Pages
{
    public class Search : PageModel
    {
        /* Sear service is provided to SearchModel for use in page handlers */ 
        private readonly SearchService searchService;
        public Search(SearchService service) => this.searchService = service;
        
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