

namespace TodoApp.Model.TodoList
{
    internal class TodoList
    {
        private List<TodoItem> _items;

        public TodoList()
        {
            _items = new List<TodoItem>()
            {
               new TodoItem()
               {
                   Id = 1,
                   Title = "Test",
                   Description = "Test",
                   DueDate = DateTime.Now
               }
            };
        }
        public void AddItem(TodoItem todoItem)
        {
              _items.Add(todoItem);
        }
        public void RemoveItem(int id)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id.Equals(id) )
                {
                    _items.RemoveAt(i);
                    break;
                }
            }
        } 
        public void MarkComplete(int id)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id.Equals(id))
                {
                    _items[i].IsComplete = true;
                    break;
                }
            }
        }
        //public List<TodoItem> GetDueItems(DateTime dateTime)
        //{
            
        //}
        //public List<TodoItem> GetItems()
        //{
            
        //}
        //public TodoItem GetOneItem(int id)
        //{
            
        //}
        public void DisplayTask()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
        
        public TodoList(List<TodoItem> todoItems)
        {
            
        }
    }
}
