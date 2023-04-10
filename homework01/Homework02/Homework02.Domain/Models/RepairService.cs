using Homework02.Domain.Interfaces;

namespace Homework02.Domain.Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine($"Checking vehicle ");
        }

        public bool FixVehicle()
        {
            Console.WriteLine($"Your vehicle is fixed!");
            return true;
        }
    }
}
