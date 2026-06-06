using System;
namespace OrderingSystem
{
    class Stock
    {
        int quantidade;

        public bool TemStock(Produtos produto,int quantidade)
        {
            return produto.Stock >= quantidade;
        }

        public void AtualizarStock(Produtos produto, int quantidade)
        {
            produto.Stock -= quantidade;
        }
    }
}