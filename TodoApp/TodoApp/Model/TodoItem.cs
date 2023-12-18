using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Model
{
    internal class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsComplete { get; set; }

        public TodoItem()
        {
            IsComplete = false;
        }

        public TodoItem(int ıd, string title, string description, DateTime dueDate)
        {
            Id = ıd;
            Title = title;
            Description = description;
            DueDate = dueDate;
        }

        public override string? ToString()
        {
            return $"{Id} {Title} {Description} {DueDate} {IsComplete}";
        }
        
    }
}
