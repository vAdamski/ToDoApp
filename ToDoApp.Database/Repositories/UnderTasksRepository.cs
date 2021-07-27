using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.Database
{
    public class UnderTasksRepository : BaseRepository<UnderTask>, IUnderTasksRepository
    {
        protected override DbSet<UnderTask> DbSet => _dbContext.UnderTasks;

        public UnderTasksRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<UnderTask> GetAllUnderTasks()
        {
            return DbSet.Select(x => x);
        }

        public IEnumerable<UnderTask> GetAllUnderTasksForMainTask(MainTask mainTask)
        {
            return DbSet.Where(x => x.MainTaskId == mainTask.Id);
        }
    }
}
