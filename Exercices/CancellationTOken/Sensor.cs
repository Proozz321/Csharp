using System;
using System.Threading.Tasks;
namespace CancellationTOken
{
    class Sensor
    {
        public async Task<string> Monitorar(CancellationToken cts)
        {
            while (!cts.IsCancellationRequested)
            {
                Console.WriteLine("Monitorando...");
                await Task.Delay(1000, cts);
                Console.WriteLine("Temperatura atual: " + new Random().Next(20, 30) + "°C");
            }
        }
    }
}