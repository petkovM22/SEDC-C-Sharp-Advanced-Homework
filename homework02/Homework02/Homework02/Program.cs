
using Homework02.Domain;
using Homework02.Domain.Helpers;
using Homework02.Domain.Models;

foreach (Vehicle vehicle in DataBase.Vehicles)
{
    vehicle.PrintVehicle();
}

Car car = new Car(7, "Car", 2010, 366, 70, new List<string> { "USA", "Macedonia" });
car.PrintVehicle();
Validator.Validate(car);

Bike bike = new Bike(8, "Bike", 2008, 244, "Blue");
bike.PrintVehicle();
Validator.Validate(bike);

