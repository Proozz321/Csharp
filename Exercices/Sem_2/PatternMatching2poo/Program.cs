using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching2poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme filme1 = new Filme("O Poderoso Chefão", 4, "Crime");
            Console.WriteLine($"Título: {filme1.Titulo}");
            Console.WriteLine($"Nota: {filme1.FNota()}");
            Console.WriteLine($"Gênero: {filme1.FGenero()}");

            Filme filme2 = new Filme("Vingadores: Ultimato", 7, "Ação");
            Console.WriteLine($"\nTítulo: {filme2.Titulo}");
            Console.WriteLine($"Nota: {filme2.FNota()}");
            Console.WriteLine($"Gênero: {filme2.FGenero()}");

            Filme filme3 = new Filme("A Vida é Bela", 8, "Comédia");
            Console.WriteLine($"\nTítulo: {filme3.Titulo}");
            Console.WriteLine($"Nota: {filme3.FNota()}");
            Console.WriteLine($"Gênero: {filme3.FGenero()}");
        }
    }
}