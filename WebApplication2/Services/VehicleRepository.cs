using WebApplication2.Models;
using static WebApplication2.Models.Vehicles;

namespace WebApplication2.Data
{
    public class VehicleRepository
    {
        private static List<Vehicle> _vehicles = new List<Vehicle>();
        public VehicleRepository()
        {
            _vehicles.Add(new Car("red"));


            _vehicles.Add(new Car("black"));
            _vehicles.Add(new Bus("white"));
            _vehicles.Add(new Boat("blue"));
            _vehicles.Add(new Boat("white"));
        }
        public IEnumerable<Vehicle> GetAll()
        {
            return _vehicles;
        }
        public List<Vehicle> GetCarsByColor(string color)
        {
            return _vehicles.Where(v => v.Color == color && v.GetType() == typeof(Car)).ToList();
        }

        public List<Vehicle> GetBusesByColor(string color)
        {
            return _vehicles.Where(v => v.Color == color && v.GetType() == typeof(Bus)).ToList();
        }

        public List<Vehicle> GetBoatsByColor(string color)
        {
            return _vehicles.Where(v => v.Color == color && v.GetType() == typeof(Boat)).ToList();
        }

        public void TurnOnOffCarHeadlights(int carId)
        {
            var car = _vehicles.FirstOrDefault(v => v.GetType() == typeof(Car) && v.Id == carId) as Car;
            if (car != null)
            {
                car.Headlights = !car.Headlights;
            }
        }

        public void DeleteCar(int carId)
        {
            var car = _vehicles.FirstOrDefault(v => v.GetType() == typeof(Car) && v.Id == carId);
            if (car != null)
            {
                _vehicles.Remove(car);
            }
        }

    }
}
