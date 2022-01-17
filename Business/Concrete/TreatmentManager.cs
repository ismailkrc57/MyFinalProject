using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TreatmentManager : ITreatmentService
    {
        private ITreatmentDal _treatmentDal;

        public TreatmentManager(ITreatmentDal treatmentDal)
        {
            _treatmentDal = treatmentDal;
        }

        public DataResult<List<Treatment>> GetAll()
        {
            return new SuccessDataResult<List<Treatment>>(_treatmentDal.GetAll());
        }

        public DataResult<Treatment> GetById(int id)
        {
            return new SuccessDataResult<Treatment>(_treatmentDal.Get(t => t.ID == id));
            
        }

        public Result Add(Treatment entity)
        {
            throw new System.NotImplementedException();
        }

        public Result Delete(Treatment entity)
        {
            throw new System.NotImplementedException();
        }

        public Result Update(Treatment entity)
        {
            throw new System.NotImplementedException();
        }
    }
}