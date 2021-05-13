namespace TypicalRazorPage.Pages
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    /* This class is the central controller of the razor page,
     * it accepts data (in the OnGet category param)
     * it calls out to the biz logic (the ToDoService) and passes
     * data to the razor view (with the Items list) for razor
     * to generate the appropriate html
     */
    public class CategoryModel : PageModel
    {
        private readonly ToDoService service;

        // This is the view of the MVC
        public List<ToDoListModel> Items { get; set; }

        // This is the Model of the MVC
        public CategoryModel(ToDoService service) => this.service = service;
        
        // This is the controller of the MVC
        public ActionResult OnGet(string category)
        {
            Items = this.service.GetItemsForCategory(category);
            return this.Page();
        }
    }
}
