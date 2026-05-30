using System;
using System.Linq;           // LINQ básico (Where, Select, OrderBy...)
using System.Collections.Generic; // List, IEnumerable, Dictionary...
using System.Text.RegularExpressions;


namespace SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            var turmas = new List<List<string>>
            {
                new List<string> { "Ana", "Bruno", "Carlos" },
                new List<string> { "Amanda", "Diego", "Eduardo" },
                new List<string> { "Fernanda", "Alice", "Gabriel" }
            };

            var todos = turmas.SelectMany(t => t).ToList();
            var cont = todos.Count();
            var cmA = todos.Where(a => a.StartsWith("A"));

             Console.WriteLine("ALUNOOO...................");
            foreach(var turma in todos)
            {
                Console.WriteLine(turma);
                
            }
            Console.WriteLine("TURMAS...................");
            Console.WriteLine(cont);
            Console.WriteLine("ALUNOS COM A......................");
            foreach(var turma in cmA)
            {
                Console.WriteLine(turma);
                
            }

        }
    }
}