using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataValidation.Pages
{
    public class Checkout : PageModel
    {
        [BindProperty]
        public UserBindingModel Input { get; init; }
        
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
        
        public record UserBindingModel
        {
            [Required]
            [StringLength(100)]
            [Display(Name = "Your Name")]
            public string FirstName { get; init; }
            
            [Required]
            [StringLength(100)]
            [Display(Name = "Last Name")]
            public string LastName { get; init; }
            
            [Required]
            [EmailAddress]
            public string Email { get; init; }
            
            [Phone]
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; init; }
        }
    }
}