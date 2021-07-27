using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Domain
{
    public interface IUnderTasksRepository : IRepository<UnderTask>
    {
        public IEnumerable<UnderTask> GetAllUnderTasks();

        public IEnumerable<UnderTask> GetAllUnderTasksForMainTask(MainTask mainTask);

    }
}
