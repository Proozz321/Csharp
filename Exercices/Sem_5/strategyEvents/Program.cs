using System;
using strategyEvents;
class Program
{
    static void Main()
    {
        var est = new Station();

        var display = new Display();
        var alerta = new Alerta();

        est.NovaT += display.Exibir;
        est.NovaT += alerta.Verificar;

        Console.WriteLine("--- Mudança 1: 22°C ---");
        est.Mudar(22);
        Console.WriteLine("\n--- Mudança 2: 38°C ---");
        est.Mudar(38);
        Console.WriteLine("\n--- Mudança 3: 3°C ---");
        est.Mudar(3);
    }
}