

namespace Homework01.Domain.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Age { get; set; }

        public abstract void PrintAnimal();

        public Animal()
        {

        }

        public Animal(string name, string color, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input.");
            }
            Name = name;
            if(string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid input.");
            }
            Color = color;
            if (age > 0)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
