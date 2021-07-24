using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Domain
{
    public interface IUnderTasksRepository
    {
        public bool Add(UnderTask underTask);

        public bool Delete(int id);

        public List<UnderTask> GetAll();

        public void SaveChanges();

    }
}
