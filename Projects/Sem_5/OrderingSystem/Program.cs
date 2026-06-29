using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
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
            services.AddTransient<IDesconto, DescSazonal>();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

            var provider = services.BuildServiceProvider();

            provider.GetService<Relatorio>();
            FecharHandler.PFinalizado += (sender, e) => provider.GetService<Relatorio>()?.GerarRelatorio(e.Pedido);

            Produtos[] produtos = {
                new Produtos("Camiseta", 19.99, 50),
                new Produtos("Calça Jeans", 49.99, 30),
                new Produtos("Tênis", 89.99, 20)
            };

            Console.WriteLine("=== SISTEMA DE PEDIDOS ===\n\nProdutos disponíveis:");
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {produtos[i].Nome} | R$ {produtos[i].Preco} | Estoque: {produtos[i].Stock}");
            }

            var pedido = provider.GetService<Pedido>();
            var estoque = provider.GetService<Stock>();
            var mediator = provider.GetService<IMediator>();

            if (pedido == null || estoque == null || mediator == null)
            {
                Console.WriteLine("Erro crítico ao carregar os serviços do sistema.");
                return;
            }

            pedido.Dstr(provider.GetService<IDesconto>() ?? new SemDesc());

            while (true)
            {
                Console.WriteLine("\nDigite o numero do produto (0 para finalizar):");
                if (!int.TryParse(Console.ReadLine(), out int op) || op == 0) break; 
                if (op < 1 || op > produtos.Length)
                {
                    Console.WriteLine("Opção inválida.");
                }

                Console.Write("Quantidade: ");
                if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade <= 0)
                {
                    Console.WriteLine("Quantidade inválida.");
                    continue;
                }

                Produtos produto = produtos[op - 1];

                if (estoque.TemStock(produto, quantidade))
                {
                    pedido.AdicionarItem(produto, quantidade);
                    estoque.AtualizarStock(produto, quantidade);
                    Console.WriteLine($"{produto.Nome} adicionado ao pedido.");
                }
                else
                {
                    Console.WriteLine("Stock insuficiente.");
                }
            }

            await mediator.Send(new FecharCommand(pedido));

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}