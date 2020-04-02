using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;

namespace TodoApi.Data
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext (DbContextOptions<TodoDBContext> options)
            : base(options)
        {
        }

        public DbSet<Todo.Domain.Entities.TodoItem> TodoItem { get; set; }
    }
}
