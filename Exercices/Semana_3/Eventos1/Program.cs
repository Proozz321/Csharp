using System;
namespace Eventos1
{  
    class Program
    {
        static void Main(string[] args)
        {
            Monitor monitor = new Monitor();
            monitor.Atemp += (temp) => Console.WriteLine($"temperatura {temp} perigosa");
            
            Console.WriteLine("temp: ");
            int temp = int.Parse(Console.ReadLine());
            monitor.Verificar(temp);
        }
    }
}