using Cars.API.Models;
using Cars.API.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Cars.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowCarsApp")]
    public class CarsController : ControllerBase
    {
        private readonly CarService _carService;

        public CarsController(CarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult GetAllCars()
        {
            return Ok(_carService.GetAllCars());
        }

        [HttpGet("{id}")]
        public IActionResult GetCarById(int id)
        {
            var car = _carService.GetCarById(id);

            if (car is null)
                return NotFound();

            return Ok(car);
        }

        [HttpPost]
        public IActionResult CreateCar([FromBody] Car car)
        {
            _carService.CreateCar(car);
            return CreatedAtAction(nameof(GetCarById), new { id = car.Id }, car);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCar(int id, [FromBody] Car car)
        {
            _carService.UpdateCar(id, car);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            _carService.DeleteCar(id);
            return NoContent();
        }
    }
}
