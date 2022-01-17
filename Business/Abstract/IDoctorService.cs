using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IDoctorService:IServiceBase<Doctor>
    {
       
        DataResult<List<DoctorDetailDto>> GetAllDoctorDetailDto();
    }
}