using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToDoList.Pages.ToDo
{
    public class ListCategory : PageModel
    {
        // This annotation defines a binding model as a property of this controller
        [BindProperty(SupportsGet = true)]
        public InputModel Input { get; init; }
        
        public IEnumerable<Task> Tasks { get; private set; }
        
        public IActionResult OnGet()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Validate parameters
            var service = new ToDoService();
            Tasks = service.GetToDoItems(Input.Category, Input.Username).Select(x => new Task(x.Number, x.Title));
            return Page();
        }

        public record InputModel
        {
            [Required]
            public string Username { get; init; }
            
            [Required]
            public string Category { get; init; }
        }
        
        public class Task
        {
            public Task(int id, string description)
            {
                Id = id;
                Description = description;
            }
            
            public int Id { get; init; }
            public string Description { get; init; }
        }
    }
}