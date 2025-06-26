using Microsoft.EntityFrameworkCore;
using TaskManagerApp.Models;

namespace TaskManagerApp.Data
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base(options)
        {
        }

        public DbSet<TaskItem> TaskItems { get; set; }
    }
}