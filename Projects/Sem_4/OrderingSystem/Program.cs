using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MediatR;

namespace OrderingSystem
{
    class Program
    {
        static async Task Main(string[] args)
        {
           var services = new ServiceCollection();
           services.AddLogging();

           services.AddTransient<Inot, Email>();
           services.AddTransient<Stock>();
           services.AddTransient<Relatorio>();
           services.AddTransient<Pedido>();

           services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

           var provider = services.BuildServiceProvider();

           Produtos[] produtos = {
                new Produtos("Camiseta", 19.99, 50),
                new Produtos("Calça Jeans", 49.99, 30),
                new Produtos("Tênis", 89.99, 20)
            };

            Console.WriteLine("=== SISTEMA DE PEDIDOS ===\n");
            Console.WriteLine("Produtos disponíveis:");
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {produtos[i].Nome} | R$ {produtos[i].Preco} | Estoque: {produtos[i].Stock}");
            }

            var pedido = provider.GetService<Pedido>();
            var estoque = provider.GetService<Stock>();

            if (pedido == null || estoque == null)
           {
               Console.WriteLine("Erro ao iniciar as dependências do sistema.");
               return;
           }

            // 3. Chamar a Fábrica inteligente para iniciar o fluxo em cascata
            Console.WriteLine("\nDigite o numero do produto(0 para finalizar):");
            int op = int.Parse(Console.ReadLine());

            while(op != 0)
            {
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produtos produto = produtos[op-1];

                if(estoque.TemStock(produto, quantidade))
                {
                    pedido.AdicionarItem(produto, quantidade);
                    estoque.AtualizarStock(produto, quantidade);
                    Console.WriteLine(produto.Nome + " adicionado ao pedido.");
                }
                else
                {
                    Console.WriteLine("Stock insuficiente");
                }

               Console.WriteLine("\nDigite o número do produto (0 para finalizar):");
               op = int.Parse(Console.ReadLine());

            }
            var mediator = provider.GetService<IMediator>();
            var comando = new FecharCommand(pedido);
            await mediator.Send(comando);

            Console.ReadLine();

        }
    }
}