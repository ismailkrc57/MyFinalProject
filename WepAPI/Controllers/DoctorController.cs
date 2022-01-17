using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : Controller
    {
        private IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _doctorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Doctor doctor)
        {
            var result = _doctorService.Add(doctor);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getalldoctordetail")]
        public IActionResult GetAllDoctorDetail()
        {
            var result = _doctorService.GetAllDoctorDetailDto();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _doctorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}