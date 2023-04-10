
namespace Homework02.Domain.Models
{
    public class Truck : Vehicle
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public Truck() { }

        public Truck(string name, string color, int id, string model) : base(id, model)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input.");
            }
            Name = name;

            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid input.");
            }
            Color = color;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {Color} {Name} {Model} truck is driving down the road.");
        }
    }
}
