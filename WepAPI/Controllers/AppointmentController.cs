using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : Controller
    {
        private IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _appointmentService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Appointment appointment)
        {
            var result = _appointmentService.Add(appointment);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        // [HttpGet("getalldoctordetail")]
        // public IActionResult GetAllDoctorDetail()
        // {
        //     var result = _doctorService.GetAllDoctorDetailDto();
        //     if (result.Success)
        //     {
        //         return Ok(result);
        //     }
        //
        //     return BadRequest(result.Message);
        // }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _appointmentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}