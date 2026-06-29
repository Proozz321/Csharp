using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Func_Action3
{
    class Programa
    {
        static void Main(string[] args)
        {
            Compra c = new Compra();
            c.FinalizarCompra(200.00, valor => valor * 0.9, valor => Console.WriteLine($"Valor final: {valor}"));
            c.FinalizarCompra(100.00, valor => valor - 20.00, valor => Console.WriteLine($"Valor final: {valor}"));

        }
    }
}