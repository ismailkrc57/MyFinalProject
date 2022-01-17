using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BolumManager : IBolumService
    {
        private IBolumDal _bolumDal;

        public BolumManager(IBolumDal bolumDal)
        {
            _bolumDal = bolumDal;
        }

        public DataResult<List<Bolum>> GetAll()
        {
            return new SuccessDataResult<List<Bolum>>(_bolumDal.GetAll());
        }

        public DataResult<Bolum> GetById(int id)
        {
            return new SuccessDataResult<Bolum>(_bolumDal.Get(b => b.ID == id));
        }

        public Result Add(Bolum entity)
        {
            throw new System.NotImplementedException();
        }

        public Result Delete(Bolum entity)
        {
            throw new System.NotImplementedException();
        }

        public Result Update(Bolum entity)
        {
            throw new System.NotImplementedException();
        }
    }
}