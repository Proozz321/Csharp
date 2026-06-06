using System;
using System.Linq;           // LINQ básico (Where, Select, OrderBy...)
using System.Collections.Generic; // List, IEnumerable, Dictionary...
using System.Text.RegularExpressions;


namespace Join
{
    class Program
    {
        record Produto(int num, string Item, int ID);
        record Categoria(int ID, string Tipo);
        static void Main(string[] args)
        {
         var produtos = new List<Produto>
        {
            new Produto(1, "Laptop", 1),
            new Produto(2, "Camiseta", 2),
            new Produto(3, "Smartphone", 1),
            new Produto(4, "Calça", 2),
            new Produto(5, "Fone", 1)
        };

        var categorias = new List<Categoria>
        {
            new Categoria(1, "Eletrônicos"),
            new Categoria(2, "Roupas")
        };

        var resultado = produtos.Join(categorias,p => p.ID,c => c.ID,(p, c) => new 
                {
                Produto = p.Item,
                Categoria = c.Tipo
                }
        );
        foreach(var res in resultado)
        {
            Console.WriteLine(res);
        }

        var eletronicos = resultado.Where(r => r.Categoria == "Eletrônicos").Select(r => r.Produto);

        Console.WriteLine("\n=== Só Eletrônicos ===");
        foreach (var p in eletronicos)
            Console.WriteLine(p);
        }
    }
}