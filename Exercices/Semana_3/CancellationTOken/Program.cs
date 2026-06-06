using System;
using System.Threading.Tasks;
namespace CancellationTOken
{
    class Program
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            Sensor sensor = new Sensor();


            Task<string> monitorarTask = sensor.Monitorar(cts.Token);
            

            Console.WriteLine("Pressione Enter para cancelar o monitoramento.");
            
            Console.ReadKey();
            cts.Cancel();

            try
            {   
                await monitorarTask;
            }
            catch(OperationCanceledException)
            {
                Console.WriteLine("Monitoramento cancelado pelo usuário.");
            }
        }
    }
}