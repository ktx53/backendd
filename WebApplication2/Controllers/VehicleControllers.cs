using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
using static WebApplication2.Models.Vehicles;

namespace WebApplication2.Controllers
{
    [Route("api/VehicleAPI")]
    [ApiController]
    public class VehicleControllers : ControllerBase
    {

        private readonly VehicleRepository _vehicleRepository;



        [HttpGet("cars/{color}")]
        public ActionResult<IEnumerable<Car>> GetCarsByColor(string color)
        {
            var cars = _vehicleRepository.GetCarsByColor(color);

            if (cars == null || cars.Count() == 0)
            {
                return NotFound();
            }

            return Ok(cars);
        }
        [HttpGet("buses/{color}")]
        public ActionResult<IEnumerable<Bus>> GetBusesByColor(string color)
        {
            List<Vehicle> buses = _vehicleRepository.GetBusesByColor(color);

            if (buses == null || buses.Count() == 0)
            {
                return NotFound();
            }

            return Ok(buses);
        }
        [HttpGet("boats/{color}")]
        public ActionResult<IEnumerable<Boat>> GetBoatsByColor(string color)
        {
            var boats = _vehicleRepository.GetBoatsByColor(color);

            if (boats == null || boats.Count() == 0)
            {
                return NotFound();
            }

            return Ok(boats);
        }
        [HttpDelete("cars/{Id}")]
        public ActionResult<IEnumerable<Car>> DeleteCar(string carId)
        {
            var cars = _vehicleRepository.DeleteCar(cars);

            if (cars == null || carId.Count() == 0)
            {
                return NotFound();
            }

            return Ok(cars);
        }

    }
}
