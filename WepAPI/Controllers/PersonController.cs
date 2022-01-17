using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController:Controller
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _personService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Person person)             
        {
            var result = _personService.Add(person);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _personService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}