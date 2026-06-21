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
        private readonly Relatorio _relatorio;

        public FecharHandler(Relatorio relatorio)
        {
            _relatorio = relatorio;
        }

        public Task Handle(FecharCommand request, CancellationToken cancellation)
        {
            request.pAtual.Finalizar();
            _relatorio.GerarRelatorio(request.pAtual);

            return Task.CompletedTask;
        }
    }
}