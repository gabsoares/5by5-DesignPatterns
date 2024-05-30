using _5by5_Models;
using _5by5_Repositories;

namespace _5by5_Services
{
    public class CarService
    {
        private CarRepository _carRepository;
        public CarService()
        {
            _carRepository = new();
        }

        public bool Insert(Car car)
        {
            Console.WriteLine("Camada Service");
            return _carRepository.Insert(car);
        }

        public bool Update(Car car)
        {
            return _carRepository.Update(car);
        }

        public bool Delete(int id)
        {
            return _carRepository.Delete(id);
        }

        public List<Car> GetAll()
        {
            return _carRepository.GetAll();
        }

        public Car Get(int id)
        {
            return _carRepository.Get(id);
        }
    }
}
