using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Domain
{
    public interface IRepository<Entity> where Entity : BaseEntity
    {
        bool Add(Entity entity);
        bool Delete(Entity entity);
    }
}
