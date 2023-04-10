using Homework02.Domain.Models;
using System.Diagnostics;

Car bmw = new Car("BMW", "black", 1, "Series 5");
bmw.Drive();

Truck volvo = new Truck("Volvo", "silver", 2, "Volvo");
volvo.Drive();

CarCenter carCenter = new CarCenter("ProfiCars", "rent a car", 27);

carCenter.WashCar(bmw);
carCenter.TruckWash(volvo);
carCenter.PumpGas();
carCenter.CheckVehicle();
carCenter.FixVehicle();

CarWash carWash = new CarWash();
carWash.WashCar(bmw);
carWash.TruckWash(volvo);

RepairService repairService = new RepairService();
repairService.CheckVehicle();
repairService.FixVehicle();

GasPump gasPump = new GasPump();
gasPump.PumpGas();
