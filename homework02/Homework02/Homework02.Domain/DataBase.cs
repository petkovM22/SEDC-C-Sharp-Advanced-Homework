
using Homework02.Domain.Models;

namespace Homework02.Domain
{
    public static class DataBase
    {
        public static List<Vehicle> Vehicles;

        static DataBase()
        {
            Vehicles = new List<Vehicle>()
            {
                new Vehicle(1,"Truck", 1999, 123),
                new Vehicle(2,"Van", 2015, 1234),
                new Bike(3,"Bike", 2020, 223, "Black"),
                new Bike(4,"Bike", 2015, 233, "Red"),
                new Car(5, "Car", 2021, 344, 50,new List<string> {"Macedonia", "Serbia", "Germany"}),
                new Car(6, "Car", 2005, 355, 100, new List<string> {"Italy", "Slovenia", "Bulgaria"})
            };
        }
    }
}
