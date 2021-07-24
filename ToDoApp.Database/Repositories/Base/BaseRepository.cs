using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.Database
{
    public abstract class BaseRepository<Entity> where Entity : BaseEntity
    {
        protected AppDbContext _dbContext;

        protected abstract DbSet<Entity> DbSet { get; }

        public BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Entity> GetAll()
        {
            var list = new List<Entity>();

            var entities = DbSet;

            foreach(var entity in entities)
            {
                list.Add(entity);
            }

            return list;
        }

        public bool Delete(int id)
        {
            var entityToDelete = DbSet.Find(id);

            DbSet.Remove(entityToDelete);

            return SaveChanges();
        }

        public bool SaveChanges()
        {
            return _dbContext.SaveChanges() > 0;
        }
    }
}
