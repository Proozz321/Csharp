using System;
namespace OrderingSystem
{
    public class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Stock { get; set; }

        public Produtos(string nome, double preco, int stock)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Stock = stock;
          
        }
    }
}