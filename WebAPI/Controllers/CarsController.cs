using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
  
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        
        public IActionResult Get()
        {
            var result = _carService.GetAll();
            if (result.Success) 
            {
                return Ok(result);
            }
             return BadRequest(result);
        }

        [HttpPost("add")]    
        public IActionResult Add(Car entity)
        {
            var result = _carService.Add(entity);
               if (result.Success) 
            {
                return Ok(result);
            }  
               return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Car entity)
        {
            var result = _carService.Update(entity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car entity)
        {
            var result = _carService.Delete(entity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}

