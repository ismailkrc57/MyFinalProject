using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        private IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public DataResult<List<Appointment>> GetAll()
        {
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll());
        }

        public DataResult<Appointment> GetById(int id)
        {
            return new SuccessDataResult<Appointment>(_appointmentDal.Get(a => a.ID == id));
        }

        public Result Add(Appointment entity)
        {
            _appointmentDal.Add(entity);
            return new SuccessResult("Appointment Added");
        }

        public Result Delete(Appointment entity)
        {
            _appointmentDal.Delete(entity);
            return new SuccessResult("Appointment deleted");
        }

        public Result Update(Appointment entity)
        {
            _appointmentDal.Update(entity);
            return new SuccessResult("Appointment updated");
        }
    }
}