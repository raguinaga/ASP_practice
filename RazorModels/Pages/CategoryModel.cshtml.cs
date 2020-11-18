namespace RazorModel.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http.Features;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class CategoryModel : PageModel
    {
        private readonly ToDoService _service;
        public CategoryModel(ToDoService service)
        {
            _service = service;
        }

        /* OnGet accepts a string parameter that is automatically
        populated by the ASP framework using values using the incoming
        request. Our handler here does not handle the database directly
         it instead interacts that the service*/
        public ActionResult OnGet(string category)
        {
            Items = _service.GetItemsForCategory(category);
            // return page indicates a razor view should be rendered
            return Page();
        }

        // The razor view can access this property 
        public List<ToDoListModel> Items { get; set; }
    }
}