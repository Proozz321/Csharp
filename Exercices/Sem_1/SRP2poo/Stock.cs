using System;
namespace SRP2poo
{   
     class Stock
    {
        public int Quantidade { get; set; }
        
        public void GerirStock(Produto produto, int quantidade)
        {
            if (quantidade > produto.Quantidade)
            {
                Console.WriteLine("Stock insuficiente para " + produto.Nome);
            }
            else
            {
                Console.WriteLine("Stock atual para " + produto.Nome + ": " + produto.Quantidade);
            }
        }
    }
}