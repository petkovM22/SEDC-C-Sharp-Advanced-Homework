using Homework02.Domain.Models;

namespace Homework02.Domain.Interfaces
{
    public interface IRepairService
    {
        void CheckVehicle();
        bool FixVehicle();
    }
}
