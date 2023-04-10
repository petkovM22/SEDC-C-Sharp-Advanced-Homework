using Homework01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01.Domain.Models
{
    public class Dog : Animal, IDog
    {
        public string Breed { get; set; }
        public Dog(string name, string color, int age, string breed) : base(name, color, age)
        {
            if (string.IsNullOrEmpty(breed))
            {
                Console.WriteLine("Invalid input.");
            }
            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine("The dog is barking! Woof!");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This is {Name}, he is {Age} years old and is of breed {Breed}");
        }
    }
}
