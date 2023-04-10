using Homework01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01.Domain.Models
{
    public class Cat : Animal, ICat
    {
        public int Id { get; set; }
        public Cat(string name,string color, int age,int id) : base(name, color, age)
        {
            if (id > 0)
            {
                Id = id;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public void Eat(string food)
        {
            Console.WriteLine($"This is the cat {Name}, and it is eating {food}");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This is {Name}, and he is {Age} years old.");
        }
    }
}
