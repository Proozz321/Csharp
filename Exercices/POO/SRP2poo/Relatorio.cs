using System;
namespace SRP2poo
{
    class Relatorio
    {
        public void GerarRelatorio(Produto p)
        {
            Console.WriteLine("Relatório do Produto:");
            Console.WriteLine("Nome: " + p.Nome);
            Console.WriteLine("Preço: " + p.Preco);
            Console.WriteLine("Quantidade: " + p.Quantidade);
        }
    }
    
}