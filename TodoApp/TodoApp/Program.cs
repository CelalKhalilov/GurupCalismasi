using TodoApp.Model;
using TodoApp.Model.TodoList;

TodoList todoList = new TodoList();

todoList.AddItem(new TodoItem(2, "harun", "guclu",DateTime.Now));
todoList.AddItem(new TodoItem(3, "harun", "guclu",DateTime.Now));
todoList.AddItem(new TodoItem(4, "harun", "guclu",DateTime.Now));
todoList.AddItem(new TodoItem(80, "harun", "guclu",DateTime.Now));

todoList.DisplayTask();
todoList.RemoveItem(2);
todoList.DisplayTask();

todoList.MarkComplete(1);
todoList.DisplayTask();
