using System;
using System.Linq;           // LINQ básico (Where, Select, OrderBy...)
using System.Collections.Generic; // List, IEnumerable, Dictionary...
using System.Text.RegularExpressions;


namespace SelectMany
{
    class Program
    {
        record Funcionario(string Nome, string Deparn, double Salario);
        static void Main(string[] args)
        {
            var funcionarios = new List<Funcionario>
            {
                new Funcionario("João", "TI", 3000),
                new Funcionario("Maria", "TI", 4000),
                new Funcionario("Carlos", "RH", 2500),
                new Funcionario("Ana", "RH", 3500),
                new Funcionario("Pedro", "Financeiro", 5000),
                new Funcionario("Lucas", "Financeiro", 4500)
            };

            var grupos = funcionarios.GroupBy(f => f.Deparn);
            
            foreach (var grupo in grupos)
            {
                var media = grupo.Average(s => s.Salario);
                Console.WriteLine($"=== {grupo.Key} ===");
                foreach (var f in grupo)
                
                    Console.WriteLine($"  {f.Nome} - {f.Salario}");
                      Console.WriteLine($"  {media}");
            }
        }
    }
}