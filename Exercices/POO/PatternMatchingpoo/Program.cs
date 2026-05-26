using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingpoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pagamento conta = new Pagamento(100, "Boleto");
            Console.WriteLine($"Valor do pagamento: {conta.Valor}, Método: {conta.Metodo}, Valor: {conta.Valor + conta.CalcularTaxa()}, Taxa: {conta.CalcularTaxa()}");
        }
    }
}