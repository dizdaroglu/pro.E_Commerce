using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pro.CoreLayer.GenericRepository
{
    public class GenericRepo<T> : IGenericRepository<T> where T : class, new()
    {
        protected DbContext _context;
        private DbSet<T> objectSet;
        public GenericRepo(DbContext context)
        {
            _context = context;
            objectSet = _context.Set<T>();
        }
        
        public void Add(T entity)
        {
            objectSet.Add(entity);

        }

        public void AddRange(List<T> entities)
        {
            objectSet.AddRange(entities);

        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return objectSet.FirstOrDefault(where);
        }

        public List<T> FindAll(Expression<Func<T, bool>> predicate)
        {
            return objectSet.Where(predicate).ToList();
        }

        public void Remove(T entity)
        {
            objectSet.Remove(entity);
        }

        public void RemoveRange(List<T> entities)
        {
            objectSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            // Save Change 
            _context.Entry<T>(entity).State = EntityState.Modified;
        }
    }
}
