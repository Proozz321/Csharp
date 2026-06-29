using System;
namespace OrderingSystem
{
    public interface Inot
    {
        public void Enviar(string mensagem);
    }

    public interface Istock
    {
        bool TemStock(Produtos produto, int quantidade);
        void AtualizarStock(Produtos produto, int quantidade);
    }

    public interface Irelatorio
    {
        void GerarRelatorio(Pedido pedido);
    }
}