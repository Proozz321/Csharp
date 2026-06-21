using System;
using System.Collections.Generic;
namespace OrderingSystem
{
    class Pedido
    {
        private List<Item> _itens = new List<Item>();
        public List<Item> Itens => _itens;

        private Inot _not;

        public Pedido(Inot noti)
        {
            _not = noti;
        }

        public void AdicionarItem(Produtos produto, int quantidade)
        {
            _itens.Add(new Item(produto,quantidade));
        }

        public double Total()
        {
            double total = 0;
            foreach(var item in _itens)
            {
                total += item.Produto.Preco * item.Quantidade;
            }
            return(total);
        }

        public void Finalizar()
        {
            _not.Enviar("Pedido Finalizado! Total: " + Total());
        }
    }
}