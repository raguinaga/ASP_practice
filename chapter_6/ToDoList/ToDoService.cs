using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList
{
    public class ToDoService
    {
        public ICollection<ToDoModel> GetToDoItems(string category, string username)
        {
            return toDos
                  .Where(x => string.Equals(x.State, category, StringComparison.OrdinalIgnoreCase))
                  .Where(x => string.Equals(x.Login, username, StringComparison.OrdinalIgnoreCase))
                  .ToList();
        }

        private readonly static List<ToDoModel> toDos = new()
        {
            new ToDoModel
            {
                Number = 102,
                Title = "Consider a No April Fool's Day issues / pulls policy",
                Login = "dave",
                State = "open"
            },
            new ToDoModel
            {
                Number = 100,
                Title = " The .gitignore is far too long",
                Login = "billy",
                State = "Closed"
            },
            new ToDoModel
            {
                Number = 99,
                Title = "Poor code coverage.",
                Login = "andrew",
                State = "closed"
            },
            new ToDoModel
            {
                Number = 97,
                Title = "TL;DR",
                Login = "andrew",
                State = "closed"
            },
            new ToDoModel
            {
                Number = 96,
                Title = "Added analyzers: Sonar.Lint, FxCop, StyleCop, Ndepend",
                Login = "james",
                State = "open"
            },
            new ToDoModel
            {
                Number = 95,
                Title = "size of source files",
                Login = "andrew",
                State = "open"
            },
            new ToDoModel
            {
                Number = 94,
                Title = "System.Ben is layered incorrectly",
                Login = "james",
                State = "open"
            },
            new ToDoModel
            {
                Number = 93,
                Title = "Fix dotnet-cli errors from 'dotnet test'",
                Login = "james",
                State = "open"
            },
            new ToDoModel
            {
                Number = 92,
                Title = "Allocate a new Ben is too slow",
                Login = "slodge",
                State = "open"
            }
        };
    }
}