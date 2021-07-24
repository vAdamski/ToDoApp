using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.Database
{
    public class MainTasksRepository : BaseRepository<MainTask>, IMainTasksRepository
    {
        protected override DbSet<MainTask> DbSet => _dbContext.MainTasks;

        public MainTasksRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

        public bool Add(MainTask mainTask)
        {
            DbSet.Add(mainTask);

            return SaveChanges();
        }
    }
}
