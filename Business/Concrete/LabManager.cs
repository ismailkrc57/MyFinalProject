using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class LabManager : ILabService
    {
        private ILaboratuarSiraDal _laboratuarSiraDal;

        public LabManager(ILaboratuarSiraDal laboratuarSiraDal)
        {
            _laboratuarSiraDal = laboratuarSiraDal;
        }

        public DataResult<List<LaboratuarSira>> GetAll()
        {
            return new SuccessDataResult<List<LaboratuarSira>>(_laboratuarSiraDal.GetAll());
        }

        public DataResult<LaboratuarSira> GetById(int id)
        {
            return new SuccessDataResult<LaboratuarSira>(_laboratuarSiraDal.Get(l => l.ID == id));
        }

        public Result Add(LaboratuarSira entity)
        {
            throw new System.NotImplementedException();
        }

        public Result Delete(LaboratuarSira entity)
        {
            throw new System.NotImplementedException();
        }

        public Result Update(LaboratuarSira entity)
        {
            throw new System.NotImplementedException();
        }
    }
}