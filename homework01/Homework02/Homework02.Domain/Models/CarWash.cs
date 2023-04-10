using Homework02.Domain.Interfaces;

namespace Homework02.Domain.Models
{
    public class CarWash : ICarWash
    {
        public void TruckWash(Truck truck)
        {
            Console.WriteLine($"Washing the truck {truck} ");
        }

        public void WashCar(Car car)
        {
            Console.WriteLine($"You need to wash the car {car} ");
        }
    }
}
