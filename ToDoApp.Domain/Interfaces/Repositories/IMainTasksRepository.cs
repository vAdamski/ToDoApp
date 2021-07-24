using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Domain
{
    public interface IMainTasksRepository
    {
        public bool Add(MainTask mainTask);

        public bool Delete(int id);

        public List<MainTask> GetAll();

        public void SaveChanges();

    }
}
