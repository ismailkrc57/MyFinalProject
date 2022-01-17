using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BolumController:Controller
    {
        private IBolumService _bolumService;

        public BolumController(IBolumService bolumService)
        {
            _bolumService = bolumService;
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bolumService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Bolum bolum)
        {
            var result = _bolumService.Add(bolum);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _bolumService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}