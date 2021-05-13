namespace MvcToDoService.Models
{
    using Microsoft.AspNetCore.Mvc;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CategoryViewModel
    {
        public List<ToDoListModel> Items{ get; set; }

        public CategoryViewModel(List<ToDoListModel> items) => this.Items = items;
    }
}
