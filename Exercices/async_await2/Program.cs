using System;
using System.Threading.Tasks;
namespace async_await2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int id;

            Console.WriteLine("numero do id:");
            id = Convert.ToInt32(Console.ReadLine());

            Biblioteca biblioteca = new Biblioteca(id);

            Task<string> buscarTask = biblioteca.BuscarLivro(id);
            Task<string> autorTask = biblioteca.AutorLivro(id);

            string[] res = await Task.WhenAll(buscarTask, autorTask);
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
        }
    }
}