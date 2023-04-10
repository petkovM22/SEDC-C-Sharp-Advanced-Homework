using Homework02.Domain.Interfaces;

namespace Homework02.Domain.Models
{
    public class GasPump : IGasPump
    {
        public void PumpGas()
        {
            Console.WriteLine($"You need to pump gas in the vehicle!");
        }
    }
}
