using System;
namespace SRP2poo
{
    class Preço 
    {
        public double desconto { get; set; }
        
        public void CalcularPreco(Produto p,double desconto)
        {
            double total = p.Preco * p.Quantidade;
            Console.WriteLine("O preço total de " + p.Nome + " é: " + total);
            total -= total * desconto;
            Console.WriteLine("O preço com desconto é: " + total);
        }
    }
}