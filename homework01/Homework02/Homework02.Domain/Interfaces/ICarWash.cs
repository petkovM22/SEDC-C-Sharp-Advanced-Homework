using Homework02.Domain.Models;


namespace Homework02.Domain.Interfaces
{
    public interface ICarWash
    {
        void WashCar(Car car);
        void TruckWash(Truck truck);
    }
}
