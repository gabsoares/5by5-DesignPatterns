using _5by5_Controllers;
using _5by5_Models;

namespace _5by5_ProjAula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio do processamento.");

            Car car = new Car
            {
                Id = 6,
                Name = "Lamborghini",
                Color = "Preta",
                Year = 2024
            };
            //for (int i = 1; i <= 10000; i++)
            //{
            //    car.Name = "Teste " + i.ToString();
            //    Console.WriteLine(new CarController().Insert(car) ? "Registro Inserido - " + car.Name : "Erro ao inserir registro");
            //}

            Console.WriteLine("--EXEMPLO GETALL--");
            var cars = new CarController().GetAll();
            foreach (var c in cars.Where(c => c.Id > 990).ToList().Take(10))
            {
                Console.WriteLine(c);
            }
            /*
            Console.WriteLine(car);
            Console.WriteLine("--EXEMPLO INSERT--");
            Console.WriteLine(new CarController().Insert(car) ? "Registro Inserido" : "Erro ao inserir registro");

            Console.WriteLine("--EXEMPLO UPDATE--");
            Console.WriteLine(new CarController().Update(car) ? "Registro atualizado" : "Erro ao atualizar registro");

            Console.WriteLine("--EXEMPLO DELETE--");
            Console.WriteLine(new CarController().Delete(3) ? "Registro deletado" : "Erro ao deletar registro");

            Console.WriteLine("--EXEMPLO GETALL--");
            foreach (var item in new CarController().GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--EXEMPLO GET--");
            Console.WriteLine(new CarController().Get(2));
            */

        }
    }
}
