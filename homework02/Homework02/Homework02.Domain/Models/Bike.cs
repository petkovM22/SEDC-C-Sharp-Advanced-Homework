
namespace Homework02.Domain.Models
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public Bike() { }

        public Bike(int id, string type, int yearOfProduction, int batchNumber, string color) : base(id, type, yearOfProduction, batchNumber)
        {
            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid input for color.");
            }
            Color = color;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"This bike is produced in year: {YearOfProduction} and it's color is: {Color}");
        }

    }
}
