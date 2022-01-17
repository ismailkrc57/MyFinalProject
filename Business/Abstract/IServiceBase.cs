using System.Collections.Generic;
using Core.Entities;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IServiceBase<T> where T : IEntity, new()
    {
        public DataResult<List<T>> GetAll();
        public DataResult<T> GetById(int id);
        public Result Add(T entity);
        public Result Delete(T entity);
        public Result Update(T entity);
    }
}