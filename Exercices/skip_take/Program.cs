using System;
using System.Linq;
using System.Collections.Generic;
namespace skip_take
{
    class Program
    {
        record Produto(string item, double preco);
        static void Main(string[] args)
        {
            var produtos = new List<Produto>
            {
                new Produto("Camiseta", 30.0),
                new Produto("Calça", 80.0),
                new Produto("Tênis", 120.0),
                new Produto("Meia", 10.0),
                new Produto("Boné", 45.0),
                new Produto("Jaqueta", 200.0)
            };

            Console.WriteLine("--- 1. Os 3 Produtos Mais Baratos ---");
            var Mbarato = produtos.OrderBy(p => p.preco).Take(3);
            Mostrar(Mbarato);

            Console.WriteLine("\n--- 2. Página 2 (2 itens por página) ---");
            int itensPorPagina = 2;
            int paginaAlvo = 2;

            var pagina2 = produtos
            .Skip((paginaAlvo - 1) * itensPorPagina)
            .Take(itensPorPagina);
            Mostrar(pagina2);

            Console.WriteLine("\n--- 3. Projeção: Classificação ---");
            var Proj = produtos.Select(p => new 
            {
                Nome = p.item,
                classe = p.preco > 50 ? "Caro" : "Barato" // Operador ternário elegante
            });

            foreach (var item in Proj)
            {
                Console.WriteLine($"{item.Nome} | {item.classe}");
            }


        }

        static void Mostrar(IEnumerable<Produto> lista)
        {
            foreach(var p in lista)
            {
                Console.WriteLine($"{p.item} | {p.preco}");
            }
        } 
    }
}