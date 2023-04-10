using Homework01.Domain.Models;

Dog blacky = new Dog("Blacky","black", 2, "pitbull");
blacky.PrintAnimal();
blacky.Bark();

Cat johnny = new Cat("Johnny","orange", 1, 1);
johnny.PrintAnimal();
johnny.Eat("fish");