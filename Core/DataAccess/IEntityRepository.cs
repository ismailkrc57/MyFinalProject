using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;


namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new() // Generic Constraint, what should T be 
    {
        List<T> GetAll(Expression<Func<T, bool>> filterExpression = null);
        T Get(Expression<Func<T, bool>> filterExpression);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
