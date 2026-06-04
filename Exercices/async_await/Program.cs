using System;
using System.Threading.Tasks;
namespace async_await
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Processar processar = new Processar();
            Console.WriteLine("Processando...");
            Task bebidasTask = processar.ProcessarBebidas();
            Task comidasTask = processar.ProcessarComidas();
            await Task.WhenAll(bebidasTask, comidasTask);
            Console.WriteLine("Tudo pronto!");
        }
    }
}