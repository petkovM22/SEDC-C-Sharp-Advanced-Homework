
using Homework02.Domain.Models;

namespace Homework02.Domain.Helpers
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id < 0)
            {
                Console.WriteLine("Invalid input for Id.");
            }

            if (string.IsNullOrEmpty(vehicle.Type))
            {
                Console.WriteLine("Invalid input for type.");
            }

            if (vehicle.YearOfProduction < 0)
            {
                Console.WriteLine("Invalid input for year of production.");
            }
        }
    }
}
