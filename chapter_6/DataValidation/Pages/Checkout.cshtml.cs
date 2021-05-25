using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataValidation.Pages
{
    public class Checkout : PageModel
    {
        [BindProperty] public UserBindingModel Input { get; init; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Check for validity right off the bat
            if (!ModelState.IsValid)
            {
                // re-display page with errors if model fails validation checks
                return Page();
            }

            return RedirectToPage("Success");
        }

        public record UserBindingModel
        {
            [Required]                    // Values marked required must be provided
            [StringLength(100)]           // String length sets max for the property
            [Display(Name = "Your Name")] // Customizes the name used to describe the property
            public string FirstName { get; init; }

            [Required]
            [StringLength(100)]
            [Display(Name = "Last Name")]
            public string LastName { get; init; }
    
            // The email address annotation enforces a proper email address is entered
            [Required] [EmailAddress] public string Email { get; init; }
            
            [Phone] // Optional phone number, checks value for valid value
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; init; }
        }
    }
}