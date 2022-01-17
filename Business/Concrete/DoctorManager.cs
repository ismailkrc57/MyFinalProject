using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class DoctorManager : IDoctorService
    {
        private IDoctorDal _doctorDal;

        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }

        public DataResult<List<Doctor>> GetAll()
        {
            return new SuccessDataResult<List<Doctor>>(_doctorDal.GetAll());
        }

        public Result Add(Doctor doctor)
        {
            _doctorDal.Add(doctor);
            return new SuccessResult("Doctor Added");
        }

        public Result Delete(Doctor entity)
        {
            _doctorDal.Delete(entity);
            return new SuccessResult("Doctor deleted");
        }

        public Result Update(Doctor entity)
        {
            _doctorDal.Update(entity);
            return new SuccessResult("Doctor Updated");
        }
        

        public DataResult<Doctor> GetById(int id)
        {
            return new SuccessDataResult<Doctor>(_doctorDal.Get(d => d.ID == id));
        }

        public DataResult<List<DoctorDetailDto>> GetAllDoctorDetailDto()
        {
            return new SuccessDataResult<List<DoctorDetailDto>>(_doctorDal.GetAllDoctorDetailDto());
        }
    }
}