using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManageUsers.Pages
{
    public class ViewUsers : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Username { get; set; }
        public void OnGet()
        {
            
        }
    }
}