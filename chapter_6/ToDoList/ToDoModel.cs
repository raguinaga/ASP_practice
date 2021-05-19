namespace ToDoList
{
    public record ToDoModel
    {
        public int Number { get; init; }
        public string Title { get; init; }
        public string Login { get; init; }
        public string State { get; init; }
    }
}