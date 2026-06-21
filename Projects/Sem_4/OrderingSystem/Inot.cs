using System;
namespace OrderingSystem
{
    interface Inot
    {
        public void Enviar(string mensagem);
    }

    interface Istock
    {
        bool TemStock(Produtos produto, int quantidade);
        void AtualizarStock(Produtos produto, int quantidade);
    }

    interface Irelatorio
    {
        void GerarRelatorio(Pedido pedido);
    }
}