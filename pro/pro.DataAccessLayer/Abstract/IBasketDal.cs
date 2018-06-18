using pro.CoreLayer.GenericRepository;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.DataAccessLayer.Abstract
{
    public interface IBasketDal:IGenericRepository<Basket>
    {
        // ortak Kulanılan metodlar
        //void Add(TEntity entity);

        //void Remove(TEntity entity);

        //void Update(TEntity entity);

        //TEntity Find(Expression<Func<TEntity, bool>> where);

        //List<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate);

        //void RemoveRange(List<TEntity> entities);

        //void AddRange(List<TEntity> entities);
    }
}

