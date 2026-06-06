using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordPatternpoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encomenda p1 = new Encomenda(10.5, "Internacional");
            Encomenda p2 = new Encomenda(10.5, "Expresso");
            Encomenda p3 = new Encomenda(10.5, "Nacional");
            Encomenda p4 = new Encomenda(10.5, "Nacional");

            if(p1 == p2 || p2 == p3 || p3 == p4 || p1 == p4)
            {
                Console.WriteLine("As encomendas Igual, Produito ja enviado!");
            }
                Console.WriteLine($"Destino: {p1.Destino} | Peso: {p1.Peso}kg | Preço: R$ {p1.Edestino():F2}");
                Console.WriteLine($"Destino: {p2.Destino} | Peso: {p2.Peso}kg | Preço: R$ {p2.Edestino():F2}");
                Console.WriteLine($"Destino: {p3.Destino} | Peso: {p3.Peso}kg | Preço: R$ {p3.Edestino():F2}");
                Console.WriteLine($"Destino: {p4.Destino} | Peso: {p4.Peso}kg | Preço: R$ {p4.Edestino():F2}");
            

        }
    }
}