using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentController : Controller
    {
        private ITreatmentService _treatmentService;

        public TreatmentController(ITreatmentService treatmentService)
        {
            _treatmentService = treatmentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _treatmentService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Treatment treatment)
        {
            var result = _treatmentService.Add(treatment);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _treatmentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}