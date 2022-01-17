using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaboratuarSiraController:Controller
    {
        private ILabService _labService;

        public LaboratuarSiraController(ILabService labService)
        {
            _labService = labService;
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _labService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(LaboratuarSira laboratuarSira)
        {
            var result = _labService.Add(laboratuarSira);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _labService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}