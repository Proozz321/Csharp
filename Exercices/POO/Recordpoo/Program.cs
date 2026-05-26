using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recordpoo
{
    public record Produto(string nome, string categoria, int preco);
    public record Cliente(string nome, int idade);

    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Produto("Laptop", "Eletrônicos", 1000);
            var p2 = new Produto("Laptop", "Eletrônicos", 1000);

            var p3 = new Cliente("João", 30);
            var p4 = new Cliente("João", 30);

            Console.WriteLine("Produto" + (p1 == p2)); // True
            Console.WriteLine("Cliente" + (p3 == p4)); // True
         }
    }
    
}