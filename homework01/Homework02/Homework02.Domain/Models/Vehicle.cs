
namespace Homework02.Domain.Models
{
    public abstract class Vehicle
    {

        public int Id { get; set; }

        public string Model { get; set; }


        public abstract void Drive();

        public Vehicle() { }
        public Vehicle(int id, string model)
        {
            if (id > 0)
            {
                id = id;
            }
            else
            {
                Console.WriteLine("Invalid input for id.");
            }

            if (string.IsNullOrEmpty(model))
            {
                Console.WriteLine("Invalid input for model.");
            }
            model = model;

        }
    }
}
