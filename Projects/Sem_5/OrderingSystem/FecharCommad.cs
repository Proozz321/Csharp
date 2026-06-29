using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace OrderingSystem
{
    class FecharCommand : IRequest
    {
        public Pedido pAtual{get; set;}
        public FecharCommand(Pedido pedido) => pAtual = pedido;
     
    }

    class FecharHandler : IRequestHandler<FecharCommand>
    {
        public static event EventHandler<PedidoEventArgs>? PFinalizado;
        public Task Handle(FecharCommand request, CancellationToken cancellation)
        {
            request.pAtual.Finalizar();
           PFinalizado?.Invoke(this,new PedidoEventArgs(request.pAtual));

            return Task.CompletedTask;
        }
    }

      public class PedidoEventArgs : EventArgs
    {
        public Pedido Pedido {get;}
        public PedidoEventArgs(Pedido pedido) => Pedido = pedido;
    }
}