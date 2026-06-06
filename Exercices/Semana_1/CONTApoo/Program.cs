using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTApoo
{
    class Program
    {
        static void Main(string[] args)
        {
           Contas[] contas = {
                new ContaPoupança(123, "João", 1000, 0, 2000, 0),
                new ContaCorrente(456, "Maria", 2000, 0, 3000, 0),
                new ContaInvestimento(789, "Pedro", 3000, 0, 4000, 0)
            };

            foreach (Contas conta in contas)
            {
                conta.exibir();
                conta.transferir(500);
                conta.depostar(200);
                conta.retirar(300);
                conta.rendimento();
                Console.WriteLine();

           }
        }
    }
}