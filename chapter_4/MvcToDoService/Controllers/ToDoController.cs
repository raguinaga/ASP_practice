namespace MvcToDoService.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using MvcToDoService.Models;
    using System.Collections.Generic;

    public class ToDoController : Controller
    {
        private readonly ToDoService service;

        public ToDoController(ToDoService service) => this.service = service;

        public ActionResult Category(string id)
        {
            List<ToDoListModel> items = this.service.GetItemsForCategory(id);
            var viewModel = new CategoryViewModel(items);

            return View(viewModel);
        }
    }
}
