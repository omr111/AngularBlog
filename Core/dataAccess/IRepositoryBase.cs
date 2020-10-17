
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Core.dataAccess
{
    public interface IRepositoryBase<T> where T:class,new() 
    {
        IQueryable<T> getAll(Expression<Func<T, bool>> filter = null);
        T getOne(Expression<Func<T, bool>> filter);
        void add(T entity);
        void delete(T entity);
        void update(T entity);
    }
}
