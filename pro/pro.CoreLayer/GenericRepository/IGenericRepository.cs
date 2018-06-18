using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pro.CoreLayer.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity:class,new()
    {
        // ortak Kulanılan metodlar
        void Add(TEntity entity);

        void Remove(TEntity entity);

        void Update(TEntity entity);

        TEntity Find(Expression<Func<TEntity, bool>> where);

        List<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate=null);

        void RemoveRange(List<TEntity> entities);

        void AddRange(List<TEntity> entities);



    }
}
