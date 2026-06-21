using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using DIP;

internal class Program
{
    private static void Main(string[] args)
    {
        var service = new ServiceCollection();
        service.AddTransient<INotificadorService, NotificadorEmail>();
        service.AddTransient<PedidoProcessador>();

        var serviceProvider = service.BuildServiceProvider();

        var not = serviceProvider.GetService<PedidoProcessador>();
        not.FinalizarPedido();

        Console.ReadLine();
    }
}