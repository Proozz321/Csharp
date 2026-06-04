using System;
using System.Threading.Tasks;
namespace async_await
{
    class Processar
    {
        public Processar(){}
        
        public async Task ProcessarBebidas()
        {
            await Task.Delay(2000);
            Console.WriteLine("Bebida Prontas");
        }

        public async Task ProcessarComidas()
        {
            await Task.Delay(5000);
            Console.WriteLine("Comida Prontas");
        }
        
    }
}