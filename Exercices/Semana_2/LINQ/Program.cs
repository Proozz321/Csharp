using System;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
           var resultado = new List<Filmes>
                    {
                        new Filmes("Inception", 9, "Ação"),
                        new Filmes("Titanic", 8, "Drama"),
                        new Filmes("Vingadores", 7, "Ação"),
                        new Filmes("Shrek", 6, "Comédia"),
                        new Filmes("Interstellar", 10, "Ação"),
                        new Filmes("Scary Movie", 4, "Comédia")
                    };
           
                var Anota = resultado.Where(p => p.Nota >= 7).OrderByDescending(p => p.Nota);
                var Nnome = resultado.Where(p => p.Nota >= 7).Select(p => p.Nome);
                var Ccat = resultado.Count(p => p.Categoria == "Ação");
                var media = resultado.Average(p => p.Nota);
                var n10 = resultado.Any(p => p.Nota == 10);

                
                Console.WriteLine($"=========================");
                foreach( var p in Anota)
                {
                    Console.WriteLine($"{p.Nome} - {p.Nota}");
                }

                Console.WriteLine($"=========================\nFilmes da categoria ação: {Ccat}");
                Console.WriteLine($"Tem filme nota 10? {(n10 ? "Sim" : "Não")}");
                Console.WriteLine($"=======Media======\n");
                Console.WriteLine($"{media}");
                Console.WriteLine($"=======Filtrados======\n");
                Console.WriteLine(string.Join(",",Nnome));

        }
    }
}