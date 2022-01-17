using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController:Controller
    {
        private IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _patientService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Patient patient)
        {
            var result = _patientService.Add(patient);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _patientService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}