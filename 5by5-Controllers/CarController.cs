using _5by5_Models;
using _5by5_Services;

namespace _5by5_Controllers
{
    public class CarController
    {
        private CarService _carService;

        public CarController()
        {
            _carService = new();
        }
        public bool Insert(Car car)
        {
            return _carService.Insert(car);
        }

        public bool Delete(int id)
        {
            return _carService.Delete(id);
        }

        public bool Update(Car car)
        {
            return _carService.Update(car);
        }

        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }

        public Car Get(int id)
        {
            return _carService.Get(id);
        }
    }
}