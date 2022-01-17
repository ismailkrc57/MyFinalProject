using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDoctorDal : EfEntityRepositoryBase<Doctor, WepAppProjectContext>, IDoctorDal
    {
        public List<DoctorDetailDto> GetAllDoctorDetailDto()
        {
            using (WepAppProjectContext context = new WepAppProjectContext())
            {
                var result = from doctor in context.Doctors
                    join person in context.Persons on doctor.PERSON_ID equals person.ID
                    join bolum in context.Bolums on doctor.BOLUM_ID equals bolum.ID 
                    select new DoctorDetailDto()
                    {
                        Id = doctor.ID,
                        Bolum = bolum.NAME,
                        Name = person.NAME,
                        Surname = person.SURNAME,
                        Gender = person.GENDER
                    };
                return result.ToList();
            }
        }
    }
}