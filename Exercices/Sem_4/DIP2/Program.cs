using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using DIP2;

namespace DIP2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var service = new ServiceCollection();

            service.AddTransient<Idesconto, Desconto>();
            service.AddSingleton<Ivenda, Venda>();
            service.AddTransient<Registradora>();

            var provider = service.BuildServiceProvider();
            var Caixa = provider.GetService<Registradora>();
            
            Caixa.Fechar(100);
            Caixa.Fechar(50);
            Caixa.Fechar(200);

            var repo = provider.GetService<Ivenda>();
            Console.WriteLine($"Total Acumulado no caixa: {repo.Obter():C}");
            
        }
    }
}