using System;
namespace OrderingSystem
{
    public class Item
    {
        public Produtos Produto { get; set; }
        public int Quantidade { get; set; }

        public Item(Produtos produto, int quantidade){
            this.Produto = produto;
            this.Quantidade = quantidade;
        }
    }
}