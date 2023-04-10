using Homework02.Domain.Interfaces;
using Homework02.Domain.Models;

namespace Homework02.Domain.Models
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int NumOfVehicles { get; set; }

        public CarCenter() { }

        public CarCenter(string name, string description, int numOfVehicles)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input.");
            }
            Name = name;

            if(string.IsNullOrEmpty(description))
            {
                Console.WriteLine("Invalid input.");
            }
            Description = description;

            if (numOfVehicles > 0)
            {
                NumOfVehicles = numOfVehicles;
                Console.WriteLine($"There are {NumOfVehicles} in our {Name} car center.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public void CheckVehicle()
        {
            Console.WriteLine("Your car is checked and is ready for driving.");
        }

        public void WashCar(Car car)
        {
            Console.WriteLine("You need to wash your car.");

        }

        public void TruckWash(Truck truck)
        {
            Console.WriteLine("You need to wash your truck.");
        }

        public void PumpGas()
        {
            Console.WriteLine("You need to pump gas in your vehicle.");
        }

        public bool FixVehicle()
        {
            Console.WriteLine("Your car needs fixing.");
            return false;
        }
    }
}
