using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PatientManager:IPatientService
    {
        private IPatientDal _patientDal;

        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }

        public DataResult<List<Patient>> GetAll()
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetAll());
        }

        public DataResult<Patient> GetById(int id)
        {
            return new SuccessDataResult<Patient>(_patientDal.Get(p => p.ID == id));
        }

        public Result Add(Patient entity)
        {
            throw new System.NotImplementedException();
        }

        public Result Delete(Patient entity)
        {
            throw new System.NotImplementedException();
        }

        public Result Update(Patient entity)
        {
            throw new System.NotImplementedException();
        }
    }
}