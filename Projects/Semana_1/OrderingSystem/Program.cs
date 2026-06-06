using System;
namespace OrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Pedido pedido = new Pedido(new Email());
            Stock estoque = new Stock();

            Console.WriteLine("\nDigite o número do produto (0 para finalizar):");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 0)
            {
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produtos produto = produtos[opcao - 1];

                if (estoque.TemStock(produto, quantidade))
                {
                    pedido.AdicionarItem(produto, quantidade);
                    estoque.AtualizarStock(produto, quantidade);
                    Console.WriteLine(produto.Nome + " adicionado ao pedido.");
                }
                else
                {
                    Console.WriteLine("Stock insuficiente.");
                }

                Console.WriteLine("\nDigite o número do produto (0 para finalizar):");
                opcao = int.Parse(Console.ReadLine());
            }

            pedido.Finalizar();

            Relatorio relatorio = new Relatorio();
            relatorio.GerarRelatorio(pedido);
        }
    }
}