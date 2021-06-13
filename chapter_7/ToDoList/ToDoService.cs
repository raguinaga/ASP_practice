using System.Collections.Generic;

namespace ToDoList
{
    public class ToDoService
    {
        public List<ToDoItem> AllItems { get; } = new()
        {
            new ToDoItem(1, "Buy Milk", "Buy Eggs", "Buy Bread"),
            new ToDoItem(2, "Pick up kids", "Take kids to school"),
            new ToDoItem(3, "Get Fuel", "<strong>Check oil</strong>", "Check tire pressure"),
            new ToDoItem(4, "Get fuel", "check oil", "check tire pressure"),
        };
    }
}