using System;
namespace SRP2poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] produtos = {
                new Produto("Camiseta", 50.0, 100),
                new Produto("Calça", 100.0, 50),
            };

            var relatorio = new Relatorio();
            var stock = new Stock();
            var calculador = new Preço();

            foreach (var item in produtos)
            {
                relatorio.GerarRelatorio(item);
                stock.GerirStock(item, 20);
                calculador.CalcularPreco(item, 0.10);
            }
        }
    }
}