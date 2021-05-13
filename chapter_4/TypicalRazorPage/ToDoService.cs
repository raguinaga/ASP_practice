namespace TypicalRazorPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ToDoService
    {
        private static readonly List<ToDoListModel> items = new List<ToDoListModel>
        {
            new ToDoListModel{ Category = "Simple", Title = "Bread" },
            new ToDoListModel{ Category = "Simple", Title = "Milk" },
            new ToDoListModel{ Category = "Simple", Title = "Get Gas" },
            new ToDoListModel{ Category = "Long", Title = "Write Book" },
            new ToDoListModel{ Category = "Long", Title = "Build Application" },
        };

        public List<ToDoListModel> GetItemsForCategory(string category)
        {
            return items.Where(x => x.Category == category).ToList();
        }
    }
}
