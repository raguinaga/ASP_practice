namespace TypicalRazorPage.Pages
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class CategoryModel : PageModel
    {
        private readonly ToDoService service;
        public List<ToDoListModel> Items { get; set; }

        public CategoryModel(ToDoService service) => this.service = service;
        
        public ActionResult OnGet(string category)
        {
            Items = this.service.GetItemsForCategory(category);
            return this.Page();
        }
    }
}
