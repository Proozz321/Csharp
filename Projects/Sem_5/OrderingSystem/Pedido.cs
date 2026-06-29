using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace OrderingSystem
{
    public class Pedido
    {
        private List<Item> _itens = new List<Item>();
        public List<Item> Itens => _itens;
        private IDesconto _desconto = new SemDesc();
        private Inot _not;
        public event Action<string, double>? FPedido;

        public Pedido(Inot not)
        {
            _not = not;
            _desconto = new SemDesc();
        }

        public void Dstr(IDesconto stg)
        {
            _desconto = stg;
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
            return total;
        }

        public double TDesco()
        {
            double Tpedido = Total();
            return Tpedido - _desconto.CalcularDesconto(Tpedido);
        }

        public void Finalizar()
        {
            double Tpedido = Total();
            double Tdesc = TDesco();
            string mensagem = $"Pedido Finalizado! Total: {Tpedido} | desconto: {Tdesc}";
            FPedido?.Invoke(mensagem,Tpedido);
        }
    }
}