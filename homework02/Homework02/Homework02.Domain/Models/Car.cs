﻿
namespace Homework02.Domain.Models
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }

        public List<string> Countries { get; set; }

        public Car()
        {
            Countries = new List<string>();
        }

        public Car(int id, string type, int yearOfProduction, int batchNumber, int fuelTank, List<string> countries) : base(id, type, yearOfProduction, batchNumber)
        {
            if (fuelTank < 1 || fuelTank == null)
            {
                Console.WriteLine("Invalid input for FuelTank");
            }
            FuelTank = fuelTank;
            Countries = countries;
        }

        public override void PrintVehicle()
        {
            string counter = " ";
            foreach (string country in Countries)
            {
                counter += country + ", ";
            }
            Console.WriteLine($"Vehicle type: {Type} \n Country produced: " + counter);
        }
    }
}
