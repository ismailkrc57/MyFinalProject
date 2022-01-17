using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public DataResult<List<Person>> GetAll()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetAll());
        }

        public DataResult<Person> GetById(int id)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.ID == id));
        }

        public Result Add(Person entity)
        {
            throw new System.NotImplementedException();
        }

        public Result Delete(Person entity)
        {
            throw new System.NotImplementedException();
        }

        public Result Update(Person entity)
        {
            throw new System.NotImplementedException();
        }
    }
}