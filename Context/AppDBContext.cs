using Microsoft.EntityFrameworkCore;
using TodoListapi.Model;

namespace TodoListapi.Context
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) { }
      
        public DbSet<TodoItem> todoItems { get; set; }
    }
}
