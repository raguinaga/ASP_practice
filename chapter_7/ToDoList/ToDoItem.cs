using System.Collections.Generic;

namespace ToDoList
{
    public class ToDoItem
    {
        // fields
        public int Id { get; init; }
        public List<string> Tasks { get; init; }
        public bool IsComplete => Tasks.Count == 0;
        
        public ToDoItem(int id, params string[] tasks)
        {
            Id = id;
            Tasks = new List<string>(tasks);
        }
    }
}