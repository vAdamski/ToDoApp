using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<MainTask> MainTasks { get; set; }
        public DbSet<UnderTask> UnderTasks { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
